using ProjP.Commands;
using ProjP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjP.ViewModels
{
    public class InvoiceViewModel : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged_Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        InvoiceService ObjInvoiceService;
        public InvoiceViewModel()
        {
            ObjInvoiceService = new InvoiceService();
            LoadData();
            CurrentInvoice = new InvoiceDTO();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);

        }


        #region DisplayOperation
        private ObservableCollection<InvoiceDTO> invoicesList;

        public ObservableCollection<InvoiceDTO> InvoicesList
        {
            get { return invoicesList; }
            set { invoicesList = value; OnPropertyChanged("InvoicesList"); }
        }

        private void LoadData()
        {
            InvoicesList = new ObservableCollection<InvoiceDTO>(ObjInvoiceService.GetAll());
        }

        #endregion


        private InvoiceDTO currentInvoice;
        public InvoiceDTO CurrentInvoice
        {
            get { return currentInvoice; }
            set { currentInvoice = value; OnPropertyChanged("CurrentInvoice"); }

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
                var IsSaved = ObjInvoiceService.Add(CurrentInvoice);
                LoadData();
                if (IsSaved)
                {
                    MessageBox.Show("Dodano dane faktura", "Dodawanie", MessageBoxButton.OK, MessageBoxImage.Information);

                    Message = "Pracownik zapisany";
                }
                else
                {

                    MessageBox.Show("Nie dodano danych faktury", "Dodawanie", MessageBoxButton.OK, MessageBoxImage.Information);

                    Message = "Pracownik nie zapisany błąd";
                }
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
                var ObjInvoice = ObjInvoiceService.Search(CurrentInvoice.FakturaId);
                if (ObjInvoice != null)
                {
                    CurrentInvoice.NIP = ObjInvoice.NIP;
                    CurrentInvoice.Nazwa = ObjInvoice.Nazwa;
                    CurrentInvoice.DataWystawienia = ObjInvoice.DataWystawienia;


                    MessageBox.Show("Wyszukano fakturę", "Wyszukiwanie", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("Nie znaleźono faktury", "Wyszukiwanie", MessageBoxButton.OK, MessageBoxImage.Information);
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
                var IsUpdated = ObjInvoiceService.Update(CurrentInvoice);
                LoadData();
                if (IsUpdated)
                {
                  
                    
                    Message = "Employee Update";
                    MessageBox.Show("Uaktualniono dane faktury", "Uaktualnianie", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                }
                else
                {
                    MessageBox.Show("Nie uaktualniono danych faktury", "Uaktualnianie", MessageBoxButton.OK, MessageBoxImage.Information);
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
                var IsDeleted = ObjInvoiceService.Delete(CurrentInvoice.FakturaId);
                LoadData();
                if (IsDeleted)
                {
                    
                   
                    Message = "Pracownik usuniety";
                    MessageBox.Show("Usunięto dane faktury", "Usuwanie", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                }
                else
                {
                    MessageBox.Show("Nie usunięto danych faktury", "Usuwanie", MessageBoxButton.OK, MessageBoxImage.Information);
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
