using System;
using System.Collections.Generic;

namespace apidemoventas.Models;

public partial class Orderdetails
{
    public int Orderid { get; set; }

    public int Productid { get; set; }

    public float Unitprice { get; set; }

    public int Quantity { get; set; }

    public float Discount { get; set; }

    public virtual Orders Order { get; set; } = null!;

    public virtual Products Product { get; set; } = null!;
}
