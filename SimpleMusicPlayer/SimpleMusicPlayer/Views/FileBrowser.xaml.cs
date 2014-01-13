using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Xna.Framework.Media;

namespace SimpleMusicPlayer.Views
{
  public partial class FileBrowser : PhoneApplicationPage
  {
    private MediaLibrary mediaLibrary;

    public FileBrowser()
    {
      InitializeComponent();
      ArtistSelector.ItemsSource = GetArtists();
    }

    private List<Artist> GetArtists()
    {
      mediaLibrary = new MediaLibrary();
      return mediaLibrary.Artists.ToList();
    }

    private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      MessageBox.Show(string.Format("Clicked: {0}, Removed: {1}", e.AddedItems[0], e.RemovedItems[0]));
    }
  }
}