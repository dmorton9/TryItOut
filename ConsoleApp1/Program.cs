using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.DataAccess;
using TryItOut.Domain;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<ToDoTasksEFContext>());
            //InsertToDoTask();

            ReadandUpdateToDoTask();
        }

        private static void InsertToDoTask()
        {
            var toDoTask_A = new ToDoTask
            {
                Description = "Task_A",
                CreatedOn = DateTime.Now,
                RequiredBy = DateTime.Now,
                CompletedOn = DateTime.Now
            };

            var toDoTask_B = new ToDoTask
            {
                Description = "Task_B",
                CreatedOn = DateTime.Now,
                RequiredBy = DateTime.Now,
                CompletedOn = DateTime.Now
            };

            using (var context = new ToDoTasksEFContext() )
            {
                context.Database.Log = Console.WriteLine;

                context.ToDoTasksEF.AddRange(new List<ToDoTask> { toDoTask_A, toDoTask_B });
                context.SaveChanges();
            }

        }

        private static void ReadToDoTask()
        {

            using (var context = new ToDoTasksEFContext())
            {
                context.Database.Log = Console.WriteLine;

                //var tasks = context.ToDoTasksEF.ToList();

                var task = context.ToDoTasksEF.Where(x => x.Identifier == 5);
            }

        }

        private static void ReadandUpdateToDoTask() {

            using (var context = new ToDoTasksEFContext())
            {
                context.Database.Log = Console.WriteLine;

                ToDoTask task = context.ToDoTasksEF.FirstOrDefault();

                task.CompletedOn = DateTime.Now;

                context.SaveChanges();
            }

        }
    }
}
