package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int[] input = new int[n];
        for (int i = 0; i < input.length; i++) {
            input[i] = console.nextInt();
        }
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        String aAndB = "";
        String cAndD = "";
        boolean isNumbers = false;
        for (int i = 0; i < input.length; i++) {
            a = input[i];
            for (int j = 0; j < input.length; j++) {
                b = input[j];
                for (int k = 0; k < input.length; k++) {
                    c = input[k];
                    for (int l = 0; l < input.length; l++) {
                        d = input[l];
                        if (a != b && a != c && a != d && b != c && b != d && c != d){
                            aAndB = "" + a + b;
                            cAndD = "" + c + d;
                            if (aAndB.equals(cAndD)){
                                isNumbers = true;
                                System.out.printf("%d|%d==%d|%d",a,b,c,d);
                                System.out.println();
                            }
                        }
                    }
                }
            }
        }
        if (!isNumbers){
            System.out.println("No");
        }

    }
}
