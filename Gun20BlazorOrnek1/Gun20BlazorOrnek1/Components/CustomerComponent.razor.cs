
namespace Gun20BlazorOrnek1.Components
{
    public partial class CustomerComponent
    {
        Customer[]? customers;

        protected async override Task OnInitializedAsync()
        {

            customers = new Customer[] {
                new Customer(){CompanyName = "Abc", CustomerId = 1, Phone="11111"},
                new Customer(){CompanyName = "Def", CustomerId = 1, Phone="11111"},
                new Customer(){CompanyName = "uea", CustomerId = 1, Phone="11111"},
                new Customer(){CompanyName = "eat", CustomerId = 1, Phone="11111"},
                new Customer(){CompanyName = "aüt", CustomerId = 1, Phone="11111"},
                new Customer(){CompanyName = "ğıod", CustomerId = 1, Phone="11111"},
                new Customer(){CompanyName = "orn", CustomerId = 1, Phone="11111"},
                new Customer(){CompanyName = "fgğ", CustomerId = 1, Phone="11111"},
                new Customer(){CompanyName = "sb.", CustomerId = 1, Phone="11111"},
                new Customer(){CompanyName = "qhp", CustomerId = 1, Phone="11111"},
            };
            
        }


        public class Customer
        {
            public int CustomerId { get; set; }
            public string CompanyName { get; set; }
            public string Phone { get; set; }
        }

    }
}
