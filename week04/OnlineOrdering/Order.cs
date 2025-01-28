class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer) {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateTotalCost() {

        decimal subtotal = 0;

        foreach (var product in _products) {
            subtotal += product.GetTotalCost();
        }

        if (_customer.LivesINUSA()) {
            return subtotal + 5;
        }
        
        else {
            return subtotal + 35;
        }
    }

    public void DisplayPackingLabel() {
        
        foreach(var product in _products) {
            Console.WriteLine($"Name: {product.GetName()} - Product: {product.GetProductID()}");
            Console.WriteLine($"Total Cost: {CalculateTotalCost()}");
        }

    }

    public void DisplayShippingLabel() {

        Console.WriteLine($"Name: {_customer.GetName()}");
        Console.Write($"Address: ");
        _customer.GetAddress().DisplayAddress();        

    }

}