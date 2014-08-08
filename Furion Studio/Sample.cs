using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Furion_Studio {
    public class Sample {
        [DllImport("user32.dll")]
        private static extern void Beep(int freq, int dur);

        public int Frequency { get; set; }
        public int Duration { get; set; }

        public Sample() { }
        public Sample(int freq, int dur) {
            Frequency = freq;
            Duration = dur;
        }

        public void Play() {
            Beep(Frequency, Duration);
        }
    }
}
