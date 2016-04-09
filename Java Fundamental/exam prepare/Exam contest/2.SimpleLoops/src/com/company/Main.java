package com.company;

import java.math.BigInteger;
import java.util.*;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String a = input.nextLine();
        String b = input.nextLine();
        String c = input.nextLine();
        int indexN = Integer.parseInt(input.nextLine());
        List<BigInteger> xaxa = new ArrayList<>();
        xaxa.add(new BigInteger(a));
        xaxa.add(new BigInteger(b));
        xaxa.add(new BigInteger(c));
        List<BigInteger> sequnce = new ArrayList<>();
        if (indexN <= 3){
            for (int i = 0; i < indexN; i++) {
                sequnce.add(xaxa.get(i));
            }
        }
        else {
            sequnce.add(new BigInteger(a));
            sequnce.add(new BigInteger(b));
            sequnce.add(new BigInteger(c));
            BigInteger sum = new BigInteger("0");
            for (int i = 3; i < indexN ; i++) {
                sum = sum.add(sequnce.get(i - 1)).add(sequnce.get(i - 2)).add(sequnce.get(i - 3));
                sequnce.add(sum);
                sum = BigInteger.ZERO;
            }
        }
        int size = sequnce.size();
        BigInteger element = sequnce.get(size - 1);
        System.out.println(element);
    }
}
