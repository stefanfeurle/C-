using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cars
{
    enum CarType
    {
        [Description("Normal")]
        NORMAL,
        SPORTS            
    }
}
