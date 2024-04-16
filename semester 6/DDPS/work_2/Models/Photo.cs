using System.ComponentModel.DataAnnotations;


public class Photo
{
    [Key]
    public int Id { get; set; }



    [MaxLength(16), MinLength(16)]
    public string Name { get; set; }
}
