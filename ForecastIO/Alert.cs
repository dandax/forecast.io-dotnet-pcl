using System;
using System.Runtime.Serialization;

namespace ForecastIO
{
    public class Alert
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        public DateTime Expires { get; set; }

        [DataMember(Name = "expires")]
        private int ExpiresSerialized { get; set; }

        [DataMember(Name = "uri")]
        public Uri Uri { get; set; }

        [OnDeserialized]
        void OnDeserializing(StreamingContext context)
        {
            if (this.ExpiresSerialized != 0)
            {
                this.Expires = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(this.ExpiresSerialized);
            }
        }
    }
}
