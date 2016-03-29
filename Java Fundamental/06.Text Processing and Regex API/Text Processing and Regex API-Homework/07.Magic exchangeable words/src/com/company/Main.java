package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        String firstWord = input[0];
        String secondWord = input[1];
        boolean isExchangeable = true;
        String word = "";
        List<String> list = new ArrayList<>();
        for (int i = 0; i < firstWord.length(); i++) {
            word += firstWord.charAt(i);
            word += secondWord.charAt(i);
            if (!list.contains(word)){
                for (int j = 0; j < list.size(); j++) {
                    if (list.get(j).charAt(0) == firstWord.charAt(i) &&
                            list.get(j).charAt(1) != secondWord.charAt(i)){
                        isExchangeable = false;
                    }
                    else if (list.get(j).charAt(0) != firstWord.charAt(i) &&
                            list.get(j).charAt(1) == secondWord.charAt(i)){
                        isExchangeable = false;
                    }
                }
                list.add(word);
            }
            word = "";
        }
        System.out.println(isExchangeable);
    }
}
