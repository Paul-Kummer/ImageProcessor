using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Classes
{
    public class Tray
    {
        public Tray(int cavitiesWide = 9, int cavitiesHigh = 3)
        {
            CavitiesWide = cavitiesWide;
            CavitiesHigh = cavitiesHigh;
            Parts = new Part[cavitiesWide, cavitiesHigh];
            TrayComplete = false;
            Completiondate = DateTime.MinValue;
            NumOfParts = cavitiesHigh * cavitiesWide;
            LastTouchedPart = new Part() {};
        }

        public int CavitiesWide { get; set; }
        public int CavitiesHigh { get; set; }
        public Part[,] Parts { get; set; }
        public bool TrayComplete { get; set; }
        public DateTime Completiondate { get; set; }
        public int NumOfParts { get; set; }
        public Part LastTouchedPart { get; set; }
    }
}
