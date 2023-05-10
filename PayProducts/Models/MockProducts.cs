using System.Collections.Generic;
using System.Linq;

namespace PayProducts.Models
{
    public class MockProducts : IProducts
    {
        private List<Products> products = null;
        
        public MockProducts()
        {
            products = new List<Products>()
            {
                new Products(){ProductId=1, Name="Smartfon",PayTime="3-9",Protsent=3},
                new Products(){ProductId=2, Name="Komputer",PayTime="3-12",Protsent=4},
                new Products(){ProductId=3, Name="Televizor",PayTime="3-18",Protsent =5}
            };
        }
        public Products Get(int id)
        {
            return products.FirstOrDefault(produc => produc.ProductId.Equals(id));
        }

        public IEnumerable<Products> GetAll()
        {
            return products;
        }

       public Products SentProductInfo(int payproduc)
       {
           Products produc=null;

              foreach (var item in products)
              {
                  if(item.Name=="Smartfon" && item.PayTime=="3-9")
                  {
                   item.PayMany=(((item.Protsent/100)*1000)+payproduc);
                  }
                 if(item.Name=="Komputer" && item.PayTime=="3-12")
                  {
                  item.PayMany=(((item.Protsent/100)*1000)+payproduc);
                  }
                   if(item.Name=="Televizor" && item.PayTime=="3-18")
                  {
                  item.PayMany=(((item.Protsent/100)*1000)+payproduc);
                  }
                  else
                  {
                    item.PayMany=(((6/100)*1000)+payproduc);
                  }
                  produc = item;
              }
         return produc;
       }
    }
}
