﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETExam
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public DateTime BeginLesson { get; set; }
        public DateTime EndLesson { get; set; }

        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
        [ForeignKey("Teacher")]
        public int TeachertId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
