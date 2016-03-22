package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        int[] numbers = new int[input.length];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }

        if (input.length % 2 == 0){
            for (int i = 0; i < numbers.length; i++) {
                if (numbers[i] % 2 == 0 && numbers[i + 1] % 2 == 0){
                    System.out.printf("%d, %d -> both are even",numbers[i],numbers[i + 1]);
                    System.out.println();
                    i++;
                }
                else if (numbers[i] % 2 != 0 && numbers[i + 1] % 2 != 0){
                    System.out.printf("%d, %d -> both are odd",numbers[i],numbers[i + 1]);
                    System.out.println();
                    i++;
                }
                else{
                    System.out.printf("%d, %d -> different",numbers[i],numbers[i + 1]);
                    System.out.println();
                    i++;
                }
            }
        }
        else {
            System.out.println("Invalid length");
        }
    }
}
