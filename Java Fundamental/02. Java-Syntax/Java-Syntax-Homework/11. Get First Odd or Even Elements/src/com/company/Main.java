package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        int[] numbers = new int[input.length];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }
        String[] command = console.nextLine().split(" ");
        int numbersOfElements = Integer.parseInt(command[1]);
        String oddOrEven = command[2];
        List<Integer> sequence = new ArrayList<>();
        sequence = getFirstOddOrEvenElements(numbers,numbersOfElements,oddOrEven);

        System.out.println(String.join(", ",sequence.toString()));
    }

    private static List<Integer> getFirstOddOrEvenElements(int[] numbers, int numbersOfElements, String oddOrEven) {

        List<Integer> result = new ArrayList<>();
        if (oddOrEven.equals("odd")){
            for (int i = 0; i < numbers.length; i++) {
                if (result.size() == numbersOfElements){
                    break;
                }
                if (numbers[i] % 2 != 0){
                    result.add(numbers[i]);
                }
            }
        }
        else if (oddOrEven.equals("even")){
            for (int i = 0; i < numbers.length; i++) {
                if (result.size() == numbersOfElements){
                    break;
                }
                if (numbers[i] % 2 == 0){
                    result.add(numbers[i]);
                }
            }
        }

        return result;
    }
}
