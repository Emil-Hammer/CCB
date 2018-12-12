using System;
using CCB.Data.Domain;
using CCB.ViewModels.Base;

namespace CCB.ViewModels.Data
{
    public class FrontDataViewModel : DataViewModelAppBase<Logbook>
    {
        public FrontDataViewModel(Logbook obj) : base(obj, "Item")
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
        public string Action
        {
            get { return DataObject.Action; }
            set
            {
                DataObject.Action = value;
                OnPropertyChanged();
            }
        }
        public string Type
        {
            get { return DataObject.Type; }
            set
            {
                DataObject.Type = value;
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