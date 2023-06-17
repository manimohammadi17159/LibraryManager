using DataAccess;
using Domain.Interface;
using Domain.Model;
using Service;

namespace UI.ExtenstionMethod
{
    internal static class FormManager
    {
        static IDbHelper _dbHelper = new DbHelper();
        static IBookRequest _bookRequest = new BookRequest(_dbHelper);
        static IBookManager _bookManager = new BookManager(_bookRequest);
        static IUserRequest _userRequest = new UserRequest(_dbHelper);
        static IUserManager _userManager = new UserManager(_userRequest);
        static IUserBookRequest _userBookRequest = new UserBookRequest(_dbHelper);
        static IUserBookManager _userBookManager = new UserBookManager(_userBookRequest);
        static ICreditUpdater _creditUpdater = new CreditUpdater(_userRequest, _dbHelper);
        static IBookIndex _bookIndex = new BookIndex(_userBookRequest);
        static ISignUp _signUp = new SignUp(_userRequest);
        static ILogin _login = new Login(_userRequest);
        static User _user;
        static public Form Open(this Form caller, string form, User user = null)// switchesh kon
        {
            Form result = new();
            _user = user;

            switch (form.ToLower())
            {
                case "login":
                     LoginPage loginPage = new(_login);
                     loginPage.Visible = true;
                    
                     caller.Hide();
                     result = loginPage;
                    break;

                case "sign up":
                    SignUpPage signUp = new(_signUp);
                    signUp.Visible = true;

                    caller.Hide();

                    result = signUp;
                    break;

                case "book shop":
                    BookShop bookShop = new(_bookManager, _creditUpdater, _userBookManager, _user);
                    bookShop.Visible = true;

                    caller.Hide();

                    result = bookShop;
                    break;

                case "charge credit":
                    ChargeCredit chargeCredit = new(_creditUpdater, _user);
                    chargeCredit.Visible = true;

                    caller.Hide();

                    result = chargeCredit;
                    break;

                case "insert book":
                    InsertNewBook insertNewBook = new(_bookManager);
                    insertNewBook.Visible = true;

                    caller.Hide();
                    result = insertNewBook;
                    break;

                case "profile":
                    Profile profile = new(_userBookRequest, _user);
                    profile.Visible = true;

                    caller.Hide();
                    result = profile;
                    break;

                case "admin panel":
                    AdminPanel adminPanel = new(_userManager, _bookIndex);
                    adminPanel.Visible = true;

                    caller.Hide();
                    result = adminPanel;
                    break;

                default:
                    break;
            }

            return result;
        }

        public static void BackToMain(this Form form) 
        {
            BookShop bookShop = new(_bookManager, _creditUpdater, _userBookManager, _user);
            form.Visible = false;

            bookShop.Visible = true;       
        }

    }
}
