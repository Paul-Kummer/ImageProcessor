using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Classes
{
    class Tray
    {
        public Tray()
        {

        }

        int _cavitysWide;
        int _cavitysHeigh;
        Part[][] _parts;
        bool _trayComplete;
        DateTime _competionDate;
        int _numOfParts;
        Part _lastTouchedPart;
    }
}
