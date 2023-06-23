using DataAccess;
using Domain.Interface;
using Domain.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using Service;


namespace UI.ExtenstionMethod
{
    internal static class FormManager
    {
        static ServiceProvider _serviceProvider;
        public static void SetService(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public static Form Open(this Form caller, string form, Domain.Model.User user = null)
        {


            Form result = new();

            switch (form.ToLower())
            {

                case "login":
                    LoginPage loginPage = _serviceProvider.GetRequiredService<LoginPage>();
                    loginPage.Visible = true;


                    caller.Hide();
                    result = loginPage;
                    break;

                case "sign up":
                    SignUpPage signUp = _serviceProvider.GetRequiredService<SignUpPage>();
                    signUp.Visible = true;

                    caller.Hide();

                    result = signUp;
                    break;

                case "book shop":
                    BookShop bookShop = _serviceProvider.GetRequiredService<BookShop>();
                    bookShop.SetUserInfo(user);
                    bookShop.Visible = true;

                    caller.Hide();

                    result = bookShop;
                    break;

                case "charge credit":
                    ChargeCredit chargeCredit = _serviceProvider.GetRequiredService<ChargeCredit>();
                    chargeCredit.SetUserInfo(user);
                    chargeCredit.Visible = true;

                    caller.Hide();

                    result = chargeCredit;
                    break;

                case "insert book":
                    InsertNewBook insertNewBook = _serviceProvider.GetRequiredService<InsertNewBook>();
                    insertNewBook.Visible = true;

                    caller.Hide();
                    result = insertNewBook;
                    break;

                case "profile":
                    Profile profile = _serviceProvider.GetRequiredService<Profile>();
                    profile.SetUserInfo(user);
                    profile.Visible = true;


                    caller.Hide();
                    result = profile;
                    break;

                case "admin panel":
                    AdminPanel adminPanel = _serviceProvider.GetRequiredService<AdminPanel>();
                    adminPanel.Visible = true;


                    caller.Hide();
                    result = adminPanel;
                    break;

                default:
                    break;
            }

            return result;
        }

    }
}
