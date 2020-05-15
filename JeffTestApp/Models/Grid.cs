using System;
using System.Collections.Generic;

namespace JeffTestApp.Models
{
    public class GridViewModel
    {
        public List<GridViewItem> Items { get; set; }

    }
    public class GridViewItem
    {
        public string SalesOrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ShipDate { get; set; }
        public string Status { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }
        public string SalesPersonLast { get; set; }
        public string SalesPersonFirst { get; set; }
    }
}
