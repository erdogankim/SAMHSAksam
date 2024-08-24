// See https://aka.ms/new-console-template for more information
using Gun14_2_AbstractOrnek;

Category c = new Category();
c.CategoryName = "";
c.CategoryID = -1;

CategoryValidator cv = new CategoryValidator(c);

if (!cv.IsValid)
{
	Console.WriteLine(cv.ValidationMessage); 
}

