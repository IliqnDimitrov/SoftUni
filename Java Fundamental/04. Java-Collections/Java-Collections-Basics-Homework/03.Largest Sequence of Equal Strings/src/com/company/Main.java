package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] sequence = console.nextLine().split(" ");
        Map<String, Integer> db = new LinkedHashMap<>();
        for (int i = 0; i < sequence.length; i++) {
            if (db.containsKey(sequence[i])){
                db.put(sequence[i], db.get(sequence[i]) + 1);
            }
            else{
                db.put(sequence[i], 1);
            }
        }
        int count = 0;
        int maxCount = 0;
        String value = "";
        for (Map.Entry<String, Integer> entry : db.entrySet()){
            count = entry.getValue();
            if (count > maxCount){
                maxCount = count;
                value = entry.getKey();
            }
        }
        for (int i = 0; i < maxCount; i++) {
            System.out.print(value + " ");
        }
    }
}
