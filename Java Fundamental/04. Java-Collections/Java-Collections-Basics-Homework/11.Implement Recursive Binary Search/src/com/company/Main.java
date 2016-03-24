package com.company;

import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        Integer searchedN = Integer.parseInt(console.nextLine());
        String[] input = console.nextLine().split(" ");
        int[] newInput = new int[input.length];
        for (int i = 0; i < input.length; i++) {
            newInput[i] = Integer.parseInt(input[i]);
        }

        List<Integer> resizeable = new LinkedList<>();
        for (int i = 0; i < newInput.length; i++) {
            resizeable.add(newInput[i]);
        }

        int resultIndex = 0;
        resultIndex = customBinarySearch(newInput, resultIndex, searchedN, resizeable);
        System.out.println(resultIndex);
    }

    private static int customBinarySearch(int[] input, int resultIndex ,int searchedN, List<Integer> resizeable) {
        int currentIndex = 0;
        if (resizeable.size() % 2 == 0) {
            currentIndex = resizeable.size() / 2;
            currentIndex--;
        }
        else {
            currentIndex = resizeable.size() / 2 + 1;
            currentIndex--;
        }
        if (input[resultIndex] != searchedN){
            if (resizeable.size() == 0){
                return -1;
            }
            if (input[currentIndex] < searchedN){
                resizeable.clear();
                if (currentIndex == 0){
                    currentIndex = 1;
                }
                resultIndex += currentIndex;
                for (int i = resultIndex + 1; i < input.length; i++) {
                    resizeable.add(input[i]);
                }
            }
            else if(input[currentIndex] > searchedN){
                resizeable.clear();
                if (currentIndex == 0){
                    currentIndex = 1;
                }
                resultIndex -= currentIndex;
                for (int i = 0; i <= resultIndex + 1; i++) {
                    resizeable.add(input[i]);
                }
            }
            resultIndex = customBinarySearch(input, resultIndex, searchedN, resizeable);
        }
        return resultIndex;
    }
}
