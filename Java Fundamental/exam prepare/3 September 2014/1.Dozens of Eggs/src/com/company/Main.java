package com.company;

import java.util.Scanner;
import java.util.StringJoiner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int dozens = 0;
        int eggs = 0;
        int allEggs = 0;
        for (int i = 0; i < 7; i++) {
            String[] sequnce = console.nextLine().split(" ");
            String word = sequnce[1];
            int currentEggs = Integer.parseInt(sequnce[0]);
            if (word.equals("dozens")){
                dozens += currentEggs;
            }
            else{
                allEggs += currentEggs;
            }
        }
        dozens += allEggs / 12;
        eggs += allEggs % 12;
        System.out.printf("%d dozens + %d eggs",dozens,eggs);
    }
}
