// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class CartEntry
{
    public float Price;
    public int Quantity;

    public float GetLineItemTotal()
    {
        return Price * Quantity;
    }
}

public class CartContents
{
    public CartEntry[] items;

    public float GetCartItemsTotal()
    {
        float cartTotal = 0;
        foreach (CartEntry item in items)
        {
            cartTotal += item.GetLineItemTotal();
        }
        return cartTotal;
    }
}

public class Order
{
    private CartContents cart;
    private float salesTax;

    public Order(CartContents cart, float salesTax)
    {
        this.cart = cart;
        this.salesTax = salesTax;
    }

    public float OrderTotal()
    {
        return cart.GetCartItemsTotal() * (1.0f + salesTax);
    }
}