using DataAccess;
using Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using Service;


namespace UI.ExtenstionMethod
{
    internal static class RegisterDependency
    {
        public static ServiceProvider Register()
        {
            ServiceCollection servicecollection = new ServiceCollection();

            servicecollection.AddSingleton<IDbHelper, DbHelper>();

            servicecollection.AddScoped<IBookRequest, BookRequest>();
            servicecollection.AddScoped<IBookManager, BookManager>();
            servicecollection.AddScoped<IUserManager, UserManager>();
            servicecollection.AddScoped<IUserRequest, UserRequest>();
            servicecollection.AddScoped<IUserBookRequest, UserBookRequest>();
            servicecollection.AddScoped<IUserBookManager, UserBookManager>();
            servicecollection.AddScoped<ICreditUpdater, CreditUpdater>();
            servicecollection.AddScoped<IBookIndex, BookIndex>();
            servicecollection.AddScoped<ISignUp, SignUp>();
            servicecollection.AddScoped<ILogin, Login>();

            //Register form as service
            //Because we need open the form in FORMMANAGER class
            servicecollection.AddScoped<LoginPage>();
            servicecollection.AddScoped<SignUpPage>();
            servicecollection.AddScoped<BookInfo>();
            servicecollection.AddScoped<InsertNewBook>();

            servicecollection.AddTransient<ChargeCredit>();
            servicecollection.AddTransient<Profile>();
            servicecollection.AddTransient<BookShop>();
            servicecollection.AddTransient<AdminPanel>();

            return servicecollection.BuildServiceProvider();        

        }


    }
}
