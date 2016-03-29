package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        List<Integer> input2 = Arrays.stream(input)
                .map(i -> Integer.parseInt(i))
                .collect(Collectors.toList());
        String command = console.nextLine();
        List<Integer> result = new ArrayList<>();
        if (command.equals("Ascending")){
            result = input2.stream()
                    .sorted()
                    .collect(Collectors.toList());
        }
        else if (command.equals("Descending")){
            result = input2.stream()
                    .sorted((x1, x2) -> x2.compareTo(x1))
                    .collect(Collectors.toList());

        }
        result.forEach(integer -> System.out.printf("%d ",integer));
    }
}
