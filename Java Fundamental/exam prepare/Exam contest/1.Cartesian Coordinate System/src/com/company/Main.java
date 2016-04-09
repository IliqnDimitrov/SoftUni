package com.company;

import java.math.BigDecimal;
import java.math.BigInteger;
import java.util.Objects;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String x1 = console.nextLine();
        String y1 = console.nextLine();
        BigDecimal zero = new BigDecimal("0");
        BigDecimal x = new BigDecimal(x1);
        BigDecimal y = new BigDecimal(y1);
        int xCompereZero = x.compareTo(zero);
        int yCompareZero = y.compareTo(zero);
        if (xCompereZero == 0 && yCompareZero == 0){
            System.out.println("0");
        }
        else if ((xCompereZero == 0 && yCompareZero == 1) || (xCompereZero == 0 && yCompareZero == -1)){
            System.out.println("5");
        }
        else if ((xCompereZero == 1 && yCompareZero == 0) || (xCompereZero == -1 && yCompareZero == 0)){
            System.out.println("6");
        }
        else if (xCompereZero == 1 && yCompareZero == 1){
            System.out.println("1");
        }
        else if (xCompereZero == -1 && yCompareZero == 1){
            System.out.println("2");
        }
        else if (xCompereZero == -1 && yCompareZero == -1){
            System.out.println("3");
        }
        else if (xCompereZero == 1 && yCompareZero == -1){
            System.out.println("4");
        }
    }
}
