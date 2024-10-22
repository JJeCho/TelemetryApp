using System.Text.Json.Serialization;

namespace TelemetryDashboard.Models
{
    public class CommunicationsData
    {
        [JsonPropertyName("uplink_latency")]
        public double UplinkLatency { get; set; }

        [JsonPropertyName("downlink_latency")]
        public double DownlinkLatency { get; set; }

        [JsonPropertyName("packet_loss_rate")]
        public double PacketLossRate { get; set; }

        [JsonPropertyName("data_transfer_rate")]
        public double DataTransferRate { get; set; }

        public double Timestamp { get; set; }
    }
}
