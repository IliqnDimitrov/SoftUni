package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        Pattern pattern = Pattern.compile("\\d+");
        Matcher matcher = pattern.matcher(input);
        List<Integer> numbers = new ArrayList<>();
        while (matcher.find()){
            numbers.add(Integer.parseInt(matcher.group(0)));
        }
        List<Integer> rectangle = new ArrayList<>();
        for (int i = 0; i < numbers.size(); i = i + 2) {
            rectangle.add(numbers.get(i) * numbers.get(i + 1));
        }
        int maxArea = Integer.MIN_VALUE;
        int currentArea = 0;
        for (int i = 0; i < rectangle.size() - 2; i++) {
            currentArea = rectangle.get(i) + rectangle.get(i + 1) + rectangle.get(i + 2);
            if (currentArea > maxArea){
                maxArea = currentArea;
            }
        }
        System.out.println(maxArea);
    }
}
