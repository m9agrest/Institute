package com.example.work3;

import javafx.beans.property.IntegerProperty;
import javafx.beans.property.SimpleIntegerProperty;
import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;

public class Student {
    private StringProperty name = new SimpleStringProperty();
    private StringProperty surname = new SimpleStringProperty();
    private StringProperty patronymic = new SimpleStringProperty();
    private IntegerProperty age = new SimpleIntegerProperty();
    private StringProperty city = new SimpleStringProperty();
    private StringProperty group = new SimpleStringProperty();



    public StringProperty getPropertyName(){
        return name;
    }
    public String getName(){
        return name.getValue();
    }
    public void setName(String value){
        name.set(value);
    }

    public StringProperty getPropertySurname(){
        return surname;
    }
    public String getSurname(){
        return surname.getValue();
    }
    public void setSurname(String value){
        surname.set(value);
    }

    public StringProperty getPropertyPatronymic(){
        return patronymic;
    }
    public String getPatronymic(){
        return patronymic.getValue();
    }
    public void setPatronymic(String value){
        patronymic.set(value);
    }

    public IntegerProperty getPropertyAge(){
        return age;
    }
    public int getAge(){
        return age.getValue();
    }
    public void setAge(int value){
        age.set(value);
    }

    public StringProperty getPropertyCity(){
        return city;
    }
    public String getCity(){
        return city.getValue();
    }
    public void setCity(String value){
        city.set(value);
    }

    public StringProperty getPropertyGroup(){
        return group;
    }
    public String getGroup(){
        return group.getValue();
    }
    public void setGroup(String value){
        group.set(value);
    }
    public Student(String name, String surname, String patronymic, int age, String city, String group){
        setAge(age);
        setName(name);
        setSurname(surname);
        setPatronymic(patronymic);
        setCity(city);
        setGroup(group);
    }


}
