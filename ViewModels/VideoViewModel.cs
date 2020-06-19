using Book.Data;
using Book.Models;

namespace Book.ViewModels
{
    public class VideoViewModel : BaseViewModel<Video, VideoData>
    {
       
        public VideoViewModel()
        {
            Data = new VideoData();
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
