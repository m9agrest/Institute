package com.example.work3;

import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

public class StudentController {
    @FXML
    private TextField fieldAge;
    @FXML
    private TextField fieldName;
    @FXML
    private TextField fieldSurname;
    @FXML
    private TextField fieldPatronymic;
    @FXML
    private TextField fieldCity;
    @FXML
    private TextField fieldGroup;

    @FXML
    void onClose() {
        Stage stage = (Stage) fieldAge.getScene().getWindow();
        stage.close();
    }
    @FXML
    void onDone() {
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
            student = new Student(
                    fieldName.getText(),
                    fieldSurname.getText(),
                    fieldPatronymic.getText(),
                    age, fieldCity.getText(),
                    fieldGroup.getText());
            students.add(student);
        }else{
            student.setAge(age);
            student.setName(fieldName.getText());
            student.setSurname(fieldSurname.getText());
            student.setPatronymic(fieldPatronymic.getText());
            student.setGroup(fieldGroup.getText());
            student.setCity(fieldCity.getText());
        }
        onClose();
    }


    Student student;
    public void setStudent(Student student) {
        if(student != null){
            this.student = student;
            fieldAge.setText(student.getAge() + "");
            fieldName.setText(student.getName());
            fieldPatronymic.setText(student.getPatronymic());
            fieldSurname.setText(student.getSurname());
            fieldCity.setText(student.getCity());
            fieldGroup.setText(student.getGroup());
        }
    }
    ObservableList<Student> students;
    public void setObservable(ObservableList<Student> students) {
        this.students = students;
    }
}
