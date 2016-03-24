package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        String[] newInput = new String[input.length];
        for (int i = 0; i < input.length; i++) {
            newInput[i] = input[i].substring(0,input[i].length() - 1);
        }
        Map<String, Integer> db = new LinkedHashMap<>();
        for (int i = 0; i < newInput.length; i++) {
            if (db.containsKey(newInput[i])){
                db.put(newInput[i], db.get(newInput[i]) + 1);
            }
            else {
                db.put(newInput[i], 1);
            }
        }
        for (Map.Entry<String, Integer> entry : db.entrySet()){
            double frequency = (double)entry.getValue() / newInput.length;
            System.out.printf("%s -> %.2f", entry.getKey(), frequency * 100);
            System.out.print("%");
            System.out.println();
        }
    }
}
