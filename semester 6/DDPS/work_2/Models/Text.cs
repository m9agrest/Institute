using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace work_2.Models
{
    public class Text
    {
        public Message Message { get; set; }
        [Key]
        [ForeignKey(nameof(Message))]
        public int MessageId { get; set; }
    }
}
