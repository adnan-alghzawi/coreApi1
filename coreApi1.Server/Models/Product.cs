using System;
using System.Collections.Generic;

namespace coreApi1.Server.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }
}
