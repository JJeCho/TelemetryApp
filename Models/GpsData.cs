using System.Text.Json.Serialization;

namespace TelemetryDashboard.Models
{
    public class GpsData
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("altitude")]
        public double Altitude { get; set; }

        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        public double Timestamp { get; set; }
    }
}
