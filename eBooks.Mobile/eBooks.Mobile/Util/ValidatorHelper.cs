using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace eBooks.Mobile.Util
{
    public class ValidatorHelper
    {
        public static string Validacija(ValidatingControl[] controls, PageValidating pageToValidate)
        {
            var msg = "";

            foreach (var item in controls)
            {
                switch (pageToValidate)
                {
                    case PageValidating.Registracija:
                        if (item.Control is Entry entry1)
                        {
                            if (string.IsNullOrEmpty(entry1.Text))
                            {
                                if (entry1.ClassId == "email")
                                    msg += "Email ne smije biti prazan! \n";
                                else
                                    msg += item.Message + "\n";
                            }

                            if (!string.IsNullOrEmpty(entry1.Text) && entry1.ClassId == "email" && !item.ValidEmail(entry1.Text))
                                msg += item.Message + "\n";
                        }
                        break;
                    case PageValidating.EditUserPage:
                        if (item.Control is Entry entry2)
                        {
                            if (string.IsNullOrEmpty(entry2.Text))
                            {
                                if (entry2.ClassId == "email")
                                    msg += "Email ne smije biti prazan! \n";
                                else
                                    msg += item.Message + "\n";
                            }

                            if (!string.IsNullOrEmpty(entry2.Text) && entry2.ClassId == "email" && !item.ValidEmail(entry2.Text))
                                msg += item.Message + "\n";
                        }
                        break;
                    case PageValidating.EPlacanjePage:
                        if (item.Control is Entry entry3)
                        {
                            if (string.IsNullOrEmpty(entry3.Text))
                            {
                                msg += item.Message + "\n";
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            return msg;
        }
    }
}
