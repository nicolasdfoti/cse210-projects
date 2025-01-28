class Product
{
    private string _name;
    private string _product_id;
    private decimal _price;
    private int _quantity;

    public Product(string name, string product_id, int price, int quantity) {
        _name = name;
        _product_id = product_id;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost() {
        return _price * _quantity;
    }

    public string GetName() {
        return _name;
    }

    public string GetProductID() {
        return _product_id;
    }

}