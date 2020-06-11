using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace TestDriveDevelopement
{
    public class Breakfast
    {
        public static Coffee PourCoffee()
        {
            return new Coffee();
        }

        public static Egg[] FryEggs(int  egg)
        {
            Egg[] eggs = new Egg[egg];
            for (int i = 0; i < egg; i++)
            {
                eggs[i] = new Egg();
            }
            return eggs;
            
        }

        public static Bacon[] FryBacon(int bacon)
        {
            Bacon[] bacons = new Bacon[bacon];
            for (int i = 0; i < bacon; i++)
            {
                bacons[i] = new Bacon();
            }
            return bacons;
        }

        public static Toast[] ToastBread(int toast)
        {
            Toast[] toasts = new Toast[toast];
            for (int i = 0; i < toast; i++)
            {
                toasts[i] = new Toast();
            }
            return toasts;
        }

        public static void EatBacon(ref Bacon[] bacon, int bac)
           
        {
            var tmpArray = bacon;
            bacon = new Bacon[bacon.Length - bac];

            for(var i = 0; i < bacon.Length; i++)
            {
                bacon[i] = tmpArray[i];
            }
        }

        public static Toast ApplyJam(Toast toast)
        {
            toast.ButterApplied = false;
            toast.JamApplied = true;
            return toast;
        }

        public static Toast ApplyButter(Toast toast)
        {
            toast.ButterApplied = true;
            toast.JamApplied = false;
            return toast;           
        }
    }
}
