namespace Assignment_22_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1)
            //Get all products from the "Seafood" category. Print each  product's name and price.

            //Query Syntax
            //var queryResult = from p in Source.ProductList
            //                  where p.Category == "Seafood"
            //                  select new { p.ProductName,p.UnitPrice};

            //Method Syntax
            //var methodResult = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .Select(p => new { p.ProductName,p.UnitPrice });

            //foreach (var method in methodResult)
            //{
            //    Console.WriteLine($"productName: {method.ProductName}, productPrice: {method.UnitPrice}");
            //}
            #endregion

            #region Q2)
            //Get a list of only the product names from ProductList. Print each name.

            var nameResult = Source.ProductList
                .Select(p => new { p.ProductName});

            foreach (var name in nameResult)
            {
                Console.WriteLine($"productName: {name.ProductName}");
            }
            #endregion
        }
    }
}
