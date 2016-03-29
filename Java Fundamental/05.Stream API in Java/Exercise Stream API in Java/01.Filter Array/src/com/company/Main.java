package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        int result = Arrays.stream(input)
                .filter(Main::tryParse)
                .map(Integer::parseInt)
                .reduce((x, y) -> x + y)
                .get();
        System.out.println(result);
    }

    public static boolean tryParse (String str){
        try {
            Integer.parseInt(str);
            return true;
        }
        catch (Exception ex){
            return false;
        }
    }
}
