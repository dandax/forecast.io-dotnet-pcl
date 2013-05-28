using System.Runtime.Serialization;

namespace ForecastIO
{
    [DataContract]
    public class Flags
    {
        [DataMember(Name = "sources")]
        public string[] Sources { get; set; }

        [DataMember(Name = "darksky-unavailable")]
        public string[] DarkSkyUnavailable { get; set; }

        [DataMember(Name = "darksky-stations")]
        public string[] DarkSkyStations { get; set; }

        [DataMember(Name = "datapoint-stations")]
        public string[] DataPointStations { get; set; }

        [DataMember(Name = "isd-stations")]
        public string[] IsdStations { get; set; }

        [DataMember(Name = "lamp-stations")]
        public string[] LampStations { get; set; }

        [DataMember(Name = "metar-stations")]
        public string[] MetarStations { get; set; }

        [DataMember(Name = "metno-stations")]
        public string[] MetnoStations { get; set; }

        [DataMember(Name = "units")]
        public string Units { get; set; }
    }
}
