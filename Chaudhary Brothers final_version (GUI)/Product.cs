public class Product
{
    public int productId { get; set; }
    public string name { get; set; }
    public string companyName { get; set; }
    public decimal unitPrice { get; set; }
    public decimal tax { get; set; }
    public decimal salesPrice { get; set; }
    public int unitQuantity { get; set; }

    // Default Constructor
    public Product()
    {
    }

    // Parameterized Constructor
    public Product(string nam, string companyNam, decimal unitPric, decimal ta, decimal salesPric, int unitQuantit)
    {
        name = nam;
        companyName = companyNam;
        unitPrice = unitPric;
        tax = ta;
        salesPrice = salesPric;
        unitQuantity = unitQuantit;
    }

    // ToString method equivalent in C# for debugging purposes
    public override string ToString()
    {
        return $"Product{{ProductId={productId}, Name='{name}', CompanyName='{companyName}', UnitPrice={unitPrice}, Tax={tax}, SalesPrice={salesPrice}, UnitQuantity={unitQuantity}}}";
    }
}
