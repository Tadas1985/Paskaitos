using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TV_Show
    {
       
        public TV_Show()
        { 
        }

        public TV_Show(Guid iD, int duration, string title, string description, DateTime startTime)
        {
            ID = iD;
            Duration = duration;
            Title = title;
            Description = description;
            StartTime = startTime;
        }

        public Guid ID { get; set; }
        public int Duration { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }

    }
}
