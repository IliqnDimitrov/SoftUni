package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        int cX = Integer.parseInt(input[0]);
        int cY = Integer.parseInt(input[1]);
        int r = Integer.parseInt(console.nextLine());
        int n = Integer.parseInt(console.nextLine());
        String hits = console.nextLine();
        Pattern pattern = Pattern.compile("-*\\d+");
        Matcher matcher = pattern.matcher(hits);
        List<Integer> coordinates = new ArrayList<>();
        while (matcher.find()){
            coordinates.add(Integer.parseInt(matcher.group(0)));
        }
        int currentX = 0;
        int currentY = 0;
        for (int i = 0; i < coordinates.size(); i = i + 2) {
            currentX = coordinates.get(i);
            currentY = coordinates.get(i + 1);
            if ((currentX <= cX + r && currentX >= cX - r) && (currentY <= cY + r && currentY >= cY - r)){
                if (currentX > cX + r/2 && currentY > cY + r/2){
                    System.out.println("no");
                }
                else if (currentX < cX - r/2 && currentY < cY - r/2){
                    System.out.println("no");
                }
                else if (currentX > cX + r/2 && currentY < cY - r/2){
                    System.out.println("no");
                }
                else if (currentX < cX - r/2 && currentY > cY + r/2){
                    System.out.println("no");
                }
                else {
                    System.out.println("yes");
                }
            }
            else {
                System.out.println("no");
            }
        }
    }
}
