using System;
using System.Collections.Generic;

namespace apidemoventas.Models;

public partial class Categories
{
    public int Categoryid { get; set; }

    public string Categoryname { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Products> Products { get; set; } = new List<Products>();
}
