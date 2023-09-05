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
    /// Interaction logic for Tray.xaml
    /// </summary>
    public partial class TrayUC : UserControl, INotifyPropertyChanged
    {
        public TrayUC(Tray currentTray)
        {
            InitializeComponent();
            DataContext = this;

            CurrentTray = currentTray;
        }

        private Tray _currentTray;
        private StackPanel _cavityStack;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged( String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Tray CurrentTray
        {
            get 
            {
                return _currentTray;
            }
            set
            {
                _currentTray = value;
                NotifyPropertyChanged("CurrentTray");
            }
        }
        public StackPanel CavityStack
        {
            get { return _cavityStack; }
            set
            {
                _cavityStack = value;
                NotifyPropertyChanged("CavityStack");
            }
        }

        public void BuildTray()
        {
            CavityStack = new StackPanel();
            CavityStack.Orientation = Orientation.Vertical;

            Part curPart;
            CavityUC curCavity;
            StackPanel curRow;

            for(int rowIndex = 0; rowIndex < CurrentTray.Parts.GetLength(0); rowIndex++)
            {
                curRow = new StackPanel();
                
                for(int columnIndex = 0; columnIndex < CurrentTray.Parts.GetLength(1); columnIndex++)
                {
                    curCavity = new CavityUC();
                    curPart = CurrentTray.Parts[rowIndex, columnIndex];
                    curRow.Children.Add(curCavity);
                }

                CavityStack.Children.Add(curRow);
            }

            NotifyPropertyChanged("CavityStack");
        }
    }
}
