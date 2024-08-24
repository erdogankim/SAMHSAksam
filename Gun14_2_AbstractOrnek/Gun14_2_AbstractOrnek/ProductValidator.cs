using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun14_2_AbstractOrnek
{
    public sealed class ProductValidator : BaseValidator
    {
        public ProductValidator(object model) : base(model)
        {
        }

        protected override string Validate()
        {
            Product p = (Product)_model;
            if (p == null)
            {
                return "Product nesnesi boş olamaz";
            }

            if (p.ProductID <= 1)
            {
                return "ProductID 1den küçük veya eşit olamaz";
            }

            if (p.ProductName.Length < 5)
            {
                return "ProductName 5  karakterden az olamaz";
            }

            return "";
        }
    }
}
