using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace eBooks.Mobile.Views
{
    class TabbedPageKnjige : Xamarin.Forms.TabbedPage
    {
        public TabbedPageKnjige()
        {
            On<Xamarin.Forms.PlatformConfiguration.Windows>().SetHeaderIconsEnabled(true);
            On<Xamarin.Forms.PlatformConfiguration.Windows>().SetHeaderIconsSize(new Size(24, 24));

            this.Title = "Odaberite knjigu";

            this.Children.Add(new KnjigePage() { Title = "Knjige", Icon = "knjiga.png" });

            this.Children.Add(new FreeKnjigePage() { Title = "Besplatne knjige", Icon = "knjige.png" });

            this.Children.Add(new PreporuceneKnjige() { Title = "Preporučene knjige", Icon = "recommend.png" });
        }
    }
}