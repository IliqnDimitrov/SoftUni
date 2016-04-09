package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int count = Integer.parseInt(console.nextLine());
        int n = 0;
        List<Integer> number = new ArrayList<>();
        for (int i = 0; i < count; i++) {
            n = Integer.parseInt(console.nextLine());
            number.add(n);
        }
        boolean isAnyPythagor = false;
        for (int a = 0; a < number.size(); a++) {
            for (int b = 0; b < number.size(); b++) {
                for (int c = 0; c < number.size(); c++) {
                    if (number.get(a) <= number.get(b)){
                        if (Math.pow(number.get(a), 2) + Math.pow(number.get(b), 2) == Math.pow(number.get(c), 2)){
                            System.out.printf("%d*%d + %d*%d = %d*%d",number.get(a),number.get(a),number.get(b),
                                    number.get(b),number.get(c),number.get(c));
                            System.out.println();
                            isAnyPythagor = true;
                        }
                    }
                }
            }
        }
        if (!isAnyPythagor){
            System.out.println("No");
        }
    }
}
