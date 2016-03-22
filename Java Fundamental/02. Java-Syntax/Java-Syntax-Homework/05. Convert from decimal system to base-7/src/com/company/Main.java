package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int decimal = Integer.parseInt(console.nextLine());
        StringBuilder base7 = new StringBuilder();
        while (decimal != 0){
            base7.append(decimal % 7);
            decimal /= 7;
        }
        System.out.println(base7.reverse());
    }
}
