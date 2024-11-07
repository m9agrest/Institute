package ru.m9studio.lab2;

import jakarta.annotation.PostConstruct;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

@Component
public class StudentRepository {
    private Map<Integer, Student> students = new ConcurrentHashMap<>();



    public Map<Integer, Student> getStudents() {
        return students;
    }
    int maxId = 0;
    public int add(Student student){
        maxId++;
        student.setId(maxId);
        students.put(maxId, student);
        return maxId;
    }
    @PostConstruct
    public void init() {
        add(new Student("Михаил", "Ермилов", "Владимирович", "Муром",
                true, 23, "ПИн-121", "ФИТР"));
        add(new Student("Марина", "Лямина", "Алексеевна", "Муром",
                false, 20, "ПИн-121", "ФИТР"));
        add(new Student("Кузьма", "Кузьмин", "Викторович", "Москва",
                true, 40, "ИС-121", "ФИТР"));
    }

}
