package com.company;

import java.util.*;
import java.util.concurrent.ThreadLocalRandom;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        java.util.List<Integer> numbers = new ArrayList<>();
        int N = Integer.parseInt(input[0]);
        int M = Integer.parseInt(input[1]);
        int start = 0;
        int end = 0;
        int count = 1;
        if (N > M){
            count += N - M;
            start = M;
            end = N;
        }
        else{
            count += M - N;
            start = N;
            end = M;
        }

        for (int i = 0; i < count; i++) {
            int currentNumber = ThreadLocalRandom.current().nextInt(start, end + 1);
            if (numbers.contains(currentNumber)){
                i--;
                continue;
            }
            numbers.add(currentNumber);
            System.out.print(currentNumber + " ");
        }
    }
}
