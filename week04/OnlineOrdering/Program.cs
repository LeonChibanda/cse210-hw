//Leon Chibanda
//using friends show characters as example...best show ever
using System;

class Program
{
    static void Main(string[] args)
    {
        Order _order1 = new Order();
        _order1.CustomerInformation("Rachel Green", "123 Fashion Ave", "New York", "NY", "USA");
        _order1.AddProduct(150, "Designer Handbag", 299.99, 1);
        _order1.AddProduct(125, "Fashion Magazine", 9.99, 3);
        _order1.DisplayInformation();
        _order1.DisplayOrder();
        _order1.DisplaySum();

        Order _order2 = new Order();
        _order2.CustomerInformation("Chandler Bing", "456 Sarcasm St", "New York", "NY", "USA");
        _order2.AddProduct(150, "Coffee Mug", 12.99, 2);
        _order2.AddProduct(125, "Comedy Book", 19.99, 1);
        _order2.DisplayInformation();
        _order2.DisplayOrder();
        _order2.DisplaySum();

        Order _order3 = new Order();
        _order3.CustomerInformation("Monica Geller", "789 Cleanliness Rd", "New York", "NY", "USA");
        _order3.AddProduct(200, "Bread", 2.99, 3);
        _order3.AddProduct(300, "Butter", 4.49, 1);
        _order3.DisplayInformation();
        _order3.DisplayOrder();
        _order3.DisplaySum();

        Order _order4 = new Order();
        _order4.CustomerInformation("Joey Tribbiani", "101 Foodie Ln", "New York", "NY", "USA");
        _order4.AddProduct(400, "Pizza", 12.99, 2);
        _order4.AddProduct(500, "Soda", 1.99, 6);
        _order4.DisplayInformation();
        _order4.DisplayOrder();
        _order4.DisplaySum();

        Order _order5 = new Order();
        _order5.CustomerInformation("Phoebe Buffay", "202 Quirky Blvd", "New York", "NY", "USA");
        _order5.AddProduct(600, "Guitar Strings", 9.99, 1);
        _order5.AddProduct(700, "Coffee", 3.49, 2);
        _order5.DisplayInformation();
        _order5.DisplayOrder();
        _order5.DisplaySum();

    }
}