using System.Collections.ObjectModel;

namespace Shit_Spotify.Models
{
    public class MainWindowModel
    {
        private ObservableCollection<Item> Songs { get; set; }

        private class Item
        {
        }
    }
}
