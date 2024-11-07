package ru.m9studio.lab2;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class StudentService {
    @Autowired
    private StudentRepository studentRepository;

    public List<Student> getAllStudents() {
        return studentRepository.getStudents().values().stream().toList();
    }
    public Student getStudentById(int id) {
        return studentRepository.getStudents().getOrDefault(id, null);
    }
    public boolean removeStudentById(int id) {
        if(studentRepository.getStudents().containsKey(id)){
            studentRepository.getStudents().remove(id);
            return true;
        }
        return false;
    }
    public int addStudent(Student student){
        return studentRepository.add(student);
    }
}
