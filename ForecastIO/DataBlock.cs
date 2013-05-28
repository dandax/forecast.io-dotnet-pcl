using System.Runtime.Serialization;

namespace ForecastIO
{
    [DataContract]
    public class DataBlock
    {
        [DataMember(Name = "summary")]
        public string Summary { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "data")]
        public DataPoint[] Data { get; set; }
    }
}
