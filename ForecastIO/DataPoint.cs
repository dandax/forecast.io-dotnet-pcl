using System;
using System.Runtime.Serialization;

namespace ForecastIO
{
    [DataContract]
    public class DataPoint
    {
        public DateTime Time { get; set; }

        [DataMember(Name = "time")]
        private int TimeSerialized { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        public DateTime SunriseTime { get; set; }

        [DataMember(Name = "sunriseTime")]
        private int SunriseTimeSerialized { get; set; }

        public DateTime SunsetTime { get; set; }

        [DataMember(Name = "sunsetTime")]
        private int SunsetTimeSerialized { get; set; }

        [DataMember(Name = "precipIntensity")]
        public double PrecipIntensity { get; set; }

        [DataMember(Name = "precipIntensityError")]
        public double PrecipIntensityError { get; set; }

        [DataMember(Name = "precipIntensityMax")]
        public double PrecipIntensityMax { get; set; }

        [DataMember(Name = "precipIntensityMaxError")]
        public double PrecipIntensityMaxError { get; set; }

        [DataMember(Name = "precipProbability")]
        public double PrecipProbability { get; set; }

        [DataMember(Name = "precipProbabilityError")]
        public double PrecipProbabilityError { get; set; }

        [DataMember(Name = "precipType")]
        public string PrecipType { get; set; }

        [DataMember(Name = "precipAccumulation")]
        public double PrecipAccumulation { get; set; }

        [DataMember(Name = "precipAccumulationError")]
        public double PrecipAccumulationError { get; set; }

        [DataMember(Name = "temperature")]
        public double Temperature { get; set; }

        [DataMember(Name = "temperatureError")]
        public double TemperatureError { get; set; }

        [DataMember(Name = "temperatureMin")]
        public double TemperatureMin { get; set; }

        [DataMember(Name = "temperatureMinError")]
        public double TemperatureMinError { get; set; }

        public DateTime TemperatureMinTime { get; set; }

        [DataMember(Name = "temperatureMinTime")]
        private int TemperatureMinTimeSerialized { get; set; }

        [DataMember(Name = "temperatureMax")]
        public double TemperatureMax { get; set; }

        [DataMember(Name = "temperatureMaxError")]
        public double TemperatureMaxError { get; set; }

        public DateTime TemperatureMaxTime { get; set; }

        [DataMember(Name = "temperatureMaxTime")]
        private int TemperatureMaxTimeSerialized { get; set; }

        [DataMember(Name = "dewPoint")]
        public double DewPoint { get; set; }

        [DataMember(Name = "dewPointError")]
        public double DewPointError { get; set; }

        [DataMember(Name = "windSpeed")]
        public double WindSpeed { get; set; }

        [DataMember(Name = "windSpeedError")]
        public double WindSpeedError { get; set; }

        [DataMember(Name = "windBearing")]
        public int WindBearing { get; set; }

        [DataMember(Name = "cloudCover")]
        public double CloudCover { get; set; }

        [DataMember(Name = "cloudCoverError")]
        public double CloudCoverError { get; set; }

        [DataMember(Name = "humidity")]
        public double Humidity { get; set; }

        [DataMember(Name = "humidityError")]
        public double HumidityError { get; set; }

        [DataMember(Name = "pressure")]
        public double Pressure { get; set; }

        [DataMember(Name = "pressureError")]
        public double PressureError { get; set; }

        [DataMember(Name = "visibility")]
        public double Visibility { get; set; }

        [DataMember(Name = "visibilityError")]
        public double VisibilityError { get; set; }

        [DataMember(Name = "ozone")]
        public double Ozone { get; set; }

        [DataMember(Name = "ozoneError")]
        public double OzoneError { get; set; }

        [OnDeserialized]
        void OnDeserializing(StreamingContext context)
        {
            if (this.TimeSerialized != 0)
            {
                this.Time = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.TimeSerialized);
            }
            if (this.SunriseTimeSerialized != 0)
            {
                this.SunriseTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.SunriseTimeSerialized);
            }
            if (this.SunsetTimeSerialized != 0)
            {
                this.SunsetTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.SunsetTimeSerialized);
            }
            if (this.TemperatureMinTimeSerialized != 0)
            {
                this.TemperatureMinTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.TemperatureMinTimeSerialized);
            }
            if (this.TemperatureMaxTimeSerialized != 0)
            {
                this.TemperatureMaxTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.TemperatureMaxTimeSerialized);
            }
        }
    }
}
