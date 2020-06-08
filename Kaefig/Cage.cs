using System;
using System.Collections.Generic;
using System.Text;

namespace Kaefig
{
    class Cage <T>
    {
        List<T> cage = new List<T>();

        public void addAnimal(T animal)
        {
            cage.Add(animal);
        }

        public void removeAnimal(T animal)
        {
            cage.Remove(animal); 
        } 

        public List<T> getListT()
        {
            return cage;
        }        
    }
}
