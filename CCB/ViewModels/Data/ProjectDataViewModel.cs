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
            get => DataObject.Address.TrimEnd(' ');
            set
            {
                DataObject.Address = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => DataObject.Description.TrimEnd(' ');
            set
            {
                DataObject.Description = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => DataObject.Telephone.TrimEnd(' ');
            set
            {
                DataObject.Telephone = value;
                OnPropertyChanged();
            }
        }

        public DateTimeOffset? Deadline
        {
            get => DataObject.Deadline;
            set
            {
                DataObject.Deadline = value;
                OnPropertyChanged();
            }
        }

        public DateTimeOffset Start
        {
            get => DataObject.Start;
            set
            {
                DataObject.Start = value;
                OnPropertyChanged();
            }
        }

        public bool IsFinished
        {
            get => DataObject.IsFinished;
            set
            {
                DataObject.IsFinished = value;
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


        public override string ContentText => Convert.ToString(Start.DateTime.ToShortDateString());

        public override string HeaderText => Address;
    }
}