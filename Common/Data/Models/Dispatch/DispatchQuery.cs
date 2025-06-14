using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace KianaBH.Data.Models.Dispatch;

public class DispatchQuery
{
    [Required] public string? Version { get; set; }
    [FromQuery(Name = "t")] public int Timestamp { get; set; }
    public string? Lang { get; set; }
    public int Uid { get; set; }
    public string? Token { get; set; }
}