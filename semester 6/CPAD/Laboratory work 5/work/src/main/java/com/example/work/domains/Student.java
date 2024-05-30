package com.example.work.domains;
import javafx.beans.property.IntegerProperty;
import javafx.beans.property.SimpleIntegerProperty;
import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;
public class Student {
    private String name;
    private String surname;
    private int age;
    private String patronym;
    private String city;
    private String group;
    public Student() {
        this("", "", "", 1, "", "");
    }
    public Student(String surname,String name, String patronym, int age, String city, String group) {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.patronym = patronym;
        this.city = city;
        this.group = group;
    }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public String getSurName() {
        return surname;
    }
    public void setSurName(String surname) {
        this.surname = surname;
    }
    public int getAge() {
        return age;
    }
    public void setAge(int age) {
        this.age = age;
    }
    public String getPatronym() {
        return patronym;
    }
    public void setPatronym(String patronym) {
        this.patronym = patronym;
    }
    public String getCity() {
        return city;
    }
    public void setCity(String city) {
        this.city = city;
    }
    public String getGroup() {
        return group;
    }
    public void setGroup(String group) {
        this.group = group;
    }
    @Override
    public String toString() {
        return "Студент: " + getSurName() + " " + getName() + " " + getPatronym() + " возраст: " + getAge() + " лет " + "группа: " + getGroup();
    }
}
