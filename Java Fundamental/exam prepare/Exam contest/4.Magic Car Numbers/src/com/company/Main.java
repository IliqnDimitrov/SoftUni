package com.company;

import java.math.BigInteger;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        Map<String, Integer> buvki = new LinkedHashMap<>();
        buvki.put("A", 10);
        buvki.put("B", 20);
        buvki.put("C", 30);
        buvki.put("E", 50);
        buvki.put("H", 80);
        buvki.put("K", 110);
        buvki.put("M", 130);
        buvki.put("P", 160);
        buvki.put("T", 200);
        buvki.put("X", 240);
        int CA = 40;
        int X = 0;
        int Y = 0;
        BigInteger count = BigInteger.ZERO;
        for (int a = 0; a <= 9; a++) {

            for (int b = 0; b <= 9; b++) {

                for (int c = 0; c <= 9; c++) {

                    for (int d = 0; d <= 9; d++) {

                        for (Map.Entry<String, Integer> bukva1 : buvki.entrySet()) {
                            X = bukva1.getValue();

                            for (Map.Entry<String, Integer> bukva2: buvki.entrySet()) {
                                Y = bukva2.getValue();
                                if (CA + a + b + c + d + X + Y == n){
                                    if (a == b && a == c && a == d){
                                        count = count.add(BigInteger.ONE);
                                    }
                                    else if (a != b && b == c && b == d){
                                        count = count.add(BigInteger.ONE);
                                    }
                                    else if (a != d && a == b && a == c){
                                        count = count.add(BigInteger.ONE);
                                    }
                                    else if (a != c && a == b && c == d ){
                                        count = count.add(BigInteger.ONE);
                                    }
                                    else if (a != b && a == c && b == d){
                                        count = count.add(BigInteger.ONE);
                                    }
                                    else if (a != b && a == d && b == c){
                                        count = count.add(BigInteger.ONE);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        System.out.println(count);
    }
}
