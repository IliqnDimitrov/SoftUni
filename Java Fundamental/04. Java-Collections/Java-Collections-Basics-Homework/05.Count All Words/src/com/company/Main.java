package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] sequence = console.nextLine().split("\\W+");
        System.out.println(sequence.length);
    }
}
