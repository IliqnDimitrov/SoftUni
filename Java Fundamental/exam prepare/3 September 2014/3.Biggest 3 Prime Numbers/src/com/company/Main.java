package com.company;


import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        Pattern pattern = Pattern.compile("[-]*\\d+");
        Matcher matcher = pattern.matcher(input);
        List<Integer> allNumbers = new ArrayList<>();
        while(matcher.find()){
            allNumbers.add(Integer.parseInt(matcher.group(0)));
        }

        allNumbers = allNumbers.stream().sorted((x1, x2) -> x2.compareTo(x1)).distinct().collect(Collectors.toList());
        int sum = 0;
        int count = 0;
        for (int i = 0; i < allNumbers.size(); i++) {
            if (count == 3){
                break;
            }
            boolean isPrime = checkIsPrime(allNumbers.get(i));
            if (isPrime){
                sum += allNumbers.get(i);
                count++;
            }
        }
        if (count < 3){
            System.out.println("No");
        }
        else {
            System.out.println(sum);
        }
    }

    private static boolean checkIsPrime(Integer integer) {
        if (integer == 2 || integer == 3 || integer == 5 || integer == 7){
            return true;
        }
        else if (integer % 2 == 0 || integer % 3 == 0 || integer % 5 == 0 || integer % 7 == 0 || integer == 1){
            return false;
        }
        else {
            return true;
        }
    }
}
