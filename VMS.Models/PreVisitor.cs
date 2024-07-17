using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace VMS.Models;

public class PreVisitor
{
    
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int FlatOwnerId { get; set; }
    public string PhoneNumber { get; set; }
    public string UniqueQR { get; set; }
    
    public byte[]? Photo { get; set; }
    
    [ForeignKey("FlatOwnerId")]  
    public FlatOwner? FlatOwner { get; set; }
    
    
    
}