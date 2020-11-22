package com.company;

import java.util.Map;

public class Main {

    public static int split(final String aString, final String[] tokens, final char delim) {

        final int maxTokens = tokens.length;
        int nTokens = 0;
        int start = 0;
        int end = aString.indexOf(delim);
        if(end < 0) {
            tokens[nTokens++] = aString;
            return nTokens;
        }
        while ((end > 0) && (nTokens < maxTokens))
        {
            tokens[nTokens++] = aString.substring(start, end);
            start = end + 1;
            end = aString.indexOf(delim, start);

        }
        // Add the trailing string,  if there is room and if it is not empty.
        if (nTokens < maxTokens)
        {
            final String trailingString = aString.substring(start);
            if (trailingString.length() > 0)
            {
                tokens[nTokens++] = trailingString;
            }
        }
        return nTokens;
    }

    public static int splitConcatenateExcessTokens(final String aString, final String[] tokens, final char delim) {

        final int maxTokens = tokens.length;
        int nTokens = 0;
        int start = 0;
        int end = aString.indexOf(delim);
        if(end < 0) {
            tokens[nTokens++] = aString;
            return nTokens;
        }
        while ((end > 0) && (nTokens < maxTokens - 1))
        {
            tokens[nTokens++] = aString.substring(start, end);
            start = end + 1;
            end = aString.indexOf(delim, start);

        }
        // Add the trailing string,  if it is not empty.
        final String trailingString = aString.substring(start);
        if (trailingString.length() > 0)
        {
            tokens[nTokens++] = trailingString;
        }
        return nTokens;
    }


    public static void main(String[] args) {

        /*
        String sIn = "This is a test string used for splitting";
        String[] tokensExpected = { "Th", "s", "s a test str", "ng used for spl", "tt", "ng" };
        String[] tokensActual = new String[6];
        char delim = 'i';
        int n = split(sIn, tokensActual, delim);

        for(int i =0 ; i< tokensActual.length; i++)
        {
            System.out.println(tokensActual[i]);
        }

        System.out.println(n);
        */


        String sIn = "This is a test string used for splitting";
        char delim = 'i';

        String[] tokensExpected1 = { "Thi", "s i", "s a test stri", "ng used for splitting" };
        String[] tokensActual1 = new String[4];
        splitConcatenateExcessTokens(sIn, tokensActual1, delim);

        for(int i =0 ; i< tokensActual1.length; i++)
        {
            System.out.println(tokensActual1[i]);
        }


    }
}
