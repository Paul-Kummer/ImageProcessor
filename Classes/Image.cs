using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Classes
{
    public class Image
    {
        public Image()
        {

        }

        private System.IO.FileInfo _imageInfo;
        private String _originalNameWithExt;
        private String _currentNameWithExt;
        private String _newNameWithExt;
        private String _originalPathNoFile;
        private String _currentPathNoFile;
        private String _newpathNoFile;

        public System.IO.FileInfo ImageInfo 
        {
            get { return _imageInfo; }
            set { _imageInfo = value; } 
        }
        public String OriginalName 
        {
            get { return _originalNameWithExt; }
            set { _originalNameWithExt = value; }
        }
        public String CurrentName 
        {
            get { return _currentNameWithExt; }
            set { _currentNameWithExt = value; }
        }
        public String OriginalPath 
        {
            get { return _originalPathNoFile; }
            set { _originalPathNoFile = value; } 
        }
        public String CurrentPath 
        { 
            get { return _currentPathNoFile; }
            set { _currentPathNoFile = value; } 
        }
    }

    //Image Mover function
}
