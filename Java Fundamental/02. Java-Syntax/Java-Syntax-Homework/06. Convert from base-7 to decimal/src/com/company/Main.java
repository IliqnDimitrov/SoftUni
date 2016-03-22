package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String base7 = console.nextLine();
        int decimal = 0;
        int count = 0;
        for (int i = base7.length() - 1; i >= 0; i--) {
            decimal += (Integer.parseInt(String.valueOf(base7.charAt(i))) * Math.pow(7,count));
            count++;
        }
        System.out.println(decimal);
    }
}
