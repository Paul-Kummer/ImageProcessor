using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Classes
{
    public class Part
    {
        public Part()
        {

        }

        private DateTime _bornDate;
        private int _partNum;
        private int _trayNum;
        private int _trayXPos;
        private int _trayYPos;
        private Image[] _images;
        private bool _isReject;
        private bool _isSelected;
        private bool _taskComplete;
        private String inspectedBy;
    }
}
