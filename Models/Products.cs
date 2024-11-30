using System;
using System.Collections.Generic;

namespace apidemoventas.Models;

public partial class Products
{
    public int Productid { get; set; }

    public string Productname { get; set; } = null!;

    public int? Supplierid { get; set; }

    public int? Categoryid { get; set; }

    public string? Quantityperunit { get; set; }

    public float? Unitprice { get; set; }

    public int? Unitsinstock { get; set; }

    public int? Unitsonorder { get; set; }

    public int? Reorderlevel { get; set; }

    public bool Discontinued { get; set; }

    public virtual Categories? Category { get; set; }

    public virtual ICollection<Orderdetails> Orderdetails { get; set; } = new List<Orderdetails>();

    public virtual Suppliers? Supplier { get; set; }
}
