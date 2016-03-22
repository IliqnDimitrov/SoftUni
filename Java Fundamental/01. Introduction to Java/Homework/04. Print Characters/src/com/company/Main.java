package com.company;

import java.text.MessageFormat;

public class Main {

    public static void main(String[] args) {
        for (int i = 'a'; i <= 'z'; i++) {
            System.out.print(MessageFormat.format("{0} ",(char)i));
        }
    }
}
