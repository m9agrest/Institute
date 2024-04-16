using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace work.Models
{
    public class ChatMessage
    {
        //[Key]
        public int Id { get; set; }

        /*[ForeignKey("Chat")]
        [Column(Order = 1)]
        [Required]*/
        public int Chat { get; set; }

        /*[ForeignKey("Chat")]
        [Column(Order = 2)]
        [Required]*/
        public int LocalId { get; set; }

        //[Required]
        public int Sender { get; set; }
        //[Required]
        public int Date { get; set; }
        //[Required]
        public int DateEdit { get; set; }
    }
}
