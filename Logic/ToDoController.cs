using System;
using System.Collections.Generic;
using System.Linq;
using ToDoAppData;

namespace ToDoAppLogic
{
    public class ToDoController
    {
        ToDoDatabaseEntities entities = new ToDoDatabaseEntities();

        public List<ToDoList> getList()
        {
            var dateTo = DateTime.Now.AddHours(1);
            return entities.ToDoList.Where(x => x.dateTime <= dateTo && x.hasDoneTask == 0).ToList();
        }

        public string NewTask(ToDoList todo)
        {
            string output = null;
            if (todo.dateTime > DateTime.Now)
            {
                if (!String.IsNullOrEmpty(todo.task))
                {
                    entities.ToDoList.Add(todo);
                    entities.SaveChanges();
                    output = "Neue Todo erfolgreich erstellt!";
                }
                else
                {
                    output = "Bitte eine korrekte Tätigkeit eingeben!";
                }
            }
            else
            {
                output = "Die eingegebene Zeit ist schon vorbei!";
            }
            return output;
        }

        public void saveDoneTask(ToDoList todo)
        {
            todo.hasDoneTask = 1;
            entities.SaveChanges();
        }
    }
}
