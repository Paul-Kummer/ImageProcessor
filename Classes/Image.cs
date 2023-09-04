using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Classes
{
    class Image
    {
        public Image()
        {

        }

        System.IO.FileInfo _imageInfo;
        String _originalNameWithExt;
        String _currentNameWithExt;
        String _newNameWithExt;
        String _originalPathNoFile;
        String _currentPathNoFile;
        String _newpathNoFile;

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
