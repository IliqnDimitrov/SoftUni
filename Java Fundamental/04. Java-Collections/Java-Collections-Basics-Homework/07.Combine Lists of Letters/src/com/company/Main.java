package com.company;

import java.lang.reflect.Array;
import java.util.*;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] list1 = console.nextLine().split(" ");
        String[] list2 = console.nextLine().split(" ");
        List<String> result = new ArrayList<>();
        List<String> result2 = new ArrayList<>();
        for (int i = 0; i < list1.length; i++) {
            result.add(list1[i]);
        }
        for (int i = 0; i < list2.length; i++) {
            if (!result.contains(list2[i])){
                result2.add(list2[i]);
            }
        }
        for (int i = 0; i < result2.size(); i++) {
            result.add(result2.get(i));
        }
        for (String aResult : result) {
            System.out.print(aResult + " ");
        }
    }
}
