class Customer
{
    private string _name;

    public string GetName() {
        return _name;
    }

    public bool LivesINUSA() {

        Address address = new Address();
        return address.GetCountry();

    }

}