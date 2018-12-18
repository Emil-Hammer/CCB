using System;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml.Media;
using CCB.Data.Domain;
using CCB.ViewModels.Base;

namespace CCB.ViewModels.Data
{
    public class ProjectDataViewModel : DataViewModelAppBase<Project>
    {
        //Enables the binding of the proceeding values to the Project object
        public ProjectDataViewModel(Project obj) : base(obj, "Project")
        {
        }

        public string Address
        {
            get => DataObject.Address.TrimEnd(' ');
            set
            {
                DataObject.Address = value;
                OnPropertyChanged();
                OnPropertyChanged("ExceededDeadline");
            }
        }

        public string Description
        {
            get => DataObject.Description.TrimEnd(' ');
            set
            {
                DataObject.Description = value;
                OnPropertyChanged();
                OnPropertyChanged("ExceededDeadline");
            }
        }

        public string Phone
        {
            get => DataObject.Telephone.TrimEnd(' ');
            set
            {
                DataObject.Telephone = value;
                OnPropertyChanged();
                OnPropertyChanged("ExceededDeadline");
            }
        }

        public DateTimeOffset? Deadline
        {
            get => DataObject.Deadline;
            set
            {
                DataObject.Deadline = value;
                OnPropertyChanged();
                OnPropertyChanged("ExceededDeadline");
            }
        }

        public DateTimeOffset Start
        {
            get => DataObject.Start;
            set
            {
                DataObject.Start = value;
                OnPropertyChanged();
                OnPropertyChanged("ExceededDeadline");
            }
        }

        public bool IsFinished
        {
            get => DataObject.IsFinished;
            set
            {
                DataObject.IsFinished = value;
                OnPropertyChanged();
                OnPropertyChanged("ExceededDeadline");
            }
        }

        //ProjectStatus, ColorToNumber and CompletionColor(Method) should be rewritten to keep code DRY.
        public string ProjectStatus
        {
            get
            {
                if (!IsFinished && Deadline.Value.Ticks < DateTime.Now.Ticks)
                {
                    return "Deadline overskredet!";
                }

                if (!IsFinished && Deadline.Value.Ticks > DateTime.Now.Ticks && Start.Ticks <= DateTime.Now.Ticks)
                {
                    return "Projekt i gang!";
                }

                if (IsFinished)
                {
                    return "Projekt færdiggjort!";
                }

                if (!IsFinished && Start.Ticks > DateTime.Now.Ticks)
                {
                    return "Projekt ikke startet endnu!";
                }

                return "";
            }
        }

        public int ColorToNumber
        {
            get
            {
                Color complColor = ((SolidColorBrush) CompletionColor).Color;
                if (complColor == Colors.Gainsboro)
                {
                    return 2;
                }

                if (complColor == Colors.DodgerBlue)
                {
                    return 1;
                }

                if (complColor == Colors.Red)
                {
                    return 0;
                }

                if (complColor == Colors.ForestGreen)
                {
                    return 3;
                }

                return 4;
            }
        }

        /// <summary>
        /// !!!UNUSED IN OUR PROJECT!!!
        /// </summary>
        public override int ImageKey // Skal fjernes (ved ikke lige hvordan da den addon den bruger kræver det)
        {
            get => DataObject.Key;
            set
            {
                DataObject.Key = value;
                OnPropertyChanged();
                OnPropertyChanged("ExceededDeadline");
            }
        }


        public override string ContentText => $"Startdato: {Convert.ToString(Start.DateTime.ToShortDateString())} \t \t Færdiggjort: {IsFinishedText()}";

        public string IsFinishedText()
        {
            if (IsFinished == true)
            {
                return "\u2713";
            }
            else
            {
                return "\u25A1";
            }
        }

        public Brush CompletionColor
        {
            get => CompletionColorMethod();
        }

        public Brush CompletionColorMethod()
        {
            if (IsFinished)
            {
                return new SolidColorBrush(Colors.ForestGreen);
            }
            else if (Deadline != null && (!IsFinished && Deadline.Value.Ticks < DateTime.Now.Ticks))
            {
                return new SolidColorBrush(Colors.Red);
                
            }
            else if (Start.Ticks < DateTime.Now.Ticks)
            {
                return new SolidColorBrush(Colors.DodgerBlue);
            }
            else
            {
                return new SolidColorBrush(Colors.Gainsboro);
            }
        }

        public override string HeaderText => Address;
    }
}