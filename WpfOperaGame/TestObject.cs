using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOperaGame
{
    
    class TestObject : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set {
                if (name == value) return;
                name = value;
                OnPropertyChanged("Name");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
