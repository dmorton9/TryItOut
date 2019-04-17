using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.Domain.Interfaces;

namespace TryItOut.Domain
{
    public class ToDoTask : IToDoTask
    {
        [Key]
        public int Identifier { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime RequiredBy { get; set; }

        public DateTime CompletedOn { get; set; }
    }
}
