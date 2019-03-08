using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TryItOut.CommonInterfaces;
using TryItOut.Domain;

namespace TryItOut.DataAccess
{
    public class ToDoTasksRepository : IToDoTasksRepository
    {
        public bool Delete(ToDoTask entity)
        {
            throw new NotImplementedException();
        }

        public IList<ToDoTask> GetAll()
        {
            IList<ToDoTask> ListOfToDOTasks = new List<ToDoTask>();

            ListOfToDOTasks.Add(new ToDoTask() { Identifier = 1, Description = "Feed the Cat" });
            ListOfToDOTasks.Add(new ToDoTask() { Identifier = 2, Description = "Walk the Dog" });
            ListOfToDOTasks.Add(new ToDoTask() { Identifier = 3, Description = "Bake a Cake" });
            ListOfToDOTasks.Add(new ToDoTask() { Identifier = 4, Description = "Feed the Gold fish" });
            ListOfToDOTasks.Add(new ToDoTask() { Identifier = 5, Description = "Go on Hoilday" });

            /* need to replace with reading / writing to XML file */

            return ListOfToDOTasks;
        }

        public ToDoTask Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public IList<ToDoTask> Read()
        {
            IList<ToDoTask> tasks = new List<ToDoTask>();
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/toDoTasks.xml");

            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(tasks.GetType());
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);

            tasks = (List<ToDoTask>)reader.Deserialize(file);

            file.Close();

            return tasks;
        }

        public bool Save(ToDoTask entity)
        {
            throw new NotImplementedException();
        }
    }

}
