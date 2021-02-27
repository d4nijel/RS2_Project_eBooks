using eBooks.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Mobile.Util
{
    public static class CartService
    {
        public static Dictionary<int, KnjigeDetailViewModel> Cart { get; set; } = new Dictionary<int, KnjigeDetailViewModel>();
    }
}
