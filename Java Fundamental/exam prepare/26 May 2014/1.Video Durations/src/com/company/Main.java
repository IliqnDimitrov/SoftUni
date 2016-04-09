package com.company;

import java.util.Objects;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(":");
        int sumHours = 0;
        int sumMinutes = 0;
        while (!Objects.equals(input[0], "End")){
            int hours = Integer.parseInt(input[0]);
            int minutes = Integer.parseInt(input[1]);
            sumHours += hours;
            if (sumMinutes + minutes == 60){
                sumHours++;
                sumMinutes = 0;
            }
            else if (sumMinutes + minutes > 60){
                sumHours++;
                sumMinutes = (sumMinutes + minutes) - 60;
            }
            else {
                sumMinutes += minutes;
            }
            input = console.nextLine().split(":");
        }
        System.out.printf("%d:%02d",sumHours,sumMinutes);
    }
}
