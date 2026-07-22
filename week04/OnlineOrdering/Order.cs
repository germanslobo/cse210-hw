namespace OnlineOrdering;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculates total cost of products + one-time shipping fee
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Apply shipping rate based on customer location
        decimal shippingCost = _customer.IsInUsa() ? 5.00m : 35.00m;
        
        return total + shippingCost;
    }

    // Generates packing label: lists Name and Product ID for each product
    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} | ID: {product.GetProductId()}\n";
        }
        return label;
    }

    // Generates shipping label: lists Customer Name and full Address
    public string GetShippingLabel()
    {
        return $"--- SHIPPING LABEL ---\n{_customer.GetName()}\n{_customer.GetAddress().GetFormattedAddress()}\n";
    }
}