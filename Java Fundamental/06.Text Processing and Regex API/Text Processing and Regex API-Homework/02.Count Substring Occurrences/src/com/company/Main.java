package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        char[] input = console.nextLine().toLowerCase().toCharArray();
        char[] searchWord = console.nextLine().toLowerCase().toCharArray();
        int count = 0;
        for (int i = 0; i < input.length; i++) {
            if (i == input.length - 1){
                break;
            }
            if (input[i] == searchWord[0]){
                int k = i;
                for (int j = 0; j < searchWord.length; j++) {
                    if (input[k] == searchWord[j]){
                        k++;
                    }
                    else{
                        break;
                    }
                    if (j == searchWord.length -1){
                        count++;
                    }
                }
            }
        }
        System.out.println(count);
    }
}
