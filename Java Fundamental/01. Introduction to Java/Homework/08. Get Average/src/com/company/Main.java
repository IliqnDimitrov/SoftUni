package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        float a = Float.parseFloat(in.nextLine());
        float b = Float.parseFloat(in.nextLine());
        float c = Float.parseFloat(in.nextLine());

        getAverage(a, b, c);
    }

    private static void getAverage(float a, float b, float c) {
        double result = (a + b + c)/3;
        System.out.printf("%.2f",result);
    }
}
