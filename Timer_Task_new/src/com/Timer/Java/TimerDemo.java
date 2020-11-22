package com.Timer.Java;

import  java.util.Date;
import java.util.Timer;
import java.util.TimerTask;

public class TimerDemo {

    /*
     * Creating timer task
     */
    public  static  void main(String[] args) throws InterruptedException {
        TimerTask cleanUpTimerTask = new CleanUpTimerTask();
        TimerTask emailTask = new EmailTask();
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

        timer.schedule(emailTask, 3000,1000);

        Thread.sleep(6000);


        System.out.println("canceled");

        System.out.println(timer.purge());
        //timer.schedule(emailTask, 3000,1000);
        //timer.cancel(); // Cancels the task
    }

}