using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class UserInput
    {
        public User User { get; set; }
        public Car Car { get; set; }

        public UserInput(User user, Car car)
        {
            User = user;
            Car = car;
        }
    }
}
