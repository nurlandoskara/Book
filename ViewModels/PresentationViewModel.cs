using Book.Data;
using Book.Models;

namespace Book.ViewModels
{
    public class PresentationViewModel : BaseViewModel<Presentation, PresentationData>
    {
       
        public PresentationViewModel()
        {
            Data = new PresentationData();
            Items = Data.GetItems();
        }

        public override void LoadDocument()
        {
            Title = SelectedItem.Title;
            Number = SelectedItem.Number;
            View.ItemLoad(SelectedItem.Path);
        }


    }

}
