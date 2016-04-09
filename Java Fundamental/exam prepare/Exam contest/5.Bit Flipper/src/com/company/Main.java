package com.company;

import java.math.BigInteger;
import java.util.*;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        BigInteger input = new BigInteger(console.nextLine());
        Integer[] binary = new Integer[64];
        for (int i = 0; i < binary.length; i++) {
            if (input.equals(BigInteger.ZERO)){
                binary[i] = 0;
            }
            else if (input.mod(new BigInteger("2")).equals(BigInteger.ZERO)){
                binary[i] = 0;
                input = input.divide(new BigInteger("2"));
            }
            else if (!input.mod(new BigInteger("2")).equals(BigInteger.ZERO)){
                binary[i] = 1;
                input = input.divide(new BigInteger("2"));
            }
        }
        List<Integer> reversedBinary = Arrays.asList(binary);
        Collections.reverse(reversedBinary);
        for (int i = 0; i < reversedBinary.size() - 2; i++) {
            if (reversedBinary.get(i) == 1 && Objects.equals(reversedBinary.get(i), reversedBinary.get(i + 1)) &&
                    Objects.equals(reversedBinary.get(i), reversedBinary.get(i + 2))){
                reversedBinary.set(i, 0);
                reversedBinary.set(i + 1, 0);
                reversedBinary.set(i + 2, 0);
                i = i + 2;
            }
            else if (reversedBinary.get(i) == 0 && Objects.equals(reversedBinary.get(i), reversedBinary.get(i + 1)) &&
                    Objects.equals(reversedBinary.get(i), reversedBinary.get(i + 2))){
                reversedBinary.set(i, 1);
                reversedBinary.set(i + 1, 1);
                reversedBinary.set(i + 2, 1);
                i = i + 2;
            }
        }
        Collections.reverse(reversedBinary);
        BigInteger two = new BigInteger("2");
        BigInteger sum = new BigInteger("0");
        for (int i = 0; i < 64; i++) {
            if (reversedBinary.get(i) == 1){
                sum = sum.add(two.pow(i));
            }
        }
        System.out.println(sum);
    }
}
