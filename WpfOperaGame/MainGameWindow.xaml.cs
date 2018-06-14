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
using System.Windows.Shapes;

namespace WpfOperaGame
{
    /// <summary>
    /// Interaction logic for MainGameWindow.xaml
    /// </summary>
    public partial class MainGameWindow : Window, INotifyPropertyChanged
    {
        public MainGameWindow()
        {
            InitializeComponent();
        }

        TestObject t = new TestObject();
        private DateTime _gameDate = DateTime.Now;
        public DateTime gameDate
        {
            get
            {
                return _gameDate;
            }

            set
            {
                _gameDate = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }


        

        


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PopulateFields();
        }

        private void PopulateFields()
        {
             t.Name = "Initial Name";
//            theLabel.DataContext = t;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            t.Name = "foo";
            gameDate = gameDate.AddDays(45);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            t.Name = "bar";
        }



        
    }
}
