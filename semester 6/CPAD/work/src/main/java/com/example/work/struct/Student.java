package com.example.work.struct;

import com.example.work.Service;

import java.sql.ResultSet;
import java.sql.SQLException;

public class Student {
    static public Student parse(Service service, ResultSet data) throws SQLException {
        return new Student(
                service,
                data.getInt("id"),
                data.getString("name"),
                data.getString("surname"),
                data.getInt("age")
        );
    }
    private Student(Service service, int id, String name, String surname, int age){
        this.service = service;
        this.id = id;
        this.age = age;
        this.name = name;
        this.surname = surname;
    }
    Service service;
    private int id;
    private String name;
    private String surname;
    private int age;
    public int getId(){return id;}
    public String getName(){return name;}
    public void setName(String value){
        if(!value.equals(name)){
            name = value;
        }
    }
    public String getSurname(){return surname;}
    public void setSurname(String value){
        if(!value.equals(surname)){
            surname = value;
        }
    }
    public int getAge(){return age;}
    public void setAge(int value){
        if(age != value){
            age = value;
        }
    }
    public void update() throws SQLException {
        service.update(this);
    }

















}
