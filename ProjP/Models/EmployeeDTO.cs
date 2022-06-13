using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class EmployeeDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertName));
        }
        private int pracownikid;
        public int PracownikId
        {
            get { return pracownikid; }
            set { pracownikid = value; OnPropertyChanged("PracownikId"); }
        }
        private string imiępracownik;
        public string ImięPracownik
        {
            get { return imiępracownik; }
            set { imiępracownik = value; OnPropertyChanged("ImięPracownik"); }
        }
        private string nazwiskopracownik;
        public string NazwiskoPracownik
        {
            get { return nazwiskopracownik; }
            set { nazwiskopracownik = value; OnPropertyChanged("NazwiskoPracownik"); }
        }

        private string pesel;
        public string Pesel
        {
            get { return pesel; }
            set { pesel = value; OnPropertyChanged("Pesel"); }
        }

        private string stanowisko;
        public string Stanowisko
        {
            get { return stanowisko; }
            set { stanowisko = value; OnPropertyChanged("Stanowisko"); }
        }



        private string nrtelefonu;
        public string NrTelefonu
        { 
            get { return nrtelefonu; }
            set { nrtelefonu = value; OnPropertyChanged("NrTelefonu"); }
        }


    }
}
