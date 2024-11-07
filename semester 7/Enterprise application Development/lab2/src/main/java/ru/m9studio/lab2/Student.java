package ru.m9studio.lab2;


public class Student {
    private int id;
    private String name;
    private String surname;
    private String patronymic;
    private String city;
    private boolean isMan;
    private int age;
    private String group;
    private String faculty;

    public Student(){

    }
    public Student(String name, String surname, String patronymic,
                   String city, boolean isMan, int age,
                   String group, String faculty){
        this.name = name;
        this.surname = surname;
        this.patronymic = patronymic;
        this.city = city;
        this.isMan = isMan;
        this.age = age;
        this.group = group;
        this.faculty = faculty;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getSurname() {
        return surname;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public String getPatronymic() {
        return patronymic;
    }

    public void setPatronymic(String patronymic) {
        this.patronymic = patronymic;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public boolean getIsMan() {
        return isMan;
    }

    public void setIsMan(boolean isMan) {
        this.isMan = isMan;
    }

    public String getGroup() {
        return group;
    }

    public void setGroup(String group) {
        this.group = group;
    }

    public String getFaculty() {
        return faculty;
    }

    public void setFaculty(String faculty) {
        this.faculty = faculty;
    }
}