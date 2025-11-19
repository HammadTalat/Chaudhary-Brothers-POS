package com.hardwarestore.hardwarestore.All_Classes;


import java.util.Date;

public class Forecast {
    private int forecastId;
    private int productId;
    private String productName;
    private int forecastedWeeklySale;
    private Date forecastedWeekStart;
    private Date forecastedWeekEnd;

    // Constructors
    public Forecast() {
    }

    public Forecast(int productId, String productName, int forecastedWeeklySale, Date forecastedWeekStart, Date forecastedWeekEnd) {
        this.productId = productId;
        this.productName = productName;
        this.forecastedWeeklySale = forecastedWeeklySale;
        this.forecastedWeekStart = forecastedWeekStart;
        this.forecastedWeekEnd = forecastedWeekEnd;
    }

    // Getters and setters
    public int getForecastId() {
        return forecastId;
    }

    public void setForecastId(int forecastId) {
        this.forecastId = forecastId;
    }

    public int getProductId() {
        return productId;
    }

    public void setProductId(int productId) {
        this.productId = productId;
    }

    public String getProductName() {
        return productName;
    }

    public void setProductName(String productName) {
        this.productName = productName;
    }

    public int getForecastedWeeklySale() {
        return forecastedWeeklySale;
    }

    public void setForecastedWeeklySale(int forecastedWeeklySale) {
        this.forecastedWeeklySale = forecastedWeeklySale;
    }

    public Date getForecastedWeekStart() {
        return forecastedWeekStart;
    }

    public void setForecastedWeekStart(Date forecastedWeekStart) {
        this.forecastedWeekStart = forecastedWeekStart;
    }

    public Date getForecastedWeekEnd() {
        return forecastedWeekEnd;
    }

    public void setForecastedWeekEnd(Date forecastedWeekEnd) {
        this.forecastedWeekEnd = forecastedWeekEnd;
    }

    // toString method
    @Override
    public String toString() {
        return "Forecast{" +
                "forecastId=" + forecastId +
                ", productId=" + productId +
                ", productName='" + productName + '\'' +
                ", forecastedWeeklySale=" + forecastedWeeklySale +
                ", forecastedWeekStart=" + forecastedWeekStart +
                ", forecastedWeekEnd=" + forecastedWeekEnd +
                '}';
    }
}