using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

public class Message
{
    [Key]
    public int Id { get; set; }



    [Key]
    [Required(ErrorMessage = "Укажите отношения")]
    public Interaction Interaction { get; set; }
    [ForeignKey(nameof(Interaction))]
    public int InteractionId { get; set; }



    [DataType(DataType.DateTime)]
    public DateTime Date { get; set; } = DateTime.Now;



    [DataType(DataType.DateTime)]
    public DateTime DateEdit { get; set; } = DateTime.Now;


    
    //public Photo? Photo { get; set; } = null;



    [MaxLength(1000)]
    [DataType(DataType.MultilineText)]
    public string Text { get; set; } = "";



    public bool Check { get; set; } = false;
}
