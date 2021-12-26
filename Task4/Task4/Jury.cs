using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Jury
    {
        public static int DeterminingWinner(int sysytemMove, int userMove,int maxLeng)
        {
            if (sysytemMove == userMove)
                return 0;
            int distanceUserToSyst, distanceSystToUser;
            if (sysytemMove > userMove)
            {
                distanceUserToSyst = sysytemMove - userMove-1;
                distanceSystToUser = maxLeng - sysytemMove + userMove-1;
                if (distanceUserToSyst < distanceSystToUser)
                    return 1;
                else
                    return -1;
            }
            else
            {
                distanceUserToSyst = maxLeng - userMove + sysytemMove-1;
                distanceSystToUser = userMove - sysytemMove-1;
                if (distanceUserToSyst < distanceSystToUser)
                    return 1;
                else
                    return -1;
            }
        }
    }
}
