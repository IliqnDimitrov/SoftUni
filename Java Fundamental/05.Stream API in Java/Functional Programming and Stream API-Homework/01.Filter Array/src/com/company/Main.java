package com.company;

import java.util.Arrays;
import java.util.Scanner;
import java.util.stream.Collector;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        String[] result = Arrays.stream(input)
                .filter(str -> str.length() > 3)
                .toArray(i -> new String[i]);
        if (result.length == 0){
            System.out.println("(empty)");
        }
        else{
            System.out.println(String.join(" ",result));
        }
    }
}
