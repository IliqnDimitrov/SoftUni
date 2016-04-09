package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        int[] number = new int[input.length];
        for (int i = 0; i < number.length; i++) {
            number[i] = Integer.parseInt(input[i]);
        }
        Map<String, Integer> db = new LinkedHashMap<>();
        String couples = "";
        for (int i = 0; i < number.length - 1; i++) {
            couples = number[i] + " " + number[i + 1];
            if (db.containsKey(couples)){
                db.put(couples, db.get(couples) + 1);
            }
            else {
                db.put(couples, 1);
            }
        }
        for (Map.Entry<String, Integer> entry : db.entrySet()) {
            System.out.printf("%s -> %.2f", entry.getKey(), ((float)entry.getValue() / (number.length - 1)) * 100);
            System.out.println("%");
        }
    }
}
