using System.Text.Json.Serialization;

namespace TelemetryDashboard.Models
{
    public class SystemHealthData
    {
        [JsonPropertyName("battery_level")]
        public double BatteryLevel { get; set; }

        [JsonPropertyName("signal_strength")]
        public double SignalStrength { get; set; }

        [JsonPropertyName("error_code")]
        public int ErrorCode { get; set; }

        [JsonPropertyName("internal_temperature")]
        public double InternalTemperature { get; set; }

        public double Timestamp { get; set; }
    }
}
