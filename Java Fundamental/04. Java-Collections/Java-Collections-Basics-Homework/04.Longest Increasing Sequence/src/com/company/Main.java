package com.company;

import java.sql.Array;
import java.util.*;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] sequence = console.nextLine().split(" ");
        Map<Integer, Integer> sequnceCount = new LinkedHashMap<>();
        Map<Integer, List<Integer>> seuqnceNumber = new LinkedHashMap<>();
        List<Integer> numbers = new ArrayList<>();
        int[] newSequnce = new int[sequence.length];
        for (int i = 0; i < sequence.length; i++) {
            newSequnce[i] = Integer.parseInt(sequence[i]);
        }
        int key = 0;
        for (int i = 0; i < newSequnce.length; i++) {
            if (i == newSequnce.length - 1){
                numbers.add(newSequnce[i]);
                sequnceCount.put(key, numbers.size());
                seuqnceNumber.put(key, new ArrayList<>());
                List<Integer> xax = seuqnceNumber.get(key);
                for (int j = 0; j < numbers.size(); j++) {
                    xax.add(numbers.get(j));
                }
                key++;
                numbers.clear();
            }
            else if(newSequnce[i] < newSequnce[i + 1]){
                numbers.add(newSequnce[i]);
            }
            else{
                numbers.add(newSequnce[i]);
                sequnceCount.put(key, numbers.size());
                seuqnceNumber.put(key, new ArrayList<>());
                List<Integer> xax = seuqnceNumber.get(key);
                for (int j = 0; j < numbers.size(); j++) {
                    xax.add(numbers.get(j));
                }
                key++;
                numbers.clear();
            }
        }
        int count = 0;
        int maxCount = 0;
        for (Map.Entry<Integer, Integer> entry : sequnceCount.entrySet()){
            count = entry.getValue();
            if (count > maxCount){
                maxCount = count;
                key = entry.getKey();
            }
        }
        for (Map.Entry<Integer, List<Integer>> entry : seuqnceNumber.entrySet()){
            for (int i = 0; i < entry.getValue().size(); i++) {
                System.out.print(entry.getValue().get(i) + " ");
            }
            System.out.println();
        }
        List<Integer> result = seuqnceNumber.get(key);
        System.out.print("Longest:");
        for (int i = 0; i < result.size(); i++) {
            System.out.print(" " + result.get(i));
        }
    }
}
