using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Data_Binding
{
    public class BookModel : INotifyPropertyChanged
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
