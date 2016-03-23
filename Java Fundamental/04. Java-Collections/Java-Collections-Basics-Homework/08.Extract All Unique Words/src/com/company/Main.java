package com.company;

import java.util.Collections;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] sequence = console.nextLine().split("\\W+");
        Set<String> result = new TreeSet<>();
        for (int i = 0; i < sequence.length; i++) {
            result.add(sequence[i].toLowerCase());
        }
        for (String item : result){
            System.out.print(item + " ");
        }
    }
}
