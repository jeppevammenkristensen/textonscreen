using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Dirty.Annotations;

namespace Dirty
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _textToDisplay;
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string TextToDisplay
        {
            get { return _textToDisplay; }
            set
            {
               if (value == _textToDisplay) return;
                _textToDisplay = value;
                OnPropertyChanged();
            }
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Display disp = new Display();
            disp.DataContext = this.DataContext;
            disp.Show();
            disp.Topmost = true;
        }
    }
}
