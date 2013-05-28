using System.Runtime.Serialization;

namespace ForecastIO
{
    [DataContract]
    public class Forecast
    {
        [DataMember(Name = "latitude")]
        public string Latitude { get; set; }

        [DataMember(Name = "longitude")]
        public string Longitude { get; set; }

        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }

        [DataMember(Name = "offset")]
        public int Offset { get; set; }

        [DataMember(Name = "currently")]
        public DataPoint Currently { get; set; }

        [DataMember(Name = "minutely")]
        public DataBlock Minutely { get; set; }

        [DataMember(Name = "hourly")]
        public DataBlock Hourly { get; set; }

        [DataMember(Name = "daily")]
        public DataBlock Daily { get; set; }

        [DataMember(Name = "alerts")]
        public Alert[] Alerts { get; set; }

        [DataMember(Name = "flags")]
        public Flags Flags { get; set; }
    }
}
