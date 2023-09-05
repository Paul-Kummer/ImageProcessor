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
using ImageProcessor.UserControls;

namespace ImageProcessor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            TrayNumber = -1;
            TrayNumberStr = TrayNumber.ToString();
            CurrentTray = new Tray();
            CurrentTrayUC = new TrayUC(CurrentTray);
            CurrentTrayUC.BuildTray();
            IncrementCommand = new DelegateCommand(IncrementTray);
            DecrementCommand = new DelegateCommand(DecrementTray);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        int _trayNumber;
        string _trayNumberStr;
        Tray _currentTray;
        TrayUC _currentTrayUC;


        public int TrayNumber
        {
            get { return _trayNumber; }
            set
            {
                _trayNumber = value;
                NotifyPropertyChanged("TrayNumber");
                NotifyPropertyChanged("TrayNumberStr");
            }
        }
        public string TrayNumberStr
        { 
            get { return _trayNumberStr; } 
            set
            {
                TrayNumber = Convert.ToInt32(value);
                _trayNumberStr = value;
                NotifyPropertyChanged("TrayNumber");
                NotifyPropertyChanged("TrayNumberStr");
            }
        }
        public Tray CurrentTray
        {
            get { return _currentTray; }
            set
            {
                _currentTray = value;
                NotifyPropertyChanged("CurrentTray");
            }
        }
        public TrayUC CurrentTrayUC
        {
            get { return _currentTrayUC; }
            set
            {
                _currentTrayUC = value;
                NotifyPropertyChanged("CurrentTrayUC");
            }
        }
        public DelegateCommand IncrementCommand{ get; }
        public DelegateCommand DecrementCommand{ get ; }

        private void IncrementTray(object? obj)
        {
            TrayNumber++;
            NotifyPropertyChanged("TrayNumber");
            NotifyPropertyChanged("TrayNumberStr");
        }
        private void DecrementTray(object? obj)
        {
            TrayNumber--;
            NotifyPropertyChanged("TrayNumber");
            NotifyPropertyChanged("TrayNumberStr");
        }
    }
}
