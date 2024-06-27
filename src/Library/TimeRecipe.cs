using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public class TimeRecipe : TimerClient
    {
        private CountdownTimer countDown = new CountdownTimer();

        public void TimeOut()
        {



        }

        public void GetTimeOut(int time)
        {
            this.countDown.Register(time, this);
        }



    }
}