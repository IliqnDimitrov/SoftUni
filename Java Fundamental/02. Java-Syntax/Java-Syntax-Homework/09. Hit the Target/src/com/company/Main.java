package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());

        for (int i = 1; i <= 20; i++) {
            if (i < n && n - i <= 20){
                System.out.printf("%d + %d = %d", i, n - i, n);
                System.out.println();
            }
            else if (i > n){
                System.out.printf("%d - %d = %d", i, i - n, n);
                System.out.println();
            }
        }
    }
}
