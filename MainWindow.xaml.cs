using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;
using TelemetryDashboard.Models;

namespace TelemetryDashboard
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private HubConnection _hubConnection;
        private TelemetryData _telemetryData;

        public TelemetryData TelemetryData
        {
            get => _telemetryData;
            set
            {
                _telemetryData = value;
                OnPropertyChanged(nameof(TelemetryData));
            }
        }

        public SeriesCollection AccelerationSeries { get; set; }
        public string[] AccelerationLabels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            TelemetryData = new TelemetryData();
            InitializeCharts();
            StartSignalRConnection();
        }

        private void InitializeCharts()
        {
            AccelerationSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Acceleration X",
                    Values = new ChartValues<double>()
                },
                new LineSeries
                {
                    Title = "Acceleration Y",
                    Values = new ChartValues<double>()
                },
                new LineSeries
                {
                    Title = "Acceleration Z",
                    Values = new ChartValues<double>()
                }
            };

            YFormatter = value => value.ToString("0.00");

            OnPropertyChanged(nameof(AccelerationSeries));
            OnPropertyChanged(nameof(YFormatter));
        }

        private async void StartSignalRConnection()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/telemetryHub")
                .WithAutomaticReconnect()
                .Build();

            _hubConnection.On<TelemetryData>("ReceiveTelemetryData", data =>
            {
                TelemetryData = data;
                UpdateCharts(data);
            });

            try
            {
                await _hubConnection.StartAsync();
                Console.WriteLine("Connected to SignalR hub.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to SignalR hub: {ex.Message}");
            }
        }

        private void UpdateCharts(TelemetryData data)
        {
            Dispatcher.Invoke(() =>
            {
                var seriesX = AccelerationSeries[0] as LineSeries;
                var seriesY = AccelerationSeries[1] as LineSeries;
                var seriesZ = AccelerationSeries[2] as LineSeries;

                seriesX.Values.Add(data.SensorData.AccelerationX);
                seriesY.Values.Add(data.SensorData.AccelerationY);
                seriesZ.Values.Add(data.SensorData.AccelerationZ);

                if (seriesX.Values.Count > 50)
                {
                    seriesX.Values.RemoveAt(0);
                    seriesY.Values.RemoveAt(0);
                    seriesZ.Values.RemoveAt(0);
                }
            });
        }

        private async void Window_Closing(object sender, CancelEventArgs e)
        {
            if (_hubConnection != null)
            {
                await _hubConnection.StopAsync();
                await _hubConnection.DisposeAsync();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
