using System.Text.Json.Serialization;

namespace TelemetryDashboard.Models
{
    public class SensorData
    {
        [JsonPropertyName("acceleration_x")]
        public double AccelerationX { get; set; }

        [JsonPropertyName("acceleration_y")]
        public double AccelerationY { get; set; }

        [JsonPropertyName("acceleration_z")]
        public double AccelerationZ { get; set; }

        [JsonPropertyName("orientation_pitch")]
        public double OrientationPitch { get; set; }

        [JsonPropertyName("orientation_roll")]
        public double OrientationRoll { get; set; }

        [JsonPropertyName("orientation_yaw")]
        public double OrientationYaw { get; set; }

        [JsonPropertyName("rotational_velocity_x")]
        public double RotationalVelocityX { get; set; }

        [JsonPropertyName("rotational_velocity_y")]
        public double RotationalVelocityY { get; set; }

        [JsonPropertyName("rotational_velocity_z")]
        public double RotationalVelocityZ { get; set; }

        public double Timestamp { get; set; }
    }
}
