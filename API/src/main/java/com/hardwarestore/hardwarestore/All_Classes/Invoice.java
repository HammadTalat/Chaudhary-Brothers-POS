package com.hardwarestore.hardwarestore.All_Classes;

import java.util.Date;
import java.util.List;
import java.math.BigDecimal;


public class Invoice {
    private int invoiceId;
    private Date invoiceDate;
    private int customerId;
    private  String total;
    private List<InvoiceProduct> products;  // Added to include products associated with the invoice

    // Constructor
    public Invoice(int invoiceId, Date invoiceDate, int customerId,  String total, List<InvoiceProduct> products) {
        this.invoiceId = invoiceId;
        this.invoiceDate = invoiceDate;
        this.customerId = customerId;
        this.total = total;
        this.products = products;  // Initialize the list of products
    }

    // Getters and Setters
    public int getInvoiceId() {
        return invoiceId;
    }

    public void setInvoiceId(int invoiceId) {
        this.invoiceId = invoiceId;
    }

    public Date getInvoiceDate() {
        return invoiceDate;
    }

    public void setInvoiceDate(Date invoiceDate) {
        this.invoiceDate = invoiceDate;
    }

    public int getCustomerId() {
        return customerId;
    }

    public void setCustomerId(int customerId) {
        this.customerId = customerId;
    }

    public  String getTotal() {
        return total;
    }

    public void setTotal( String total) {
        this.total = total;
    }

    public List<InvoiceProduct> getProducts() {
        return products;
    }

    public void setProducts(List<InvoiceProduct> products) {
        this.products = products;
    }

    // toString method
    @Override
    public String toString() {
        return "Invoice{" +
                "invoiceId=" + invoiceId +
                ", invoiceDate=" + invoiceDate +
                ", customerId=" + customerId +
                ", total=" + total +
                ", products=" + products +
                '}';
    }
}
