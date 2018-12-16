using AddOns.Images.Implementation;
using AddOns.Images.Interfaces;
using CCB.ViewModels.App;
using Extensions.AddOns.Implementation;
using Extensions.ViewModel.Implementation;

namespace CCB.ViewModels.Base
{
    public abstract class DataViewModelAppBase<TViewData> : DataViewModelWithSelectableImage<TViewData>
        where TViewData : class
    {

        protected DataViewModelAppBase(TViewData obj, string tag) : base(obj, tag)
        {
        }

        public virtual string HeaderText => "Override HeaderText...";

        public virtual string ContentText => "Override ContentText...";
    }
}