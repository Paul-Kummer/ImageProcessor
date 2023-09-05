using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using ImageProcessor.Classes;

namespace ImageProcessor.UserControls
{
    /// <summary>
    /// Interaction logic for SingularTray.xaml
    /// </summary>
    public partial class CavityUC : UserControl, INotifyPropertyChanged
    {
        public CavityUC()
        {
            InitializeComponent();
            DataContext = this;

            CurPart = new Part();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Classes.Part _curPart;

        public Classes.Part CurPart
        {
            get { return _curPart; }
            set
            {
                _curPart = value;
                NotifyPropertyChanged("CurPart");
            }
        }
    }
}
