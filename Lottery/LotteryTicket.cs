using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery
{
    class LotteryTicket
    {
        public string LotteryTicketNumber { get; set; }

        public void setLotteryTicketNumber(int randomNumber)
        {
            var randomString = randomNumber.ToString();
            while (randomString.Length < 6)
            {
                randomString = '0' + randomString;
            }
            LotteryTicketNumber = randomString;
        }

        internal int checkUserNumberString(string userNumberString)
        {
            var counter = 0;
            for (int i = 0; i < 6; i++)
            {
                if (userNumberString.Substring(i, 1) == (LotteryTicketNumber.Substring(i, 1))) {
                    counter++;
                }
            }
            return counter;
        }
    }
}
