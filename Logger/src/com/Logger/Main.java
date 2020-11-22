package com.Logger;

import org.apache.log4j.Logger;
import org.apache.log4j.xml.DOMConfigurator;

public class Main {

    static  final Logger logger = Logger.getLogger("Abc",Main);

    public static void main(String[] args) {
	// write your code here
       // BasicConfigurator.configure();  //it will configure default console appender
        //PropertyConfigurator.configure("log4j.properties1");
        DOMConfigurator.configure("log4j.xml");

        logger.debug("Sample debug message"); // keeps track
        logger.info("Sample info message");   // keeps track
        logger.warn("Sample warn message");   // One function/button is not working properly(still in development) so to inform users warning is used
        logger.error("Sample error message"); // To handle errors such as entering wrong password, goes into error
        logger.fatal("Sample fatal message"); // If all the users are facing the issue. these are of highest priority
    }
}
