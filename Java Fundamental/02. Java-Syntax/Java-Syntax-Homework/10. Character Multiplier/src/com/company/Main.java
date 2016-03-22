package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");

        int totalSum = characterMultiplier(input[0],input[1]);
        System.out.println(totalSum);
    }

    private static int characterMultiplier(String s, String s1) {
        int multuply = 0;
        int totalSum = 0;
        String maxLeight = "";
        if (s.length() > s1.length()){
            maxLeight = s;
        }
        else if (s.length() < s1.length()){
            maxLeight = s1;
        }
        else{
            maxLeight = s;
        }
        for (int i = 0; i < maxLeight.length(); i++) {
            try{
                multuply = s.charAt(i) * s1.charAt(i);
                totalSum += multuply;
            }
            catch (IndexOutOfBoundsException ex){
                multuply = maxLeight.charAt(i);
                totalSum += multuply;
            }

        }
        return totalSum;
    }
}
