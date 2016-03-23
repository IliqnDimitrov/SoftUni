package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split("\\W+");
        Map<String, Integer> db = new TreeMap<>();
        int maxCount = 0;
        for (int i = 0; i < input.length; i++) {
            if (db.containsKey(input[i].toLowerCase())){
                db.put(input[i].toLowerCase(), db.get(input[i].toLowerCase()) + 1);
                if (db.get(input[i].toLowerCase()) > maxCount){
                    maxCount = db.get(input[i].toLowerCase());
                }
            }
            else{
                db.put(input[i].toLowerCase(), 1);
            }
        }
        for (Map.Entry<String, Integer> entry : db.entrySet()){
            if (entry.getValue() == maxCount){
                System.out.printf("%s -> %d times",entry.getKey(),entry.getValue());
                System.out.println();
            }
        }
    }
}
