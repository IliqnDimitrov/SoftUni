package com.company;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new FileReader("resources/lines.txt"));
        String str = br.readLine();
        while (str != null){
            int sum = 0;
            for (int i = 0; i < str.length(); i++) {
                sum += str.charAt(i);
            }
            System.out.println(sum);
            str = br.readLine();
        }
    }
}
