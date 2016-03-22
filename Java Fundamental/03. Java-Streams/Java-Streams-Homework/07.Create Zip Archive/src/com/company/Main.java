package com.company;

import java.io.*;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

public class Main {

    public static void main(String[] args) throws IOException {
        byte[] buffer = new byte[1024];
        FileInputStream fs = new FileInputStream("resources/count-chars.txt");
        FileInputStream fs1 = new FileInputStream("resources/lines.txt");
        FileInputStream fs2 = new FileInputStream("resources/words.txt");

        ZipOutputStream zs = new ZipOutputStream(new FileOutputStream("resources/text-files.zip"));
        zs.putNextEntry(new ZipEntry("resources/count-chars.txt"));
        int lenght;
        while ((lenght = fs.read(buffer)) > 0){
            zs.write(buffer,0,lenght);
        }
        zs.closeEntry();
        zs.putNextEntry(new ZipEntry("resources/lines.txt"));
        while ((lenght = fs1.read(buffer)) > 0){
            zs.write(buffer,0,lenght);
        }
        zs.closeEntry();
        zs.putNextEntry(new ZipEntry("resources/words.txt"));
        while ((lenght = fs2.read(buffer)) > 0){
            zs.write(buffer,0,lenght);
        }
        zs.closeEntry();
        zs.close();
    }
}
