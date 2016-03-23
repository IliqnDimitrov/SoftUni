package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] sequence = console.nextLine().split(" ");
        if (sequence.length == 1){
            System.out.println(sequence[0]);
        }
        else{
            for (int i = 0; i < sequence.length; i++) {
                if (i == sequence.length - 1){
                    if (sequence[i].equals(sequence[i-1])){
                        System.out.print(sequence[i] + " ");
                    }
                    else{
                        System.out.println(sequence[i]);
                    }
                }
                else if (sequence[i].equals(sequence[i+1])){
                    System.out.print(sequence[i] + " ");
                }
                else{
                    System.out.println(sequence[i]);
                }
            }
        }
    }
}
