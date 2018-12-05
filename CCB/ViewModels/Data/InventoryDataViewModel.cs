using System;
using CCB.Data.Domain;
using CCB.ViewModels.Base;

namespace CCB.ViewModels.Data
{
    public class InventoryDataViewModel : DataViewModelAppBase<Item>
    {
        public InventoryDataViewModel(Item obj) : base(obj, "Item")
        {
        }

        public string Name
        {
            get { return DataObject.Name.TrimEnd(' '); }
            set
            {
                DataObject.Name = value;
                OnPropertyChanged();
            }
        }

        public int AmountAllocated
        {
            get { return DataObject.AmountAllocated; }
            set
            {
                DataObject.AmountAllocated = value;
                OnPropertyChanged();
            }
        }

        public int AmountAvailable
        {
            get { return DataObject.AmountAvailable; }
            set
            {
                DataObject.AmountAvailable = value;
                OnPropertyChanged();
            }
        }

        public override int ImageKey // Skal fjernes (ved ikke lige hvordan da den addon den bruger kræver det)
        {
            get { return DataObject.Key; }
            set
            {
                DataObject.Key = value;
                OnPropertyChanged();
            }
        }

        public override string HeaderText
        {
            get
            {
                if (Name == null || !Name.Contains(" "))
                {
                    return Name;
                }
                else
                {
                    int index = Name.IndexOf(" ", StringComparison.Ordinal);
                    var shortName = Name.Substring(0, index + 1);
                    if (Name.Length > index + 1)
                    {
                        shortName += Name.Substring(index + 1, 1) + ".";
                    }
                    return shortName;
                }
            }
        }

        public override string ContentText
        {
            get { return Name; }
        }
    }
}