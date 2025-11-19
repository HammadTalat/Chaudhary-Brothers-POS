package com.hardwarestore.hardwarestore.cont;
import com.hardwarestore.hardwarestore.All_Classes.Customer;
import com.hardwarestore.hardwarestore.All_Classes.Product;
import com.hardwarestore.hardwarestore.All_Classes.Invoice;
import com.hardwarestore.hardwarestore.All_Classes.Forecast;
import com.hardwarestore.hardwarestore.All_Classes.InvoiceProduct;
import com.hardwarestore.hardwarestore.All_Classes.Return;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Component;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.jdbc.core.simple.SimpleJdbcCall;
import org.springframework.jdbc.core.namedparam.SqlParameterSource;
import org.springframework.jdbc.core.namedparam.MapSqlParameterSource;
import java.math.BigDecimal;
import java.math.RoundingMode;
import java.sql.ResultSet;
import java.util.List;
import java.util.Map;
import java.util.HashMap;
import javax.sql.DataSource;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Types;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import javax.sql.DataSource;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Types;
import com.microsoft.sqlserver.jdbc.SQLServerDataTable;
import org.springframework.http.ResponseEntity;
import org.springframework.http.HttpStatus;



@RestController
public class DatabaseController {

    @Autowired
    private JdbcTemplate jdbcTemplate;
    @Autowired(required = true)
    private DataSource dataSource;


    @PostMapping("/InsertCashier")
    public String insertCashier(@RequestBody String password) {
        try {
            // Execute the SQL insert query to insert a new cashier with the provided password
            jdbcTemplate.update("INSERT INTO CashierLogin (password) VALUES (?)", password);
            return "Cashier inserted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to insert cashier. Error: " + e.getMessage();
        }
    }

    @DeleteMapping("/DeleteCashier/{cashierId}")
    public String deleteCashier(@PathVariable int cashierId) {
        try {
            // Execute the SQL delete query to delete the cashier with the provided ID
            int rowsAffected = jdbcTemplate.update("DELETE FROM CashierLogin WHERE cashier_id = ?", cashierId);
            if (rowsAffected > 0) {
                return "Cashier deleted successfully.";
            } else {
                return "No cashier found with the provided ID.";
            }
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to delete cashier. Error: " + e.getMessage();
        }
    }

    @PutMapping("/UpdateCashierPassword/{cashierId}")
    public String updateCashierPassword(@PathVariable int cashierId, @RequestBody String newPassword) {
        try {
            // Execute the SQL update query to update the cashier's password
            int rowsAffected = jdbcTemplate.update("UPDATE CashierLogin SET password = ? WHERE cashier_id = ?", newPassword, cashierId);
            if (rowsAffected > 0) {
                return "Cashier password updated successfully.";
            } else {
                return "No cashier found with the provided ID.";
            }
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to update cashier password. Error: " + e.getMessage();
        }
    }
    @GetMapping("/CashierLogin")
    public String Cashierlogin(@RequestParam("cashierId") int cashierId, @RequestParam("password") String password) {
        try {
            String actualPassword = jdbcTemplate.queryForObject(
                    "EXEC CashierLoginProcedure ?, ?",
                    new Object[]{cashierId, password},
                    String.class);

            if (actualPassword != null && actualPassword.equals(password)) {
                return "Login successful.";
            } else {
                return "Invalid credentials. Please check your ID and password.";
            }
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to log in. Error: " + e.getMessage();
        }
    }


    @PostMapping("/InsertOwner")
    public String insertOwner(@RequestBody String password) {
        try {
            // Execute the SQL insert query to insert a new owner with the provided password
            jdbcTemplate.update("EXEC InsertOwner ?", password);
            return "Owner inserted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to insert owner. Error: " + e.getMessage();
        }
    }

    @DeleteMapping("/Delete Owner/{ownerId}")
    public String deleteOwner(@PathVariable int ownerId) {
        try {
            // Execute the SQL delete query to delete the owner with the provided ID
            jdbcTemplate.update("EXEC DeleteOwner ?", ownerId);
            return "Owner deleted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to delete owner. Error: " + e.getMessage();
        }
    }

    @PutMapping("/UpdateOwnerPassword/{ownerId}")
    public String updateOwnerPassword(@PathVariable int ownerId, @RequestBody String newPassword) {
        try {
            // Execute the SQL update query to update the owner's password
            int rowsAffected = jdbcTemplate.update("UPDATE OwnerLogin SET password = ? WHERE owner_id = ?", newPassword, ownerId);
            if (rowsAffected > 0) {
                return "Owner password updated successfully.";
            } else {
                return "No owner found with the provided ID.";
            }
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to update owner password. Error: " + e.getMessage();
        }
    }
    @GetMapping("/OwnerLogin")
    public String Ownerlogin(@RequestParam("ownerId") int ownerId, @RequestParam("password") String password){
        try {
            String actualPassword = jdbcTemplate.queryForObject(
                    "EXEC OwnerLoginProcedure ?, ?",
                    new Object[]{ownerId, password},
                    String.class);

            if (actualPassword != null && actualPassword.equals(password)) {
                return "Login successful.";
            } else {
                return "Invalid credentials. Please check your ID and password.";
            }
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to log in. Error: " + e.getMessage();
        }
    }

    @PostMapping("/InsertCustomer")
    public String insertCustomer(@RequestBody Customer customer) {
        try {
            // Execute the SQL insert query to insert a new customer
            jdbcTemplate.update("EXEC InsertCustomer ?, ?, ?, ?, ?",
                    customer.getFirstName(),
                    customer.getLastName(),
                    customer.getEmail(),
                    customer.getPhoneNumber(),
                    customer.getAddress());
            return "Customer inserted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to insert customer. Error: " + e.getMessage();
        }
    }

    @DeleteMapping("/DeleteCustomer/{customerId}")
    public String deleteCustomer(@PathVariable int customerId) {
        try {
            // Execute the SQL delete query to delete the customer with the provided ID
            jdbcTemplate.update("EXEC DeleteCustomer ?", customerId);
            return "Customer deleted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to delete customer. Error: " + e.getMessage();
        }
    }

    @PutMapping("/UpdateCustomer/{customerId}")
    public String updateCustomer(@PathVariable int customerId, @RequestBody Customer customer) {
        try {
            // Execute the SQL update query to update the customer's information
            jdbcTemplate.update("EXEC UpdateCustomer ?, ?, ?, ?, ?, ?",
                    customerId,
                    customer.getFirstName(),
                    customer.getLastName(),
                    customer.getEmail(),
                    customer.getPhoneNumber(),
                    customer.getAddress());
            return "Customer information updated successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to update customer information. Error: " + e.getMessage();
        }
    }

    @PostMapping("/InsertProduct")
    public String insertProduct(@RequestBody Product product) {
        System.out.println(product.getName());
        try {
            // Execute the SQL insert query to insert a new product
            jdbcTemplate.update("EXEC InsertProduct ?, ?, ?, ?, ?, ?", product.getName(), product.getCompanyName(),
                    product.getUnitPrice(), product.getTax(), product.getSalesPrice(), product.getUnitQuantity());
            return "Product inserted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to insert product. Error: " + e.getMessage();
        }
    }

    @DeleteMapping("/DeleteProduct/{productId}")
    public String deleteProduct(@PathVariable int productId) {
        try {
            // Execute the SQL delete query to delete the product with the provided ID
            jdbcTemplate.update("EXEC DeleteProduct ?", productId);
            return "Product deleted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to delete product. Error: " + e.getMessage();
        }
    }

    @PutMapping("/UpdateProduct/{productId}")
    public String updateProduct(@PathVariable int productId, @RequestBody Product product) {
        try {
            // Execute the SQL update query to update the product details
            jdbcTemplate.update("EXEC UpdateProduct ?, ?, ?, ?, ?, ?, ?", productId, product.getName(), product.getCompanyName(),
                    product.getUnitPrice(), product.getTax(), product.getSalesPrice(), product.getUnitQuantity());
            return "Product details updated successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to update product details. Error: " + e.getMessage();
        }
    }

    @PostMapping("/InsertReturn")
    public String insertReturn(@RequestBody Map<String, Object> requestBody) {
        try {
            int productId = (int) requestBody.get("product_id");
            int invoiceId = (int) requestBody.get("invoice_id");
            String reason = (String) requestBody.get("reason");
            String dateReturn = (String) requestBody.get("date_return");

            // Execute the SQL insert query to insert a new return
            jdbcTemplate.update("EXEC InsertReturn ?, ?, ?, ?", productId, invoiceId, reason, dateReturn);
            return "Return inserted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to insert return. Error: " + e.getMessage();
        }
    }

    // Delete mapping for Returns
    @DeleteMapping("/DeleteReturn/{returnId}")
    public String deleteReturn(@PathVariable int returnId) {
        try {
            // Execute the SQL delete query to delete the return with the provided ID
            jdbcTemplate.update("EXEC DeleteReturn ?", returnId);
            return "Return deleted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to delete return. Error: " + e.getMessage();
        }
    }

    // Update mapping for Returns
    @PutMapping("/UpdateReturn/{returnId}")
    public String updateReturn(@PathVariable int returnId, @RequestBody Map<String, Object> requestBody) {
        try {
            int productId = (int) requestBody.get("product_id");
            int invoiceId = (int) requestBody.get("invoice_id");
            String reason = (String) requestBody.get("reason");
            String dateReturn = (String) requestBody.get("date_return");

            // Execute the SQL update query to update the return
            jdbcTemplate.update("EXEC UpdateReturn ?, ?, ?, ?, ?", returnId, productId, invoiceId, reason, dateReturn);
            return "Return updated successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to update return. Error: " + e.getMessage();
        }
    }

    @PostMapping("/insertForecastedSale")
    public String insertForecastedSale(@RequestBody Forecast forecastedSale) {
        try {
            String query = "EXEC InsertForecastedSale ?, ?, ?, ?, ?";
            jdbcTemplate.update(query, forecastedSale.getProductId(), forecastedSale.getProductName(),
                    forecastedSale.getForecastedWeeklySale(), forecastedSale.getForecastedWeekStart(),
                    forecastedSale.getForecastedWeekEnd());
            return "Forecasted sale inserted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to insert forecasted sale. Error: " + e.getMessage();
        }
    }

    @DeleteMapping("/deleteForecastedSale/{forecastId}")
    public String deleteForecastedSale(@PathVariable int forecastId) {
        try {
            String query = "EXEC DeleteForecastedSale ?";
            jdbcTemplate.update(query, forecastId);
            return "Forecasted sale deleted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to delete forecasted sale. Error: " + e.getMessage();
        }
    }

    @PutMapping("/updateForecastedSale/{forecastId}")
    public String updateForecastedSale(@PathVariable int forecastId, @RequestBody Forecast forecastedSale) {
        try {
            String query = "EXEC UpdateForecastedSale ?, ?, ?, ?, ?, ?";
            jdbcTemplate.update(query, forecastId, forecastedSale.getProductId(), forecastedSale.getProductName(),
                    forecastedSale.getForecastedWeeklySale(), forecastedSale.getForecastedWeekStart(),
                    forecastedSale.getForecastedWeekEnd());
            return "Forecasted sale updated successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to update forecasted sale. Error: " + e.getMessage();
        }
    }

    @PostMapping("/InsertInvoice")
    public String insertInvoice(@RequestBody Invoice invoice) {
        try {
            // Execute the SQL insert query to insert a new invoice
            jdbcTemplate.update("EXEC InsertInvoice ?, ?, ?, ?, ?, ?");
//                    invoice.getProductId(),
//                    invoice.getName(),
//                    invoice.getQuantity(),
//                    invoice.getUnit(),
//                    invoice.getGst(),
//                    invoice.getTotal());
            return "Invoice inserted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to insert invoice. Error: " + e.getMessage();
        }
    }


    @DeleteMapping("/deleteInvoice/{invoiceId}")
    public String deleteInvoice(@PathVariable int invoiceId) {
        try {
            String query = "EXEC DeleteInvoice ?";
            jdbcTemplate.update(query, invoiceId);
            return "Invoice deleted successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to delete invoice. Error: " + e.getMessage();
        }
    }

    @PutMapping("/updateInvoice/{invoiceId}")
    public String updateInvoice(@PathVariable int invoiceId, @RequestBody Invoice invoice) {
        try {
            String query = "EXEC UpdateInvoice ?, ?, ?, ?, ?, ?, ?";
//            jdbcTemplate.update(query, invoiceId, invoice.getProductId(), invoice.getName(),
//                    invoice.getQuantity(), invoice.getUnit(),
//                    invoice.getGst(), invoice.getTotal());
            return "Invoice updated successfully.";
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to update invoice. Error: " + e.getMessage();
        }
    }
    @GetMapping("/getAllProducts")
    public List<Map<String, Object>> getAllProducts() {
        String sql = "SELECT * FROM Product";
        List<Map<String, Object>> products = jdbcTemplate.queryForList(sql);
        return products;
    }
    @GetMapping("/getAllCustomers")
    public List<Map<String, Object>> getAllCustomers() {
        String sql = "SELECT * FROM Customer";
        List<Map<String, Object>> products = jdbcTemplate.queryForList(sql);
        return products;
    }
    @GetMapping("/getProductsName")
    public List<Map<String, Object>> getProductsName() {
        String sql = "SELECT name from Product";
        List<Map<String, Object>> products = jdbcTemplate.queryForList(sql);
        return products;
    }


    @GetMapping("/getProductQuantity")
    public Integer getProductQuantity(@RequestParam String productName) {
        String sql = "SELECT unit_quantity FROM Product WHERE name = ?";
        Integer quantity = jdbcTemplate.queryForObject(sql, new Object[]{productName}, Integer.class);
        return quantity;
    }
    @GetMapping("/getProductRate")
    public Integer getProductRate(@RequestParam String productName) {
        String sql = "SELECT sales_price FROM Product WHERE name = ?";
        Integer quantity = jdbcTemplate.queryForObject(sql, new Object[]{productName}, Integer.class);
        return quantity;
    }
    @GetMapping("/getProductTax")
    public Integer getProductTax(@RequestParam String productName) {
        String sql = "SELECT tax FROM Product WHERE name = ?";
        Integer quantity = jdbcTemplate.queryForObject(sql, new Object[]{productName}, Integer.class);
        return quantity;
    }
    @GetMapping("/getProductID")
    public Integer getProductID(@RequestParam String productName) {
        String sql = "SELECT product_id FROM Product WHERE name = ?";
        Integer id = jdbcTemplate.queryForObject(sql, new Object[]{productName}, Integer.class);
        return id;
    }



    @PostMapping("/InsertInvoice1")
    public String insertInvoice1(@RequestBody Invoice invoice) {
        try (Connection conn = dataSource.getConnection();
             CallableStatement cstmt = conn.prepareCall("{call CreateInvoice(?, ?, ?, ?)}")) {

            cstmt.setInt(1, invoice.getCustomerId());
            cstmt.setDate(2, new java.sql.Date(invoice.getInvoiceDate().getTime()));
            cstmt.setString(3, invoice.getTotal());

            SQLServerDataTable tvp = new SQLServerDataTable();
            tvp.addColumnMetadata("product_id", Types.INTEGER);
            tvp.addColumnMetadata("name", Types.NVARCHAR);
            tvp.addColumnMetadata("quantity", Types.INTEGER);
            tvp.addColumnMetadata("unit", Types.NVARCHAR);
            tvp.addColumnMetadata("gst", Types.VARCHAR);
            tvp.addColumnMetadata("unit_price", Types.VARCHAR);
            tvp.addColumnMetadata("subtotal", Types.VARCHAR);
            for (InvoiceProduct product : invoice.getProducts()) {
                int a = product.getProductId();
                String b = product.getName();
                int c = product.getQuantity();
                String d = product.getUnit();

                // Original values with scale adjustment
              String e = product.getGstApplied();
                String f = product.getUnitPrice();
                String g = product.getSubtotal();

                // Pass the corrected values to the row addition method
                tvp.addRow(a, b, c, d, e,f,g);
            }


            cstmt.setObject(4, tvp);
            cstmt.execute();
            return "Invoice created successfully.";
        } catch (SQLException e) {
            e.printStackTrace();
            return "Failed to insert invoice due to: " + e.getMessage();
        }
    }
    @GetMapping("/countInvoices")
    public Integer countInvoices() {
        String sql = "SELECT COUNT(*) FROM Invoice";
        Integer count = jdbcTemplate.queryForObject(sql, Integer.class);
        return count;
    }
    @PutMapping("/UpdateProductQuantity/{productId}")
    public String updateProductQuantity(@PathVariable int productId, @RequestParam int quantity) {
        try {
            // Define the SQL query to update the product quantity
            String sql = "UPDATE Product SET unit_quantity = unit_quantity - ? WHERE product_id = ?";

            // Execute the update
            int rowsAffected = jdbcTemplate.update(sql, quantity, productId);
            if (rowsAffected > 0) {
                return "Product quantity updated successfully.";
            } else {
                return "No product found with ID: " + productId;
            }
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to update product quantity. Error: " + e.getMessage();
        }
    }

    @GetMapping("/checkCustomer")
    public Integer checkCustomer(@RequestParam int id) {
        String sql = "SELECT COUNT(*) FROM Customer WHERE customer_id = ?";
        Integer count = jdbcTemplate.queryForObject(sql, new Object[]{id}, Integer.class);
        return (count != null && count > 0) ? 1 : 0;
    }

    @GetMapping("/getInvoiceDetails")
    public ResponseEntity<?> getInvoiceDetails(@RequestParam int invoiceId) {
        try {
            String sql = "SELECT  p.name AS product_name, p.unit_price AS sale_price, " +
                    "p.quantity, p.unit, p.gst AS tax, p.subtotal, i.total AS grand_total " +
                    "FROM dbo.Invoice i " +
                    "JOIN dbo.InvoiceProduct p ON i.invoice_id = p.invoice_id " +
                    "WHERE i.invoice_id = ?";

            List<String> invoiceDetails = jdbcTemplate.query(sql, new Object[]{invoiceId}, (rs, rowNum) ->
                    String.format("%s, %.2f,%.2f,%s,%.2f,%.2f",
                             rs.getString("product_name"), rs.getDouble("sale_price"),
                            rs.getDouble("quantity"), rs.getString("unit"), rs.getDouble("tax"),
                            rs.getDouble("subtotal"))
            );

            return ResponseEntity.ok(invoiceDetails);
        } catch (Exception e) {
            // Log the exception details to help with debugging
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("Failed to retrieve invoice details: " + e.getMessage());
        }
    }
    @GetMapping("/getInvoiceDate")
    public String getInvoiceDate(@RequestParam int product) {
        String sql = "SELECT invoice_date FROM Invoice WHERE invoice_id = ?";
        String id = jdbcTemplate.queryForObject(sql, new Object[]{product}, String.class);
        return id;
    }
    @DeleteMapping("/deleteProductFromInvoice/{invoiceId}/{productId}")
    public ResponseEntity<?> deleteProductFromInvoice(@PathVariable int invoiceId, @PathVariable int productId) {
        try {
            String sql = "DELETE FROM InvoiceProduct WHERE product_id = ? AND invoice_id = ?";
            int rowsAffected = jdbcTemplate.update(sql, productId, invoiceId);

            if (rowsAffected > 0) {
                return ResponseEntity.ok("Product deleted successfully from the invoice.");
            } else {
                return ResponseEntity.badRequest().body("No product found with provided ID: " + productId + " in invoice ID: " + invoiceId);
            }
        } catch (Exception e) {
            return ResponseEntity.internalServerError().body("Error deleting product from invoice: " + e.getMessage());
        }
    }

    ///Hassnain K functions Owner k
    @GetMapping("/getPopularItem")
    public String getPopularItem()
    {
        String sql = "WITH RankedProducts AS (\n" +
                "    SELECT name, SUM(quantity) AS TotalQuantity\n" +
                "    FROM InvoiceProduct\n" +
                "    GROUP BY name\n" +
                ")\n" +
                "SELECT TOP 1 name\n" +
                "FROM RankedProducts\n" +
                "ORDER BY TotalQuantity DESC";
        String name = jdbcTemplate.queryForObject(sql, String.class);
        return name;
    }
    @GetMapping("/getAllProductsDesc")
    public List<Map<String, Object>> getAllProductsDesc() {
        String sql = "SELECT * FROM Product ORDER BY product_id DESC;\n";
        List<Map<String, Object>> products = jdbcTemplate.queryForList(sql);
        return products;
    } @GetMapping("/getTotalUnitPrice")
    public BigDecimal getTotalUnitPrice() {
        String sql = "SELECT SUM(unit_price * unit_quantity) AS Total_Unit_Prices FROM Product";
        BigDecimal totalUnitPrice = jdbcTemplate.queryForObject(sql, BigDecimal.class);
        return totalUnitPrice;
    }
    @GetMapping("/getTotalSalesPrice")
    public BigDecimal getTotalSalesPrice() {
        String sql = "SELECT SUM(sales_price * unit_quantity) AS Total_Sales_Prices\n" +
                "FROM Product;\n";
        BigDecimal totalSalesPrice = jdbcTemplate.queryForObject(sql, BigDecimal.class);
        return totalSalesPrice;
    }
    @GetMapping("/getExpectedProfit")
    public BigDecimal getExpectedProfit() {
        String sql = "SELECT SUM(sales_price * unit_quantity) - SUM(unit_price * unit_quantity) AS Expected_Profit FROM Product";
        BigDecimal expectedProfit = jdbcTemplate.queryForObject(sql, BigDecimal.class);
        return expectedProfit;
    }
    @GetMapping("/getInventoryAlerts")
    public List<Map<String, Object>> getInventoryAlerts() {
        String sql = "SELECT product_id ,name, unit_quantity\n" +
                "FROM Product\n" +
                "WHERE unit_quantity <= 5;";
        List<Map<String, Object>> products = jdbcTemplate.queryForList(sql);
        return products;
    }
    @GetMapping("/getSalesDetailsByDateRange")
    public List<Map<String, Object>> getSalesDetailsByDateRange(
            @RequestParam String startDate,
            @RequestParam String endDate) {

        String sql = """
            SELECT 
                I.invoice_date,
                P.name,
                P.company_name,
                P.sales_price,
                 SUM(IP.quantity * P.sales_price) AS total_price,
                SUM(IP.quantity) AS total_quantity_sold
            FROM 
                Product P
            JOIN 
                InvoiceProduct IP ON P.product_id = IP.product_id
            JOIN 
                Invoice I ON I.invoice_id = IP.invoice_id
            WHERE 
                I.invoice_date BETWEEN ? AND ?
            GROUP BY 
                I.invoice_date, P.name, P.company_name, P.sales_price
            ORDER BY 
                I.invoice_date, P.name;
            """;

        return jdbcTemplate.queryForList(sql, startDate, endDate);
    }
    @PutMapping("/UpdateProductQuantity2/{productId}")
    public String updateProductQuantity2(@PathVariable int productId, @RequestParam int quantity) {
        try {
            // Define the SQL query to update the product quantity
            String sql = "UPDATE Product SET unit_quantity = unit_quantity + ? WHERE product_id = ?";

            // Execute the update
            int rowsAffected = jdbcTemplate.update(sql, quantity, productId);
            if (rowsAffected > 0) {
                return "Product quantity updated successfully.";
            } else {
                return "No product found with ID: " + productId;
            }
        } catch (Exception e) {
            e.printStackTrace();
            return "Failed to update product quantity. Error: " + e.getMessage();
        }
    }
    @GetMapping("/getInvoiceProductQuant")
    public Integer getInvoiceProductQuant(@RequestParam String productName, @RequestParam int invoiceId) {
        try {
            String sql = "SELECT quantity FROM InvoiceProduct WHERE name = ? AND invoice_id = ?";
            return jdbcTemplate.queryForObject(sql, new Object[]{productName, invoiceId}, Integer.class);
        }  catch (Exception e) {
            // Log error or handle other exceptions as needed
            throw new RuntimeException("Error retrieving product quantity: " + e.getMessage());
        }
    }
    @GetMapping("/checkInvoiceExists")
    public boolean checkInvoiceExists(@RequestParam int invoiceId) {
        try {
            String sql = "SELECT COUNT(*) FROM Invoice WHERE invoice_id = ?";
            int count = jdbcTemplate.queryForObject(sql, new Object[]{invoiceId}, Integer.class);
            return count > 0;
        } catch (Exception e) {
            throw new RuntimeException("Error checking invoice existence: " + e.getMessage());
        }
    }

}
