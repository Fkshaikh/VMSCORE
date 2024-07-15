using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace VMS.Models;

public class PreVisitor
{
    
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int FlatOwnerId { get; set; }
    public string PhoneNumber { get; set; }
    public string UniqueQR { get; set; }
    [AllowNull]
    public string Photo { get; set; }
    
    [ForeignKey("FlatOwnerId")]  
    public FlatOwner? FlatOwner { get; set; }
    
    
    
}