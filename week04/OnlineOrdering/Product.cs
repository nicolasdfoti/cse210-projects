class Product
{
    private string _name;
    private string _product_id;
    private int _price;
    private int _quantity;

    public Product(string name, string product_id, int price, int quantity) {
        _name = name;
        _product_id = product_id;
        _price = price;
        _quantity = quantity;
    }

    public int GetTotalCost() {
        int total = _price * _quantity;
        return total;
    }

}