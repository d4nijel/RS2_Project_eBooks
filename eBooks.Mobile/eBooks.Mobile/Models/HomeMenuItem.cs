using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Knjige,
        Narudzba
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
