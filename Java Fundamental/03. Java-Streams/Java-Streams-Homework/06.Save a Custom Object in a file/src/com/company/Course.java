package com.company;

import java.io.Serializable;

/**
 * Created by blade on 21.3.2016 г..
 */
public class Course implements Serializable{
    private String courseName;
    private int numberOfStudents;

    public Course(String courseName, int numberOfStudents) {
        this.courseName = courseName;
        this.numberOfStudents = numberOfStudents;
    }

    @Override
    public String toString() {
        return String.format("Course: %s \nNumbers of students: %d",courseName,numberOfStudents);
    }
}
