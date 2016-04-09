package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        Map<String, TreeMap<String, Integer>> db = new LinkedHashMap<>();
        for (int i = 0; i < n; i++) {
            String[] input = console.nextLine().split(" ");
            String product = input[2];
            String customer = input[0];
            int amount = Integer.parseInt(input[1]);
            if (db.containsKey(product)){
                TreeMap<String, Integer> nameAmount = db.get(product);
                if (nameAmount.containsKey(customer)){
                    nameAmount.put(customer, nameAmount.get(customer) + amount);
                    db.put(product, nameAmount);
                }
                else{
                    db.put(product, db.get(product));
                    nameAmount.put(customer, amount);
                }
            }
            else{
                db.put(product, new TreeMap<>());
                TreeMap<String, Integer> nameAmount = db.get(product);
                nameAmount.put(customer, amount);
            }
        }
        int count = 0;
        for (Map.Entry<String, TreeMap<String, Integer>> product : db.entrySet()){
            System.out.printf("%s:",product.getKey());
            int size = product.getValue().size();
            for (Map.Entry<String, Integer> nameAndAmount : product.getValue().entrySet()){
                count++;
                System.out.printf(" %s %d",nameAndAmount.getKey(),nameAndAmount.getValue());
                if (count != size){
                    System.out.printf(",");
                }

            }
            count = 0;
            System.out.println();
        }
    }
}
