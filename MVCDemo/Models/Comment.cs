using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }

        public string CommentText { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        public Student Student { get; set; }
    }
}
