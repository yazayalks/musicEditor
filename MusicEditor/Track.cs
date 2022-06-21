using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KursovayaRabota
{
    public class Track
    {

        private string durationStr = "no time";
        public string NameTrack { get; set; } = "no name";
        public string NameGroup { get; set; } = "no name";
        public string NamePerformer { get; set; } = "no name";
        public string DurationStr
        {
            set
            {

                if (TimeSpan.Parse(value) > TimeSpan.Zero)
                {
                    durationStr = value;
                }
                else
                {
                    throw new ArgumentException("Время трека не может быть меньше или равна нулю");
                }
            }
            get
            {
                return durationStr;
            }
        }
        public Track(string nameTrack, string nameGroup, string namePerformer, string durationStr)
        {
            this.NameTrack = nameTrack;
            this.NameGroup = nameGroup;
            this.NamePerformer = namePerformer;
            this.DurationStr = durationStr;
        }

    }
}
