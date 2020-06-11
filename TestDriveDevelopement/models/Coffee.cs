using System;
using System.Collections.Generic;
using System.Text;

namespace TestDriveDevelopement
{
    public class Coffee
    {
        private string temperature = string.Empty;
        public string Temperature
        {
            get
            {
                if (temperature == string.Empty)
                {
                    temperature = "Hot";
                }
                else if (temperature == "Hot")
                {
                    temperature = "Quite hot";
                }
                else if (temperature == "Quite hot")
                {
                    temperature = "Not so hot";
                }
                else if (temperature == "Not so hot")
                {
                    temperature = "Cold";
                }
                return temperature;
            }
            //set
            //{
            //    temperature = value;
            //}
        }

        public override string ToString()
        {
            return "Kaffee";
        }
    }
}
