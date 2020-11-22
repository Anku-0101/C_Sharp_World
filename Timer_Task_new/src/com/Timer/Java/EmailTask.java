package com.Timer.Java;

import java.util.TimerTask;

public class EmailTask extends  TimerTask{
    @Override
    public void run() {
        System.out.println("Send emails");
    }
}
