namespace ADONETExam
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SchoolContext : DbContext
    {
        // Контекст настроен для использования строки подключения "SchoolContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ADONETExam.SchoolContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "SchoolContext" 
        // в файле конфигурации приложения.
        public SchoolContext()
            : base("name=SchoolContext")
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group>Groups  { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}