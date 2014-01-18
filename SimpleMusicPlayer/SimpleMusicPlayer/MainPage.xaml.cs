using System;
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
using SimpleMusicPlayer.Resources;

namespace SimpleMusicPlayer
{
  public partial class MainPage : PhoneApplicationPage
  {
    public MediaLibrary mediaLibary;
    
    // Constructor
    public MainPage()
    {
      InitializeComponent();
      
      BuildLocalizedApplicationBar();
    }


    // Sample code for building a localized ApplicationBar
    private void BuildLocalizedApplicationBar()
    {
      // Set the page's ApplicationBar to a new instance of ApplicationBar.
      ApplicationBar = new ApplicationBar();

      // Create a new button and set the text value to the localized string from AppResources.
      var appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
      appBarButton.Text = AppResources.AppBarButtonText;
      ApplicationBar.Buttons.Add(appBarButton);

      // Create a new menu item with the localized string from AppResources.
      var appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
      ApplicationBar.MenuItems.Add(appBarMenuItem);
    }

    private void ToMusicPlayerButton_Click(object sender, RoutedEventArgs e)
    {
      var musicPlayerViewUri = new Uri("/Views/MusicPlayerView.xaml", UriKind.Relative);
      NavigationService.Navigate(musicPlayerViewUri);
    }

    private void ToArtistViewButton_Click(object sender, RoutedEventArgs e)
    {
      var artistViewUri = new Uri("/Views/ArtistView.xaml", UriKind.Relative);
      NavigationService.Navigate(artistViewUri);
    }
  }
}