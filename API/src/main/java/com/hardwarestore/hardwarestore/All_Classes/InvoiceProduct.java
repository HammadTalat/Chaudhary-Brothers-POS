package com.hardwarestore.hardwarestore.All_Classes;

import java.math.BigDecimal;

public class InvoiceProduct {
    private int productId;
    private String name;
    private int quantity;
    private String unit;
    private String unitPrice; // Using BigDecimal for precise calculation
    private String gstApplied;
    private String subtotal;

    // Constructors
    public InvoiceProduct() {
    }

    public InvoiceProduct(int productId, String name, int quantity, String unit,
                          String unitPrice,   String gstApplied,   String subtotal) {
        this.productId = productId;
        this.name = name;
        this.quantity = quantity;
        this.unit = unit;
        this.unitPrice = unitPrice; // Initialize unit price
        this.gstApplied = gstApplied;
        this.subtotal = subtotal;
    }

    // Getters and Setters
    public int getProductId() {
        return productId;
    }

    public void setProductId(int productId) {
        this.productId = productId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public String getUnit() {
        return unit;
    }

    public void setUnit(String unit) {
        this.unit = unit;
    }

    public  String getUnitPrice() {
        return unitPrice;
    }

    public void setUnitPrice(  String unitPrice) {
        this.unitPrice = unitPrice;
    }

    public   String getGstApplied() {
        return gstApplied;
    }

    public void setGstApplied(  String gstApplied) {
        this.gstApplied = gstApplied;
    }

    public   String getSubtotal() {
        return subtotal;
    }

    public void setSubtotal(  String subtotal) {
        this.subtotal = subtotal;
    }
}
