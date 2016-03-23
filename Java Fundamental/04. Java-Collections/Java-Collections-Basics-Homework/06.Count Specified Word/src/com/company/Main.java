package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] sequnce = console.nextLine().split("\\W+");
        String searchWord = console.nextLine();
        int count = 0;
        for (int i = 0; i < sequnce.length; i++) {
            if (sequnce[i].toLowerCase().equals(searchWord)){
                count++;
            }
        }
        System.out.println(count);
    }
}
