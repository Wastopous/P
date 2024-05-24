using System;

namespace Primer.Classes;

public class Order
{
    public int ID { get; set; } 
    public string Description { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public int Status { get; set; }
}