using System;
using System.Windows.Input;
using Windows.UI.Popups;
using CCB.Data.Domain;
using CCB.ViewModels.Base;
using Commands.Implementation;

namespace CCB.ViewModels.Data
{
    public class InventoryDataViewModel : DataViewModelAppBase<Item>
    {
        public InventoryDataViewModel(Item obj) : base(obj, "Item")
        {
        }

        // Buttons for changing the amount
        public ICommand AmountUpCommand => new RelayCommand((AmountUpCommandMethod));
        public ICommand AmountDownCommand => new RelayCommand((AmountDownCommandMethod));
        public ICommand AllocatedUpCommand => new RelayCommand((AllocatedUpCommandMethod));
        public ICommand AllocatedDownCommand => new RelayCommand((AllocatedDownCommandMethod));

        public void AmountUpCommandMethod()
        {
            Amount++;
            OnPropertyChanged("AmountAvailable");
        }

        public async void AllocatedUpCommandMethod()
        {
            if (AmountAllocated < Amount)
            {
                AmountAllocated++;
                OnPropertyChanged("AmountAvailable");
            }
            else
            {
                var dialog = new MessageDialog("Reserveret kan ikke være højere end antal. Sæt antal op.");
                await dialog.ShowAsync();
            }
        }

        public async void AllocatedDownCommandMethod()
        {
            if (AmountAllocated > 0)
            {
                AmountAllocated--;
                OnPropertyChanged();
                OnPropertyChanged("AmountAvailable");

            }
            else
            {
                var dialog = new MessageDialog("Reserveret kan ikke være lavere end 0.");
                await dialog.ShowAsync();
            }
        }


        public async void AmountDownCommandMethod()
        {
            if (Amount > 0)
            {
                if ((Amount > AmountAllocated))
                {
                    Amount--;
                    OnPropertyChanged();
                    OnPropertyChanged("AmountAvailable");
                }
                else
                {
                    var dialog = new MessageDialog("Antal skal være højere end reserveret. Sæt reserveret ned!");
                    await dialog.ShowAsync();
                }
            }
            else
            {
                var dialog = new MessageDialog("Antal kan ikke være lavere end 0.");
                await dialog.ShowAsync();
            }
        }
        //

        public string Name
        {
            get => DataObject.Name.TrimEnd(' ');
            set
            {
                DataObject.Name = value;
                OnPropertyChanged();
            }
        }

        public int AmountAllocated
        {
            get => DataObject.AmountAllocated;
            set
            {
                DataObject.AmountAllocated = value;
                OnPropertyChanged();
            }
        }

        public int AmountAvailable => Amount - AmountAllocated;

        public int Amount
        {
            get => DataObject.AmountAvailable;
            set
            {
                DataObject.AmountAvailable = value;
                OnPropertyChanged();
            }
        }

        public override int ImageKey // Skal fjernes (ved ikke lige hvordan da den addon den bruger kræver det)
        {
            get => DataObject.Key;
            set
            {
                DataObject.Key = value;
                OnPropertyChanged();
            }
        }

        public override string HeaderText => Name;

        public override string ContentText => "Tilgængeligt: " + AmountAvailable.ToString();
    }
}