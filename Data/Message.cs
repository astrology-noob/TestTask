using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testProject.Data
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string MessageContent { get; set; } = string.Empty;
    }
}
