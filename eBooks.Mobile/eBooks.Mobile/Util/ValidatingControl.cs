using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace eBooks.Mobile.Util
{
    public class ValidatingControl
    {
        public View Control { get; set; }
        public string Message { get; set; }
        public ValidatingControl(View control, string message)
        {
            Control = control;
            Message = message;
        }

        public bool ValidEmail(string emailAddress)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailAddress);

            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
