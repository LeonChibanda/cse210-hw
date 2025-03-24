class Address
{
    private string _street, _city, _state, _country;
    public Address(){

    }

    public void SetAddress(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetAddress()
    {
        return ($"{_street} {_city} {_state}  {_country}");
    }
    public Boolean GetCountry()
    {
        if (_country == "USA"){
            return true;
        }
        else {
            return false;
        }
    }
}