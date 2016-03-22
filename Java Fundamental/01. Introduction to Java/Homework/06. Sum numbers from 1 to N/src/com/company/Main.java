package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner n = new Scanner(System.in);
        int input = Integer.parseInt(n.nextLine());
        int result = 0;
        for (int i = 0; i <= input; i++) {
            result += i;
        }
        System.out.println(result);
    }
}
