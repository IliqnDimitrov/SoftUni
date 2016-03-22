package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int number = Integer.parseInt(input.nextLine());
        char bukva = 'a';
        for (int i = 0; i <= number; i++) {
            for (int j = 0; j < i; j++) {
                System.out.print(bukva + " ");
                bukva++;
            }
            bukva = 'a';
            System.out.println();
        }
        for (int i = number - 1; i >= 0; i--) {
            for (int j = 0; j < i; j++) {
                System.out.print(bukva + " ");
                bukva++;
            }
            bukva = 'a';
            System.out.println();
        }

    }
}
