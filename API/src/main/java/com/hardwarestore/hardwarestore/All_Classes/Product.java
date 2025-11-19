package com.hardwarestore.hardwarestore.All_Classes;


public class Product {
    private int productId;
    private String name;
    private String companyName;
    private double unitPrice;
    private double tax;
    private double salesPrice;
    private int unitQuantity;

    // Constructors
    public Product() {
    }

    public Product(String name, String companyName, double unitPrice, double tax, double salesPrice, int unitQuantity) {
        this.name = name;
        this.companyName = companyName;
        this.unitPrice = unitPrice;
        this.tax = tax;
        this.salesPrice = salesPrice;
        this.unitQuantity = unitQuantity;
    }

    // Getters and setters
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

    public String getCompanyName() {
        return companyName;
    }

    public void setCompanyName(String companyName) {
        this.companyName = companyName;
    }

    public double getUnitPrice() {
        return unitPrice;
    }

    public void setUnitPrice(double unitPrice) {
        this.unitPrice = unitPrice;
    }

    public double getTax() {
        return tax;
    }

    public void setTax(double tax) {
        this.tax = tax;
    }

    public double getSalesPrice() {
        return salesPrice;
    }

    public void setSalesPrice(double salesPrice) {
        this.salesPrice = salesPrice;
    }

    public int getUnitQuantity() {
        return unitQuantity;
    }

    public void setUnitQuantity(int unitQuantity) {
        this.unitQuantity = unitQuantity;
    }

    // toString method
    @Override
    public String toString() {
        return "Product{" +
                "productId=" + productId +
                ", name='" + name + '\'' +
                ", companyName='" + companyName + '\'' +
                ", unitPrice=" + unitPrice +
                ", tax=" + tax +
                ", salesPrice=" + salesPrice +
                ", unitQuantity=" + unitQuantity +
                '}';
    }
}