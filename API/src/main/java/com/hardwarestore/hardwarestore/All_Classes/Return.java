package com.hardwarestore.hardwarestore.All_Classes;



import java.util.Date;

public class Return {
    private int returnId;
    private int productId;
    private int invoiceId;
    private String reason;
    private Date dateReturn;

    // Constructors
    public Return() {
    }

    public Return(int productId, int invoiceId, String reason, Date dateReturn) {
        this.productId = productId;
        this.invoiceId = invoiceId;
        this.reason = reason;
        this.dateReturn = dateReturn;
    }

    // Getters and setters
    public int getReturnId() {
        return returnId;
    }

    public void setReturnId(int returnId) {
        this.returnId = returnId;
    }

    public int getProductId() {
        return productId;
    }

    public void setProductId(int productId) {
        this.productId = productId;
    }

    public int getInvoiceId() {
        return invoiceId;
    }

    public void setInvoiceId(int invoiceId) {
        this.invoiceId = invoiceId;
    }

    public String getReason() {
        return reason;
    }

    public void setReason(String reason) {
        this.reason = reason;
    }

    public Date getDateReturn() {
        return dateReturn;
    }

    public void setDateReturn(Date dateReturn) {
        this.dateReturn = dateReturn;
    }

    // toString method
    @Override
    public String toString() {
        return "Return{" +
                "returnId=" + returnId +
                ", productId=" + productId +
                ", invoiceId=" + invoiceId +
                ", reason='" + reason + '\'' +
                ", dateReturn=" + dateReturn +
                '}';
    }
}