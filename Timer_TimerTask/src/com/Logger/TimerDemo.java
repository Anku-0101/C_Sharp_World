package com.Timer.Java;

import  java.util.Date;
import java.util.Timer;
import java.util.TimerTask;

public class TimerDemo {

    /*
     * Creating timer task
     */
    public  static  void main(String[] args)
    {
        TimerTask cleanUpTimerTask = new CleanUpTimerTask();

        /*
         * Creates a new timer. The associated thread does not run as
         * a daemon
         */
        Timer timer = new Timer();

        Date scheduleDateTime = new Date(System.currentTimeMillis() + 20000);

        System.out.println("ScheduleDateTime = " + scheduleDateTime);

        /*
         * Schedules the specified task for execution at the specified
         * time. If the time is in the past, the task is scheduled for
         * immediate execution.
         *
         * Parameters :
         *
         * task - task to be scheduled.
         *
         * time - time at which task is to be executed.
         */
        timer.schedule(cleanUpTimerTask,scheduleDateTime);
        System.out.println("Timer has scheduled the ------cleanUpTimerTask----");

    }

}
