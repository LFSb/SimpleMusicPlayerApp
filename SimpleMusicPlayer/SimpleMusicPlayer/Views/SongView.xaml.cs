using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Xna.Framework.Media;


namespace SimpleMusicPlayer.Views
{
  public partial class SongView : PhoneApplicationPage
  {
    private MediaLibrary _mediaLibrary;
    private Artist _artist;
    public SongView()
    {
      InitializeComponent();
      
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
      string newArtist;
      _mediaLibrary = new MediaLibrary();

      NavigationContext.QueryString.TryGetValue("artist", out newArtist);
      if (!string.IsNullOrEmpty(newArtist))
      {
        _artist = _mediaLibrary.Artists.FirstOrDefault(artist => artist.Name.ToLower().Equals(newArtist.ToLower()));
        if (_artist != null)
        {
          SongSelector.ItemsSource = GetSongs(_artist);
        }
      }
    }

    private List<Song> GetSongs(Artist artist)
    {
      _mediaLibrary = new MediaLibrary();
      return _mediaLibrary.Songs.Where(x => x.Artist == artist).ToList();
    }

    private void SongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      MessageBox.Show(string.Format("You clicked {0}!", e.AddedItems[0].ToString()));
    }
  }
}