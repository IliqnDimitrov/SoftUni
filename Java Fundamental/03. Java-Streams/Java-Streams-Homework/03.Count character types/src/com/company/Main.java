package com.company;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new FileReader("resources/words.txt"));
        String str = br.readLine();
        int vowels = 0;
        int consonants = 0;
        int punctuations = 0;
        while (str != null){
            str = str.toLowerCase();
            for (int i = 0; i < str.length(); i++) {
                if (str.charAt(i) == ' '){
                    continue;
                }
                switch (str.charAt(i)){
                    case 'a':
                        vowels++;
                        break;
                    case 'e':
                        vowels++;
                        break;
                    case 'i':
                        vowels++;
                        break;
                    case 'o':
                        vowels++;
                        break;
                    case 'u':
                        vowels++;
                        break;
                    case '!':
                        punctuations++;
                        break;
                    case ',':
                        punctuations++;
                        break;
                    case '.':
                        punctuations++;
                        break;
                    case '?':
                        punctuations++;
                        break;
                    default:
                        consonants++;
                }
            }
            str = br.readLine();
        }
        PrintWriter pw = new PrintWriter("resources/count-chars.txt");
        pw.println("Vowels: " + vowels);
        pw.println("Consonants: " + consonants);
        pw.println("Punctuation: " + punctuations);
        pw.flush();
    }
}
