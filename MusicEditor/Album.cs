using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KursovayaRabota
{
    public class Album
    {
        [JsonInclude]
        public List<Track> tracks;
        public string Name { get; set; } = "no name";
        public Album(string name)
        {
            this.Name = name;
            tracks = new List<Track>();
        }
        public string getDurationTracks()
        {
            TimeSpan sumTime = TimeSpan.Zero;

            foreach (var b in tracks)
            {
                sumTime += TimeSpan.Parse(b.DurationStr);
            }
            return Convert.ToString(sumTime);
        }
    }
}
