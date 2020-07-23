using System;
using System.Collections.Generic;
using ToDoAppData;

namespace ToDoAppLogic
{
    public class ToDoController
    {
        public ToDoDatabaseEntities getList()
        {
            ToDoDatabaseEntities entities = new ToDoDatabaseEntities();
            return entities;
        }
    }
}
