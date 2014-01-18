using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Xna.Framework.Media;

namespace SimpleMusicPlayer.Views
{
  public partial class ArtistView : PhoneApplicationPage
  {
    private MediaLibrary _mediaLibrary;

    public ArtistView()
    {
      InitializeComponent();
      ArtistSelector.ItemsSource = GetArtists();
    }

    private List<Artist> GetArtists()
    {
      _mediaLibrary = new MediaLibrary();
      return _mediaLibrary.Artists.ToList();
    }

    private void AristListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      var artist = e.AddedItems[0].ToString();
      var songViewBrowserUri = new Uri(string.Format("/Views/SongView.xaml?artist={0}",artist), UriKind.Relative);
      NavigationService.Navigate(songViewBrowserUri);
    }
  }
}