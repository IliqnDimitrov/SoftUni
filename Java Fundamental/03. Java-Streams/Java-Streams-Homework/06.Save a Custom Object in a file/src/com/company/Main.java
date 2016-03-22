package com.company;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ObjectOutputStream os = new ObjectOutputStream(new BufferedOutputStream(new FileOutputStream("resources/course.save")));
        Course java = new Course("JavaFundamentals", 458);
        Course cSharp = new Course("cSharpAdvanced", 354);
        Course oop = new Course("OOP", 678);
        Course hqc = new Course("HQC", 758);
        List<Course> db = new ArrayList<>();
        db.add(java);
        db.add(cSharp);
        db.add(oop);
        db.add(hqc);
        os.writeObject(db);
        os.flush();
        ObjectInputStream is = new ObjectInputStream(new BufferedInputStream(new FileInputStream("resources/course.save")));
        List<Course> input = (List<Course>) is.readObject();
        for (Course anInput : input) {
            System.out.println(anInput.toString());
        }
    }
}
