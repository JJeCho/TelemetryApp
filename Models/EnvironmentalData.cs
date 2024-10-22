using System.Text.Json.Serialization;

namespace TelemetryDashboard.Models
{
    public class EnvironmentalData
    {
        [JsonPropertyName("temperature")]
        public double Temperature { get; set; }

        [JsonPropertyName("humidity")]
        public double Humidity { get; set; }

        [JsonPropertyName("pressure")]
        public double Pressure { get; set; }

        public double Timestamp { get; set; }
    }
}
