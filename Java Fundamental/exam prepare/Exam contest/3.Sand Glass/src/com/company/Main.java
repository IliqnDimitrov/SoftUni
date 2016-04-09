package com.company;


import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        for (int i = 0; i < n; i++) {
            System.out.print("*");
        }
        System.out.println();
        int dots = 1;
        int asterix = n - 2;
        for (int i = 0; i < n / 2 - 1; i++) {
            for (int j = 0; j < dots; j++) {
                System.out.print(".");
            }
            for (int j = 0; j < asterix; j++) {
                System.out.print("*");
            }
            for (int j = 0; j < dots; j++) {
                System.out.print(".");
            }
            dots++;
            asterix -= 2;
            System.out.println();
        }
        dots = n / 2;
        asterix = 1;
        for (int i = 0; i < n /2; i++) {
            for (int j = 0; j < dots; j++) {
                System.out.print(".");
            }
            for (int j = 0; j < asterix; j++) {
                System.out.print("*");
            }
            for (int j = 0; j < dots; j++) {
                System.out.print(".");
            }
            dots--;
            asterix += 2;
            System.out.println();
        }
        for (int i = 0; i < n; i++) {
            System.out.print("*");
        }
    }
}
