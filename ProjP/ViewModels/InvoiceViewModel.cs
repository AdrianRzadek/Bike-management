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
                var ObjClient = ObjInvoiceService.Search(CurrentInvoice.FakturaId);
                if (ObjClient != null)
                {
                    // CurrentEmployee.Name = ObjEmployee.Name;
                    //   CurrentEmployee.Age = ObjEmployee.Age;

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
                var IsUpdated = ObjInvoiceService.Update(CurrentInvoice);
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
                var IsDeleted = ObjInvoiceService.Delete(CurrentInvoice.FakturaId);
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
