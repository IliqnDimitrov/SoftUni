package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        Pattern pattern = Pattern.compile("-*\\d+");
        Matcher matcher = pattern.matcher(input);
        List<Integer> numbers = new ArrayList<>();
        while (matcher.find()){
            numbers.add(Integer.parseInt(matcher.group(0)));
        }
        boolean isOdd = false;
        boolean isEven = false;
        int count = 0;
        int maxCount = 0;
        for (int i = 0; i < numbers.size(); i++) {
            if (numbers.get(i) == 0){
                isEven = true;
                isOdd = true;
                count++;
            }
            else if (numbers.get(i) % 2 == 0){
                isEven = true;
                count++;
            }
            else if (numbers.get(i) % 2 != 0){
                isOdd = true;
                count++;
            }
            for (int j = i; j < numbers.size(); j++) {
                if (j == numbers.size() - 1){
                    i = j;
                    if (count > maxCount){
                        maxCount = count;
                        count = 0;
                        break;
                    }
                    break;
                }
                if (isEven && isOdd){
                    if (numbers.get(j) == 0 && numbers.get(j + 1) == 0){
                        count++;
                        isEven = true;
                        isOdd = true;
                    }
                    else if (numbers.get(j) == 0 && numbers.get(j + 1) % 2 == 0){
                        count++;
                        isEven = true;
                        isOdd = false;
                    }
                    else if (numbers.get(j) == 0 && numbers.get(j + 1) % 2 != 0){
                        count++;
                        isEven = false;
                        isOdd = true;
                    }
                }
                else if (isEven){
                    if (numbers.get(j) == 0 && numbers.get(j + 1) % 2 != 0){
                        count++;
                        isEven = false;
                        isOdd = true;
                    }
                    else if (numbers.get(j) % 2 == 0 && numbers.get(j + 1) == 0){
                        count++;
                        isOdd = true;
                        isEven = false;
                    }
                    else if (numbers.get(j) % 2 == 0 && numbers.get(j + 1) % 2 != 0){
                        count++;
                        isOdd = true;
                        isEven = false;
                    }
                    else {
                        i = j;
                        if (count > maxCount){
                            maxCount = count;
                            count = 0;
                            break;
                        }
                        break;
                    }
                }
                else if (isOdd){
                    if (numbers.get(j) == 0 && numbers.get(j + 1) % 2 == 0){
                        count++;
                        isEven = true;
                        isOdd = false;
                    }
                    else if (numbers.get(j) % 2 == 0 && numbers.get(j + 1) == 0){
                        count++;
                        isEven = true;
                        isOdd = false;
                    }
                    else if (numbers.get(j) % 2 != 0 && numbers.get(j + 1) % 2 == 0){
                        count++;
                        isEven = true;
                        isOdd = false;
                    }
                    else{
                        i = j;
                        if (count > maxCount){
                            maxCount = count;
                            count = 0;
                            break;
                        }
                        break;
                    }
                }
            }
            count = 0;
            isEven = false;
            isOdd = false;
        }
        System.out.println(maxCount);

    }
}
