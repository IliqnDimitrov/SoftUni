package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int sum = 1;
        int result = calculateFactorial(n, sum);
        System.out.println(result);
    }

    private static int calculateFactorial(int n, int sum) {
        if (n == 0){
            return sum;
        }
        sum *= n;
        return sum = calculateFactorial(n - 1, sum);
    }
}
