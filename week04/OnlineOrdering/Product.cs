class Product
{
    private string _product;
    private double _price;
    private int _ID, _quantity;
    public Product(){

    }
    public void setProduct(int id, string product, double price, int quantity){
        _product = product;
        _ID = id;
        _price = price;
        _quantity = quantity;
    }
    public void DisplayProduct(){
        Console.WriteLine($"ID: {_ID} - {_product} ${_price} Quantity: {_quantity}");
    }
}
