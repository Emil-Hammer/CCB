using System;
using CCB.Data.Domain;
using CCB.ViewModels.Base;

namespace CCB.ViewModels.Data
{
    public class StaffDataViewModel : DataViewModelAppBase<Staff>
    {
        public StaffDataViewModel(Staff obj) : base(obj, "Staff")
        {
        }

        public string Name
        {
            get => DataObject.Name.TrimEnd(' ');
            set
            {
                DataObject.Name = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get => DataObject.Address.TrimEnd(' ');
            set
            {
                DataObject.Address = value;
                OnPropertyChanged();
            }
        }

        public string Position
        {
            get => DataObject.Position.TrimEnd(' ');
            set
            {
                DataObject.Position = value;
                OnPropertyChanged();
            }
        }

        public string Telephone
        {
            get => DataObject.Telephone.TrimEnd(' ');
            set
            {
                DataObject.Telephone = value;
                OnPropertyChanged();
            }
        }

        public DateTimeOffset Employed
        {
            get => DataObject.EmployedSince;
            set
            {
                DataObject.EmployedSince = value.Date;
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

        public override string ContentText => Telephone;
    }
}