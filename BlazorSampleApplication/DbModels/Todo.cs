using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorSampleApplication.DbModels;

public partial class Todo
{
    public int Id { get; set; }
    
    [Required]
    public string? Title { get; set; }

    public string? Description { get; set; }
    public bool IsDone { get; set; }
}
