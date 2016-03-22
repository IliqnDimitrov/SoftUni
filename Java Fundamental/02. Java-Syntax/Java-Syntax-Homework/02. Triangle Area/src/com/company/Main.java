package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] input = console.nextLine().split(" ");
        int Ax = Integer.parseInt(input[0]);
        int Ay = Integer.parseInt(input[1]);
        input = console.nextLine().split(" ");
        int Bx = Integer.parseInt(input[0]);
        int By = Integer.parseInt(input[1]);
        input = console.nextLine().split(" ");
        int Cx = Integer.parseInt(input[0]);
        int Cy = Integer.parseInt(input[1]);

        int result = (Ax*(By - Cy) + Bx*(Cy - Ay) + Cx*(Ay - By)) / 2;

        System.out.println(Math.abs(result));
    }
}
