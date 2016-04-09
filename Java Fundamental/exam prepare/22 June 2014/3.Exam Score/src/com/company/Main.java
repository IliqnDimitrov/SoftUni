package com.company;

import java.util.Map;
import java.util.Objects;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String doNothing = console.nextLine();
        String fuckThis = console.nextLine();
        String shit = console.nextLine();
        String input =console.nextLine();
        Pattern pattern = Pattern.compile("([a-zA-Z]+)\\s([a-zA-Z]+)\\s+[\\|]\\s+(\\d+)\\s+[\\|]\\s+(\\d+[.]\\d+)");
        Map<Integer, TreeMap<String, Double>> db = new TreeMap<>();
        while (!input.equals("--------------------------------------------") && !input.equals("----------------------------------------")){
            Matcher matcher = pattern.matcher(input);
            matcher.find();
            String name = matcher.group(1) + " " + matcher.group(2);
            int score = Integer.parseInt(matcher.group(3));
            double grade = Double.parseDouble(matcher.group(4));
            if (db.containsKey(score)){
                TreeMap<String, Double> nameGrade = db.get(score);
                nameGrade.put(name,grade);
            }
            else{
                db.put(score, new TreeMap<>());
                TreeMap<String, Double> nameGrade = db.get(score);
                nameGrade.put(name, grade);
            }

            input = console.nextLine();
        }
        double sum = 0.0;
        int count = 0;
        for (Map.Entry<Integer, TreeMap<String, Double>> entry : db.entrySet()){
            System.out.printf("%d -> [", entry.getKey());
            for (Map.Entry<String, Double> nameGrade : entry.getValue().entrySet()){
                count++;
                System.out.printf("%s",nameGrade.getKey());
                if (count != entry.getValue().size()){
                    System.out.printf(", ");
                }
                sum += nameGrade.getValue();
            }
            System.out.printf("]; avg=%.2f", sum/ entry.getValue().size());
            System.out.println();
            sum = 0.0;
            count = 0;
        }
    }
}
