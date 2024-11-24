using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? FatherName { get; set; }
}
