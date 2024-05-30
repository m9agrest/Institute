package com.example.work.controllers;
import com.example.work.domains.Student;
import javafx.scene.control.Alert;
import javafx.scene.control.TextField;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.stage.Stage;
public class EditController {
    private Student student;
    public void setEditStage(Stage editStage) {
        this.editStage = editStage;
    }
    private Stage editStage;
    public void setStudent(Student student) {
        this.student = student;
        tSurName.setText(student.getSurName());
        tName.setText(student.getName());
        tPatronym.setText(student.getPatronym());
        tAge.setText(String.valueOf(student.getAge()));
        tCity.setText(student.getCity());
        tGroup.setText(student.getGroup());
    }
    public void setStudent(Student student, boolean update) {
        setStudent(student);
        tSurName.setEditable(false);
        tName.setEditable(false);
        tPatronym.setEditable(false);
    }
    @FXML
    private TextField tAge;
    @FXML
    private TextField tCity;
    @FXML
    private TextField tGroup;
    @FXML
    private TextField tName;
    @FXML
    private TextField tPatronym;
    @FXML
    private TextField tSurName;
    @FXML
    void onCancel(ActionEvent event) {
        editStage.close();
    }
    @FXML
    void onOK(ActionEvent event) {
        Alert alert;
        if (Integer.parseInt(tAge.getText()) <= 0) {
            alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Ошибка");
            alert.setContentText(null);
            alert.setHeaderText("Некорректно введён возраст");
            alert.showAndWait();
        } else {
            student.setSurName(tSurName.getText());
            student.setName(tName.getText());
            student.setPatronym(tPatronym.getText());
            student.setAge(Integer.parseInt(tAge.getText()));
            student.setCity(tCity.getText());
            student.setGroup(tGroup.getText());
            editStage.close();
        }
    }

}
