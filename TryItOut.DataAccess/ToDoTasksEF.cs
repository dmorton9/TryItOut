using System.Data.Entity;
using TryItOut.Domain;
using TryItOut.Domain.Interfaces;

namespace TryItOut.DataAccess
{
    public class ToDoTasksEFContext : DbContext
    {
        public DbSet<ToDoTask> ToDoTasksEF { get; set; }
    }
}
