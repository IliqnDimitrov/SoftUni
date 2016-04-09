package com.company;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        Pattern pattern = Pattern.compile("[a-zA-Z]+");
        Matcher matcher = pattern.matcher(input);
        List<String> words = new ArrayList<>();
        while (matcher.find()){
            words.add(matcher.group(0));
        }
        Set<String> wordsa = new LinkedHashSet<>();
        boolean isFound = false;
        String aAndB = "";
        for (int a = 0; a < words.size(); a++) {
            for (int b = 0; b < words.size(); b++) {
                for (int c = 0; c < words.size(); c++) {
                    if (a != b && a != c && b != c){
                        aAndB = words.get(a) + words.get(b);
                        if (aAndB.equals(words.get(c))){
                            aAndB = words.get(a) + "|" + words.get(b) + "=" + words.get(c);
                            wordsa.add(aAndB);
                            isFound = true;
                        }
                    }
                }
            }
        }
        if (!isFound){
            System.out.println("No");
        }
        else{
            for (String entry : wordsa){
                System.out.println(entry);
            }
        }
    }
}
