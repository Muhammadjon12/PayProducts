using System.Collections.Generic;

namespace PayProducts.Models
{
    public interface IProducts
    {
        Products Get(int id);

        IEnumerable<Products> GetAll();

        Products SentProductInfo(int payProduc);
    }
}
