using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class BikeDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private int rowerid;
        public int RowerId
        {
            get { return rowerid; }
            set { rowerid = value; OnPropertyChanged("RowerId"); }
        }
        private string kolor;
        public string Kolor
        {
            get { return kolor; }
            set { kolor = value; OnPropertyChanged("Kolor"); }
        }
        private string rowertype;
        public string RowerType
        {
            get { return rowertype; }
            set { rowertype = value; OnPropertyChanged("RowerType"); }
        }

        private float rozmiarramy;
        public float RozmiarRamy
        {
            get { return rozmiarramy; }
            set { rozmiarramy = value; OnPropertyChanged("RozmiarRamy"); }
        }

        private float rozmiaropon;
        public float RozmiarOpon
        {
            get { return rozmiaropon; }
            set { rozmiaropon = value; OnPropertyChanged("RozmiarOpon"); }
        }


        private int biegi;
        public int Biegi { 
            get { return biegi; }
            set { biegi = value; OnPropertyChanged("Biegi"); }
        }


    }
}
