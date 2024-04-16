using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int Id { get; set; }



    [Required(ErrorMessage = "Введите имя пользователя")]
    [MaxLength(32), MinLength(3)]
    public string Name { get; set; }



    //public Photo? Photo { get; set; }



    [Required(ErrorMessage = "Введите пароль пользователя")]
    [DataType(DataType.Password)]
    [MaxLength(32), MinLength(8)]
    public string Password { get; set; }



    [Required(ErrorMessage = "Введите почту пользователя")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
}
