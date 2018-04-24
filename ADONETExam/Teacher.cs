using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETExam
{
   public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Expirience { get; set; }
        public string Rank { get; set; }
        public virtual IEnumerable<Subject> Subjects { get; set; }
        public virtual IEnumerable<Group> Groups { get; set; }

    }
}
