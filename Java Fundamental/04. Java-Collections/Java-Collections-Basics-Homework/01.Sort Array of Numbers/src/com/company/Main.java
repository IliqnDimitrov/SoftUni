package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int[] number = new int[n];
        for (int i = 0; i < number.length; i++) {
            number[i] = console.nextInt();
        }
        console.nextLine();
        Arrays.sort(number);
        for (int item : number) {
            System.out.printf("%d ",item);
        }

    }
}
