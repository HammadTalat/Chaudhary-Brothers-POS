using System;
using System.Collections.Generic;

public class Invoice
{
    public int invoiceId { get; set; }
    public DateTime invoiceDate { get; set; }
    public int customerId { get; set; }
    public string total { get; set; }
    public List<InvoiceProduct> products { get; set; }  

    // Constructor
    public Invoice(DateTime invoiceDat, int customerI)
    {
        invoiceDate = invoiceDat;
        customerId = customerI;
        total = "0.00";  // Initialize the total to zero
    }
    public Invoice() { }

    // Other methods can be added here
}
