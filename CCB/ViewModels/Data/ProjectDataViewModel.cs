using System;
using CCB.Data.Domain;
using CCB.ViewModels.Base;

namespace CCB.ViewModels.Data
{
    public class ProjectDataViewModel : DataViewModelAppBase<Project>
    {
        public ProjectDataViewModel(Project obj) : base(obj, "Staff")
        {
        }

        public string Address
        {
            get { return DataObject.Address.TrimEnd(' '); }
            set
            {
                DataObject.Address = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return DataObject.Description.TrimEnd(' '); }
            set
            {
                DataObject.Description = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return DataObject.Telephone.TrimEnd(' '); }
            set
            {
                DataObject.Telephone = value;
                OnPropertyChanged();
            }
        }

        public DateTimeOffset? Deadline
        {
            get { return DataObject.Deadline; }
            set
            {
                DataObject.Deadline = value;
                OnPropertyChanged();
            }
        }

        public DateTimeOffset Start
        {
            get { return DataObject.Start; }
            set
            {
                DataObject.Start = value;
                OnPropertyChanged();
            }
        }

        public bool IsFinished
        {
            get { return DataObject.IsFinished; }
            set
            {
                DataObject.IsFinished = value;
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


        public override string ContentText
        {
            get { return Convert.ToString(Start.DateTime.ToShortDateString()); ; }
        }

        public override string HeaderText
        {
            get { return Address; }
        }
    }
}