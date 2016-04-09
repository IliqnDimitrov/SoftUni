package com.company;

import java.util.Objects;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        int allBeers = 0;
        int allStacks = 0;
        while (!Objects.equals(input[0], "End")){
            if (Objects.equals(input[1], "stacks")){
                allStacks += Integer.parseInt(input[0]);
            }
            else if (Objects.equals(input[1], "beers")){
                int currentBeers = Integer.parseInt(input[0]);
                if (currentBeers + allBeers > 19){
                    allStacks += (currentBeers + allBeers) / 20;
                    allBeers = (currentBeers + allBeers) % 20;
                }
                else {
                    allBeers += currentBeers;
                }
            }
            input = console.nextLine().split(" ");
        }
        System.out.printf("%d stacks + %d beers",allStacks,allBeers);
    }
}
