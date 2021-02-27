using eBooks.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBooks.Mobile.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPageMaster : ContentPage
    {
        public ListView ListView;

        public MyPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        protected override void OnAppearing()
        {
            NaslovImePrezimeLabel.Text = Global.prijavljeniKupac.Ime + " " + Global.prijavljeniKupac.Prezime;
            NaslovEmailLabel.Text = Global.prijavljeniKupac.Email;

            base.OnAppearing();
        }


        class MyPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyPageMenuItem> MenuItems { get; set; }

            public MyPageMasterViewModel()
            {

                MenuItems = new ObservableCollection<MyPageMenuItem>(new[]
                {
                    new MyPageMenuItem { Title = "Pretraga knjiga", ImageSource="knjiga.png", TargetType=typeof(TabbedPageKnjige) },
                    new MyPageMenuItem { Title = "Aktivna narudžba", ImageSource="order.png", TargetType=typeof(NarudzbaPage) },
                    new MyPageMenuItem { Title = "Edituj profil", ImageSource="user.png", TargetType=typeof(EditUserPage) },
                    new MyPageMenuItem { Title = "Odjavi se", ImageSource="logout.png", TargetType=typeof(OdjavaPage) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}