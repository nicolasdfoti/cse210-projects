class Order
{
    private List<Product> _products = new List<Product>();
    private string _customer;

    public decimal CalculateTotalCost() {

        Product product = new Product();
        Customer customer = new Customer();

        decimal subtotal = product.GetTotalCost();

        if (customer.LivesINUSA()) {
            return subtotal + 5;
        }
        
        else {
            return subtotal + 35;
        }
    }

    public void DisplayPackingLabel() {
        
        foreach(var product in _products) {
            Console.WriteLine($"Name: {product.GetName()} - Product: {product.GetProductID()}");
        }

    }

    public void DisplayShippingLabel() {

        Customer customer = new Customer();
        Console.WriteLine($"Name: {customer.GetName()}");

    }

}