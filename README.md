# TelemetryApp

## Overview

TelemetryApp is a WPF-based desktop application designed for visualizing real-time telemetry data. It uses SignalR for receiving data streams and LiveCharts for dynamic data visualization. This application is ideal for monitoring live telemetry data in a user-friendly interface.

## Features

- **Real-time Data Visualization**: Uses LiveCharts to display telemetry data in various chart formats.
- **SignalR Integration**: Connects to SignalR hubs for receiving live telemetry updates.
- **MVVM Architecture**: Designed with the Model-View-ViewModel (MVVM) pattern for better separation of concerns and maintainability.
- **Customizable UI**: Modify the XAML files for a tailored user interface.

## Getting Started

### Prerequisites

- .NET 6.0 SDK or higher
- Visual Studio 2022 or later (recommended for WPF development)

### Installation

Clone the repository and navigate into the project directory:

```bash
git clone https://github.com/yourusername/TelemetryApp.git
cd TelemetryApp
```

### Configuration

Before running the application, you can adjust the SignalR connection settings in the `MainWindow.xaml.cs` file:

- **Hub URL**: Modify the URL of the SignalR hub to match your telemetry data source.
- **Telemetry Data Model**: Customize the `TelemetryData` model in the `Models` folder to fit the structure of your data.

### Usage

To run the application, use the following command:

```bash
dotnet run
```

Alternatively, open the solution in Visual Studio and run the project directly.

### Example

Upon starting, the application will connect to the specified SignalR hub and begin displaying telemetry data in real-time charts.

### Customization

- **Chart Appearance**: Adjust the XAML files in `MainWindow.xaml` to change the layout and style of the charts.
- **Data Processing**: Modify the data handling logic in `MainWindow.xaml.cs` to process and display different types of telemetry data.

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests for enhancements, bug fixes, or new features.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.

## Acknowledgments

Inspired by the need for a responsive and visually appealing interface for monitoring real-time telemetry data.
