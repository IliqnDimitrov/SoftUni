package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        double a = Double.parseDouble(input[0]);
        double b = Double.parseDouble(input[1]);
        double c = Double.parseDouble(input[2]);

        double formula1 = Math.pow(((Math.pow(a,2) + Math.pow(b,2))/(Math.pow(a,2) - Math.pow(b,2))),(a + b + c)/Math.sqrt(c));
        double formula2 = Math.pow(Math.pow(a,2) + Math.pow(b,2) - Math.pow(c,3),a - b);
        double diff = ((a + b + c)/3) - ((formula1 + formula2)/2);

        System.out.printf("F1 result: %.2f;",formula1);
        System.out.printf(" F2 result: %.2f;",formula2);
        System.out.printf(" Diff: %.2f",Math.abs(diff));
    }
}
