using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }
        public int SundayID { get; set; }
        public String Name { get; set; }

        public Sunday Sunday { get; set; }
    }
}
