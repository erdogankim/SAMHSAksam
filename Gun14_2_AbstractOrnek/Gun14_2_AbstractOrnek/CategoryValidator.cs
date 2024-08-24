using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun14_2_AbstractOrnek
{
    public class CategoryValidator : BaseValidator
    {
        public CategoryValidator(object model) : base(model)
        {
        }

        protected override string Validate()
        {
            Category c = (Category)_model;
            if (c == null)
            {
                return "Category nesnesi boş olamaz";
            }

            if (c.CategoryID <= 0)
            {
                return "CategoryId sıfırdan küçük veya eşit olamaz";
            }

            if (c.CategoryName.Length < 2)
            {
                return "CategoryName iki karakterden az olamaz";
            }

            return "";

        }
    }
}
