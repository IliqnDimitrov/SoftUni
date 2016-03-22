package com.company;

import java.io.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {

    public static void main(String[] args) throws IOException, ClassNotFoundException {
        List<Double> number = new ArrayList<>(Arrays.asList(2.5 , 5.4 , 2.1, 6.8));
        ObjectOutputStream os = new ObjectOutputStream(new BufferedOutputStream(new FileOutputStream("resources/doubles.list")));
        os.writeObject(number);
        os.flush();
        ObjectInputStream is = new ObjectInputStream(new BufferedInputStream(new FileInputStream("resources/doubles.list")));
        Object newNumbers = is.readObject();
        System.out.println(String.join(", ",newNumbers.toString()));
    }
}
