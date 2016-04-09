package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int count = Integer.parseInt(console.nextLine());
        String[] sequnce = console.nextLine().split(" ");
        int sumDegrees = 0;
        boolean isTrue = false;
        for (int first = 0; first < count - 2; first++) {
            int firstElement = Integer.parseInt(sequnce[first]);
            for (int second = first + 1; second < count; second++) {
                int secondElement = Integer.parseInt(sequnce[second]);
                for (int third = second + 1; third < count; third++) {
                    int thirdElement = Integer.parseInt(sequnce[third]);
                    if ((firstElement + secondElement + thirdElement) % 360 == 0){
                        isTrue = true;
                        System.out.printf("%d + %d + %d = %d degrees",firstElement, secondElement, thirdElement,
                                firstElement + secondElement + thirdElement);
                        System.out.println();
                    }
                }
            }
        }
        if (!isTrue){
            System.out.println("No");
        }
    }
}
