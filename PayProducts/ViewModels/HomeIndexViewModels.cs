using PayProducts.Models;
using System.Collections.Generic;

namespace PayProducts.ViewModels
{
    public class HomeIndexViewModels
    {
        public IEnumerable<Products> products { get; set; }

        public Products getproductsInfo { get; set; }  

        
    }
}
