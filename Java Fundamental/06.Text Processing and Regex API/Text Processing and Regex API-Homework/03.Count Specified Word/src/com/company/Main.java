package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine().toLowerCase();
        String serachedWord = console.nextLine();
        String pt = "\\b" + serachedWord + "\\b";
        Pattern pattern = Pattern.compile(pt);
        Matcher matcher = pattern.matcher(input);
        int count = 0;
        while (matcher.find()){
            count++;
        }
        System.out.println(count);
    }
}
