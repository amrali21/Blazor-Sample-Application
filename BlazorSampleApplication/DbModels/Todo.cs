using System;
using System.Collections.Generic;

namespace BlazorSampleApplication.DbModels;

public partial class Todo
{
    public string Id { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }
}
