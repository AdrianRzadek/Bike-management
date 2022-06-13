using ProjP.Commands;
using ProjP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.ViewModels
{
    public class RentalViewModel : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged_Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        RentalService ObjRentalService;
        public RentalViewModel()
        {
            ObjRentalService = new RentalService();
            LoadData();
            CurrentRental = new RentalDTO();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);

        }


        #region DisplayOperation
        private ObservableCollection<RentalDTO> rentalsList;

        public ObservableCollection<RentalDTO> RentalsList
        {
            get { return rentalsList; }
            set { rentalsList = value; OnPropertyChanged("RentalsList"); }
        }

        private void LoadData()
        {
            RentalsList = new ObservableCollection<RentalDTO>(ObjRentalService.GetAll());
        }

        #endregion


        private RentalDTO currentRental;
        public RentalDTO CurrentRental
        {
            get { return currentRental; }
            set { currentRental = value; OnPropertyChanged("CurrentRental"); }

        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        #region SaveOperation
        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }
        public void Save()
        {
            try
            {
                var IsSaved = ObjRentalService.Add(CurrentRental);
                LoadData();
                if (IsSaved)
                    Message = "Pracownik zapisany";
                else
                    Message = "Pracownik nie zapisany błąd";
            }
            catch (Exception ex)
            {

            }
        }
        #endregion


        #region SearchOperation
        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get { return searchCommand; }

        }
        public void Search()
        {
            try
            {
                var ObjRental = ObjRentalService.Search(CurrentRental.WypożyczenieId);
                if (ObjRental != null)
                {
                    CurrentRental.DataWypożyczenia = ObjRental.DataWypożyczenia;
                    CurrentRental.DataOddania = ObjRental.DataOddania;
                    CurrentRental.Cena = ObjRental.Cena;
                    CurrentRental.FakturaId=ObjRental.FakturaId;
                    CurrentRental.PracownikId = ObjRental.PracownikId;


                }
                else
                {
                    Message = "Nie znaleziono";
                }
            }
            catch (Exception ex)
            {

            }
        }


        #endregion

        #region UpdateOperation
        private RelayCommand updateCommand;


        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }
        public void Update()
        {
            try
            {
                var IsUpdated = ObjRentalService.Update(CurrentRental);
                if (IsUpdated)
                {
                    Message = "Employee Update";
                    LoadData();
                }
                else
                {
                    Message = "Update Operation Failed";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion


        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }

        public void Delete()
        {
            try
            {
                var IsDeleted = ObjRentalService.Delete(CurrentRental.WypożyczenieId);
                if (IsDeleted)
                {
                    Message = "Pracownik usuniety";
                    LoadData();
                }
                else
                {
                    Message = "Błąd operacji";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
    }
}
