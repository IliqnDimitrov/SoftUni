package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine().trim();
        Pattern pattern = Pattern.compile("\\s(\\S+@\\S+)(?=\\.|\\s)");
        Matcher match = pattern.matcher(input);
        while (match.find()){
            System.out.println(match.group(1));
        }
    }
}
