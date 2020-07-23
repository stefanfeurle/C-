using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDriveDevelopement.Extensions
{
    public static class ArrayExtension
    {
        public static string Print(this Array arrays)
        {
            string output = string.Empty;
            if (arrays.Length == 1)
            {
                output = $"{arrays.Length} egg";
            } else
            {
                output = $"{arrays.Length} eggs";
            }
            return output;
        }
    }
}
