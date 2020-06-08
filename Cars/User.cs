using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class User
    {
        /// <summary>
        /// full name
        /// </summary>
        public string  Name { get; set; }

        public User(string name)
        {
            this.Name = name;
        }
    }
}
