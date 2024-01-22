using System.Data;

namespace examen2
{
public class Payments
    {
        public string? Customers { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }
    public Payments(string customers, DateTime date, decimal total)
    {
        string Customers = customers;
        DateTime Date =  date;
        decimal Total = total;
    }
    class Program
    {
        static void Main()
        {
            
        }
    }
}