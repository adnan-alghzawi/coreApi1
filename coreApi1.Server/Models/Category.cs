using System;
using System.Collections.Generic;

namespace coreApi1.Server.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? CategoryDescription { get; set; }
}
