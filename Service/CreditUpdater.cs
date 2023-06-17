using Domain.Interface;

namespace Service
{
    public class CreditUpdater : ICreditUpdater
    {
        IUserRequest _userRequest;
        IDbHelper _dbHelper;
        public CreditUpdater(IUserRequest userRequest, IDbHelper dbHelper)
        {
            _userRequest = userRequest;
            _dbHelper = dbHelper;
        }

        public decimal CreditDeductor(string username, decimal amount)
        {
            var account = _userRequest.FindUser(username);

            var newCredit = account.Credit - amount;

            UpdateCredit(account.Id, newCredit);

            return newCredit;

        }

        public decimal CreditIncreaser(string username, decimal amount)
        {
            var account = _userRequest.FindUser(username);

            var newCredit = account.Credit + amount;

            UpdateCredit(account.Id, newCredit);

            return newCredit;

        }
        private void UpdateCredit(int id, decimal newCredit)
        {
            string query = $"Update UserInfo Set Credit ='{newCredit}' Where Id='{id}'";

            _dbHelper.ExecuteNonQuery(query);

        }
    }
}
