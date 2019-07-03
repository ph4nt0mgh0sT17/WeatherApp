using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.API
{
    public class Maximum : INotifyPropertyChanged
    {
        private double value;
        private string unit;
        public double Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
                NotifyPropertyChanged();
            }
        }
        public string Unit
        {
            get
            {
                return unit;
            }

            set
            {
                this.unit = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
