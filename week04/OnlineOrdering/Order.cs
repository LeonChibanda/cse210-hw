using System.Security.Authentication;

class Order
{
    private List <Product> _product = new List <Product>();
    private Customer _customer = new Customer();
    private Address _address = new Address(); 
    private double _sum = 0;
    
    public Order(){
    }
    public void DisplayInformation(){
        Console.WriteLine(_customer.GetCustomer());
        Console.WriteLine(_address.GetAddress());
    }
    public void  DisplayOrder(){
        foreach (Product item in _product)
        {
            item.DisplayProduct();
        }
    }
    public void CustomerInformation(string name, string street, string city, string state, string country ){
        _customer.setCustomer(name);
        _address.SetAddress(street, city, state, country);
    }
    public void AddProduct(int id, string product, double price, int quantity){
        Product _p = new ();
        _p.setProduct(id, product, price, quantity);
        _sum += price * quantity;
        _product.Add(_p);
    }

    public void DisplaySum(){
        if (_address.GetCountry()){
            Console.WriteLine($"Total = ${_sum + 5}");
        }
        else{
            Console.WriteLine($"Total = ${_sum + 35}");
        }

    }
}