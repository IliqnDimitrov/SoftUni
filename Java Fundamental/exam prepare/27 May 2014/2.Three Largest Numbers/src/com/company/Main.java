package com.company;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        List<BigDecimal> number = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            number.add(new BigDecimal(console.nextLine()));
        }
        List<BigDecimal> sortedNumbers = number.stream().sorted((x1, x2) -> x2.compareTo(x1)).collect(Collectors.toList());
        for (int i = 0; i < 3; i++) {
            try {
                System.out.println(sortedNumbers.get(i).toPlainString());
            }
            catch (Exception ex){
                //do nothing
            }
        }
    }
}
