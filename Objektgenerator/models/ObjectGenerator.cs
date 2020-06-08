using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;


namespace Objektgenerator.models
{
    class ObjectGenerator <T> 
    {
        public T GetNewObject<T> () where T : new()
        {
            return new T();
        }

        public List<T> GetNewObjects<T>(int amountOfObjects) where T : new()
        {
            List<T> objects = new List<T>();
            for (int i = 0; i < amountOfObjects; i++)
            {
                objects.Add(new T()); 
            }
            return objects;
        }

        public T GetObject(params object[] args) 
        {
            
             return (T)Activator.CreateInstance(typeof(T), args);
        }
    }
}
