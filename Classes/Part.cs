using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Classes
{
    class Part
    {
        public Part()
        {

        }

        DateTime _bornDate;
        int _partNum;
        int _trayNum;
        int _trayXPos;
        int _trayYPos;
        Image[] _images;
        bool _isReject;
        bool _taskComplete;
        String inspectedBy;
    }
}
