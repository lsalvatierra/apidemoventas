﻿using System;
using System.Collections.Generic;

namespace apidemoventas.Models;

public partial class Orders
{
    public int Orderid { get; set; }

    public string? Customerid { get; set; }

    public int? Employeeid { get; set; }

    public DateOnly? Orderdate { get; set; }

    public DateOnly? Requireddate { get; set; }

    public DateOnly? Shippeddate { get; set; }

    public int? Shipvia { get; set; }

    public float? Freight { get; set; }

    public string? Shipname { get; set; }

    public string? Shipaddress { get; set; }

    public string? Shipcity { get; set; }

    public string? Shipregion { get; set; }

    public string? Shippostalcode { get; set; }

    public string? Shipcountry { get; set; }

    public virtual Customers? Customer { get; set; }

    public virtual Employees? Employee { get; set; }

    public virtual ICollection<Orderdetails> Orderdetails { get; set; } = new List<Orderdetails>();
}
