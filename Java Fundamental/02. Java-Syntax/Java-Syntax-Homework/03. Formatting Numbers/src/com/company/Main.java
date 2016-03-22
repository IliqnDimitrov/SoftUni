package com.company;

import java.math.BigInteger;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        int a = Integer.parseInt(input[0]);
        double b = Double.parseDouble(input[1]);
        double c = Double.parseDouble(input[2]);

        System.out.printf("|%-10X|%010d|%10.2f|%-10.3f|",a,new BigInteger(Integer.toBinaryString(a)),b,c);
    }
}
