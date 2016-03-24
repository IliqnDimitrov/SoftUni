package com.company;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        char[] input = console.nextLine().toCharArray();
        List<String> elements = new ArrayList<>();
        String element = "";
        for (int i = 0; i < input.length; i++) {
            if (input[i] != ' ' && input[i] != '-' && input[i] != '+'){
                element += input[i];
            }
            else if (input[i] == '+'){
                elements.add(element);
                element = "+";
                elements.add(element);
                element = "";
            }
            else if (input[i] == '-'){
                elements.add(element);
                element = "-";
                elements.add(element);
                element = "";
            }
            if (i == input.length - 1){
                elements.add(element);
            }
        }
        BigDecimal result = new BigDecimal("0");
        for (int i = 0; i < elements.size() - 1; i++) {
            switch (elements.get(i)){
                case "+":
                    BigDecimal value = new BigDecimal(elements.get(i + 1));
                    result = result.add(value);
                    i++;
                    break;
                case "-":
                    value = new BigDecimal(elements.get(i + 1));
                    result = result.subtract(value);
                    i++;
                    break;
                default:
                    result = new BigDecimal(elements.get(i));
                    break;
            }
        }
        System.out.printf("%.7f",result);

    }
}
