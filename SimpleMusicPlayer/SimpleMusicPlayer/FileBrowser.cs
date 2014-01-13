using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Media;

namespace SimpleMusicPlayer
{
  class FileBrowser
  {
    private MediaLibrary mediaLibary;

    public FileBrowser()
    {
      var artists = GetArtists();
    }

    private List<Artist> GetArtists()
    {
      mediaLibary = new MediaLibrary();

      return mediaLibary.Artists.ToList();
    }
  }
}
