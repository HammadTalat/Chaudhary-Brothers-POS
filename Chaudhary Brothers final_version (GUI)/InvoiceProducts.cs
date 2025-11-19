public class InvoiceProduct
{
    public int invoiceId;
    public int productId { get; set; }
    public string name { get; set; }
    public int quantity { get; set; }
    public string unit { get; set; }
    public string unitPrice { get; set; }
    public string gstApplied { get; set; }
    public string subtotal { get; set; }

    // Constructor
    public InvoiceProduct(int productI,string n, int quantit, string  r, string gstpplied, string sub)
    {
        productId = productI;
        name = n;
        quantity = quantit;
        unitPrice = r;
        gstApplied = gstpplied;
        unit = "Number";
        subtotal = sub;
    }
   public  InvoiceProduct() { }

    // Other methods can be added here
}
