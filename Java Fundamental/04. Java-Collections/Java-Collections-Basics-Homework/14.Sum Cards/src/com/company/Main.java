package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        String[] newInput = new String[input.length];
        for (int i = 0; i < input.length; i++) {
            newInput[i] = input[i].substring(0, input[i].length() - 1);
        }
        int sum = 0;
        String element;
        for (int i = 0; i < newInput.length; i++) {
            if (i == newInput.length - 1){
                sum += getValueOfCard(newInput[i]);
            }
            else if (newInput[i].equals(newInput[i + 1])){
                element = newInput[i];
                for (int j = i; j < newInput.length; j++) {
                    if (!newInput[j].equals(element)){
                        i = j - 1;
                        break;
                    }
                    sum += getValueOfCard(newInput[i]) * 2;
                    if (j == newInput.length - 1){
                        i = j;
                    }
                }
            }
            else{
                sum += getValueOfCard(newInput[i]);
            }
        }
        System.out.println(sum);

    }

    private static int getValueOfCard(String s){
        int value = 0;
        switch (s){
            case "2":
                value = 2;
                break;
            case "3":
                value = 3;
                break;
            case "4":
                value = 4;
                break;
            case "5":
                value = 5;
                break;
            case "6":
                value = 6;
                break;
            case "7":
                value = 7;
                break;
            case "8":
                value = 8;
                break;
            case "9":
                value = 9;
                break;
            case "10":
                value = 10;
                break;
            case "J":
                value = 12;
                break;
            case "Q":
                value = 13;
                break;
            case "K":
                value = 14;
                break;
            case "A":
                value = 15;
                break;
        }
        return value;
    }
}
