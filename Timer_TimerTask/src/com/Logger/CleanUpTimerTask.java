package com.Timer.Java;

import java.util.TimerTask;

public class CleanUpTimerTask extends TimerTask {
    @Override
    public void run() {
        System.out.println("Clean Up files ...");
    }
}
