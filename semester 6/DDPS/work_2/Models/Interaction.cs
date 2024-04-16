using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

public class Interaction
{
    [Key]
    public int Id { get; set; }



    [Required(ErrorMessage = "Укажите пользователя 1")]
    public User User1 { get; set; }
    [Key]
    [Column(Order = 1)]
    [ForeignKey(nameof(User1))]
    public int User1Id { get; set; }



    [Required(ErrorMessage = "Укажите пользователя 2")]
    public User User2 { get; set; }
    [Key]
    [Column(Order = 2)]
    [ForeignKey(nameof(User2))]
    public int User2Id { get; set; }



    [Required(ErrorMessage = "Укажите тип отношений для пользователя 1")]
    public TypeInteraction Type { get; set; } = TypeInteraction.None;
}
public enum TypeInteraction
{
    Enemy = -3,
    Blocked = -2,
    Blocker = -1,
    None = 0,
    Subscriber = 1,
    Subscription = 2,
    Friend = 3
}