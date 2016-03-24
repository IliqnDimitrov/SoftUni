package com.company;

import java.util.*;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        Map<String,Integer> nameDuration = new TreeMap<>();
        Map<String,Set<String>> nameIp = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] input = console.nextLine().split(" ");
            String name = input[1];
            String Ip = input[0];
            int duration = Integer.parseInt(input[2]);
            if (nameDuration.containsKey(name)){
                nameDuration.put(name, nameDuration.get(name) + duration);
                Set<String> ips = nameIp.get(name);
                ips.add(Ip);
            }
            else{
                nameDuration.put(name, duration);
                nameIp.put(name,new TreeSet<>());
                Set<String> ips = nameIp.get(name);
                ips.add(Ip);
            }
        }
        for (Map.Entry<String, Integer> entry : nameDuration.entrySet()){
            System.out.printf("%s: %d [%s]",entry.getKey(),entry.getValue(),String.join(", ",nameIp.get(entry.getKey())));
            System.out.println();
        }
    }
}
