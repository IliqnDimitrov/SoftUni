package com.company;

import java.util.*;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        Map<Integer,LinkedHashMap<String,Integer>> db = new LinkedHashMap<>();
        for (int i = 0; i < n; i++) {
            String[] input = console.nextLine().split(" ");
            int mounth = Integer.parseInt(input[0].substring(3,5));
            String name = input[1];
            int distance = Integer.parseInt(input[2]);
            if (db.containsKey(mounth)){
                LinkedHashMap<String,Integer> nameDistance = db.get(mounth);
                if (nameDistance.containsKey(name)){
                    int sumDistance = nameDistance.get(name) + distance;
                    nameDistance.put(name, sumDistance);
                }
                else {
                    nameDistance.put(name, distance);
                }
            }
            else {
                db.put(mounth,new LinkedHashMap<>());
                LinkedHashMap<String,Integer> nameDistance = db.get(mounth);
                nameDistance.put(name, distance);
            }
        }
        Map<Integer,LinkedHashMap<String,Integer>> sortedDb = db.entrySet().stream().sorted((x1, x2) -> x1.getKey().compareTo(x2.getKey()))
                .collect(Collectors.toMap(Map.Entry::getKey, Map.Entry::getValue,
                        (e1, e2) -> e1, LinkedHashMap::new));

        for (Map.Entry<Integer, LinkedHashMap<String, Integer>> mounths : sortedDb.entrySet()){
            System.out.printf("%d: ",mounths.getKey());
            LinkedHashMap<String,Integer> nameDistance = mounths.getValue();
            LinkedHashMap<String,Integer> sortedNameDistance = nameDistance.entrySet().stream().sorted((x1,x2) -> x1.getKey().compareTo(x2.getKey()))
                    .collect(Collectors.toMap(Map.Entry::getKey , Map.Entry::getValue, (a,b) -> a, LinkedHashMap::new));
            int size = nameDistance.size();
            int count = 0;
            for (Map.Entry<String,Integer> nameDistances : sortedNameDistance.entrySet()){
                if (count == size - 1){
                    System.out.printf("%s(%d)",nameDistances.getKey(), nameDistances.getValue());
                }
                else {
                    System.out.printf("%s(%d)",nameDistances.getKey(), nameDistances.getValue());
                    System.out.print(", ");
                }
                count++;
            }
            System.out.println();
        }
    }
}
