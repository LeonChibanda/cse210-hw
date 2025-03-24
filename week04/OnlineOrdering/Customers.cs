class Customer
{
    private string _clientName;
    public Customer(){

    }
    public void setCustomer(string clientName){
        _clientName = clientName;
    }
    public string GetCustomer(){
        return _clientName;
    }
}