package com.company;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new FileReader("resources/lines.txt"));
        List<String> db = new ArrayList<>();
        String str = br.readLine();

        while (str != null){
            str = str.toUpperCase();
            db.add(str);
            str = br.readLine();
        }

        PrintWriter pw = new PrintWriter(new FileWriter("resources/lines.txt"));
        for (String item : db) {
            pw.write(item);
            pw.println();
            pw.flush();
        }

    }
}
