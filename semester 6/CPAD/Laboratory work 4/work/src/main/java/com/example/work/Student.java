package com.example.work;

import javafx.beans.property.IntegerProperty;
import javafx.beans.property.SimpleIntegerProperty;
import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;
public class Student {
    private StringProperty firstName;
    private StringProperty secondName;
    private IntegerProperty age;
    @Override
    public String toString() {
        return "Студент: " + getFirstName() + " " + getSecondName() +
                " возраст: " + getAge() + " лет";
    }
    public Student() {
        this("", "", 0);
    }
    public Student(String secondName, String firstName, int age) {
        this.firstName = new SimpleStringProperty(firstName);
        this.secondName = new SimpleStringProperty(secondName);
        this.age = new SimpleIntegerProperty(age);
    }
    public String getFirstName() {
        return firstName.get();
    }
    public StringProperty firstNameProperty() {
        return firstName;
    }
    public void setFirstName(String firstName) {
        this.firstName.set(firstName);
    }
    public String getSecondName() {
        return secondName.get();
    }
    public StringProperty secondNameProperty() {
        return secondName;
    }
    public void setSecondName(String secondName) {
        this.secondName.set(secondName);
    }
    public int getAge() {
        return age.get();
    }
    public IntegerProperty ageProperty() {
        return age;
    }
    public void setAge(int age) {
        this.age.set(age);
    }
}
