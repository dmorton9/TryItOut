using System;
using System.Collections.Generic;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;
using TryItOut.Domain;

namespace TryItOut.Service
{
    public class ToDoTasksService : IToDoTasksService
    {
        IToDoTasksRepository repository = null;

        public ToDoTasksService() {

            /* default repository */
            repository = new ToDoTasksRepository();
        }

        public ToDoTasksService(IToDoTasksRepository repository) {

            this.repository = repository;
        }

        public ToDoTasksListDTO Read()
        {
            ToDoTasksListDTO tasksDTO = new ToDoTasksListDTO();

            /* read all tasks from XML file and map to a DTO */
            foreach(ToDoTask task in ReadALL())
            {
                tasksDTO.NumberOf++;
                tasksDTO.ToDoTasksList.Add(new ToDoTaskDTO() {
                    Identifier = task.Identifier,
                    Description = task.Description
                });
            }

            tasksDTO.IsValid = true;

            return tasksDTO;
        }

        public void Save(string description, DateTime requiredBy) {

            /* use repo saves new task and report success failure */

            /* possible loads into dto new data set of tasks */
        }

        private IList<ToDoTask> ReadALL() {

            return repository.Read();
        }
    }
}
