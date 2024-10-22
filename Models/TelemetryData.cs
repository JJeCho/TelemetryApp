using System.Text.Json.Serialization;

namespace TelemetryDashboard.Models
{
    public class TelemetryData
    {
        [JsonPropertyName("gps_data")]
        public GpsData GpsData { get; set; }

        [JsonPropertyName("sensor_data")]
        public SensorData SensorData { get; set; }

        [JsonPropertyName("environmental_data")]
        public EnvironmentalData EnvironmentalData { get; set; }

        [JsonPropertyName("system_health_data")]
        public SystemHealthData SystemHealthData { get; set; }

        [JsonPropertyName("communications_data")]
        public CommunicationsData CommunicationsData { get; set; }

        public double Timestamp { get; set; }
    }
}
