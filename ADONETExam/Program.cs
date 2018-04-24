using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETExam
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext context = new SchoolContext())
            {
                //context.Groups.ToList();
                //Group group = new Group { Id = 1, Year = 2, Name = "SDP 171" };
                //Subject subject = new Subject { Id = 1, Name = "C#" };
                //Student student = new Student { Id = 1, SurName = "Bensov", AverageMark = 11, GroupId = 1, Group = group, Name = "Lanse" };
                //Teacher teacher = new Teacher { SurName = "Bulanov", Rank = "Magistr", Name = "Egor", Id = 1, Expirience = 4 };
                //Schedule schedule = new Schedule { BeginLesson = DateTime.Now, EndLesson = DateTime.Now.AddHours(3), Subject = subject, SubjectId = subject.Id, Group = group, GroupId = group.Id, Id = 1, Teacher = teacher, TeachertId = teacher.Id };


                var result = from r in context.Schedules
                             join sub in context.Subjects on r.SubjectId equals sub.Id
                             join g in context.Groups on r.SubjectId equals g.Id
                             join t in context.Teachers on r.TeachertId equals t.Id
                             select new { TimeFrom = r.BeginLesson, TimeEnd = r.EndLesson, Subject = sub.Name, Group = g.Name, Teacher = t.Name };

                //context.Groups.Add(group);
                //context.Subjects.Add(subject);
                //context.Students.Add(student);
                //context.Teachers.Add(teacher);
                //context.Schedules.Add(schedule);
                //context.SaveChanges();
            }
        }
    }
}
