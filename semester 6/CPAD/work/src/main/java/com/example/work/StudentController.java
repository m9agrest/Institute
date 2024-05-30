package com.example.work;

import com.example.work.struct.Student;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

import java.sql.SQLException;

public class StudentController {
    @FXML
    private TextField fieldAge;
    @FXML
    private TextField fieldName;
    @FXML
    private TextField fieldSurname;

    @FXML
    void onClose() {
        Stage stage = (Stage) fieldAge.getScene().getWindow();
        stage.close();
    }
    @FXML
    void onDone() throws SQLException {
        int age;
        try{
            age = Integer.parseInt(fieldAge.getText());
        }catch (Exception e){
            return;
        }
        if(age<0){
            return;
        }
        if(student == null){
            student = service.addStudent(
                    fieldName.getText(),
                    fieldSurname.getText(),
                    age);
        }else{
            student.setAge(age);
            student.setName(fieldName.getText());
            student.setSurname(fieldSurname.getText());
            student.update();
        }
        onClose();
    }


    Student student;
    public void setStudent(Student student) {
        if(student != null){
            this.student = student;
            fieldAge.setText(student.getAge() + "");
            fieldName.setText(student.getName());
            fieldSurname.setText(student.getSurname());
        }
    }
    Service service;
    public void setService(Service service) {
        this.service = service;
    }
    ObservableList<Student> students;
    public void setObservable(ObservableList<Student> students) {
        this.students = students;
    }
}
