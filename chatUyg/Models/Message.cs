using System;
using System.ComponentModel.DataAnnotations;
namespace chatUyg.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        [MaxLength(50)]
        public string UserName { get; set;}
        [MaxLength(144)]
        public string MessageText { get; set;}
        public DateTime MessageDate { get; set; }
    }
}
