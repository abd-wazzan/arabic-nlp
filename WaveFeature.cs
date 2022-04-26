using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabic_nlp
{
    public class WaveFeature
    {
        public int Id { get; set; }
        public WaveTypes Type { get; set; }
        public double RMS { get; set; }
        public double ZCR { get; set; }
        public double Energy { get; set; }
    }
}
