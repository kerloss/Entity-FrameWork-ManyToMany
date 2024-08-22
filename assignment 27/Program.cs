using assignment_26.Contexts;
using assignment_27.Entitys;

namespace assignment_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using itiDbContext itiDbContext = new itiDbContext();

            Course course = new Course()
            {
                Name = "ahmed",
                Duration = DateTime.Now,
                Description = "class course",
            };
            Course course2 = new Course()
            {
                Name = "wale",
                Duration = DateTime.Now,
                Description = "class course",
            };
            Department department = new Department()
            {
                Name = "kerloss",
                HiringDate = DateTime.Now,

            };
            Department department1 = new Department()
            {
                Name = "jooo",
                HiringDate = DateTime.Now,
            };
            Instructor instructor = new Instructor()
            {
                Name = "omar",
                Address = "haram-giza",
                Bounce = 3000,
                Hour_Rate = 2000,
                Salary = 5000,
            };
            Instructor instructor1 = new Instructor()
            {
                Name = "hassan",
                Address = "haram-giza",
                Bounce = 3000,
                Hour_Rate = 2000,
                Salary = 5000,
            };
            Student student = new Student()
            {
                Address = "giza",
                Age = 30,
                FName = "ahmed",
                LName = "mohamed",
            };
            Student student1 = new Student()
            {
                Address = "october",
                Age = 20,
                FName = "youssif",
                LName = "wazir",
            };

            itiDbContext.Dispose();
        }
    }
}
