using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

public class Customer
{
    public int customerId { set; get; }
    public string firstName { set; get; }
    public string lastName { set; get; }
    public string email { set; get; }
    public string phoneNumber { set; get; }
    public string address { set; get; }

    // Default Constructor
    public Customer()
    {
    }

    // Parameterized Constructor
    public Customer(string firstName, string lastName, string email, string phoneNumber, string address)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.address = address;
    }

    public string toString()
    {
        return "Customer{" +
                "customerId=" + customerId +
                ", firstName='" + firstName + '\'' +
                ", lastName='" + lastName + '\'' +
                ", email='" + email + '\'' +
                ", phoneNumber='" + phoneNumber + '\'' +
                ", address='" + address + '\'' +
                '}';
    }
}
