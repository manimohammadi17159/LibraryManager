using Domain.Interface;

namespace Service
{
    public class BookIndex : IBookIndex
    {
        IUserBookRequest _userBookRequest;
        public BookIndex(IUserBookRequest userBookRequest)
        {
            _userBookRequest = userBookRequest;
        }

        public decimal GetTotalSales()
        {
            decimal result = _userBookRequest.TotalSales();
            return result;
        }
        public int GetTotalBookSold()
        {
            int result = _userBookRequest.TotalBookSold();

            return result;
        }
        public int GetBookCount()
        {
            int result = _userBookRequest.BookCount();
            return result;
        }


    }
}
