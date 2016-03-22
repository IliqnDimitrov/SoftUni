package com.company;

import java.io.*;

public class Main {

    public static void main(String[] args) throws IOException {
        FileInputStream fi = new FileInputStream(new File("resources/IMG_0006.JPG"));
        FileOutputStream fo = new FileOutputStream(new File("resources/my-copied-picture.jpg"));
        byte[] buffer = new byte[1024];
        int lenght = fi.read(buffer);
        while (lenght > 0){
            fo.write(buffer,0,lenght);
            lenght = fi.read(buffer);
        }
    }
}
