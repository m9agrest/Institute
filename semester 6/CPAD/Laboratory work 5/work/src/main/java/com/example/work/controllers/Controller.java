package com.example.work.controllers;
import com.example.work.MainApplication;
import com.example.work.dao.StudentDao;
import com.example.work.domains.Student;
import javafx.application.Platform;
import javafx.beans.property.SimpleObjectProperty;
import javafx.beans.property.SimpleStringProperty;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.fxml.FXML;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;

public class Controller {
    @FXML
    private TableColumn<Student, Integer> ageColumn;
    @FXML
    private Label lInfo;
    @FXML
    private TableColumn<Student, String> nameColumn;
    @FXML
    private TableColumn<Student, String> surNameColumn;
    @FXML
    private TableView<Student> tableView;
    @FXML
    private TableColumn<Student, String> cityColumn;
    @FXML
    private TableColumn<Student, String> groupColumn;
    @FXML
    private TableColumn<Student, String> patronymColumn;
    @FXML
    private TextField tfSecondName;
    @FXML
    void onAdd(ActionEvent event) {
        Student student = new Student();
        showDialog(student,false);
        students.add(student);
        dao.save(student);
        tableView.sort();
        lInfo.setText("");
    }
    @FXML
    void onEdit(ActionEvent event) {
        Student student = tableView.getSelectionModel().getSelectedItem();
        if (student != null){
            showDialog(student,true);
            dao.update(student);
        }
        students.clear();
        students.addAll(dao.findALl());
        tableView.sort();
        lInfo.setText("");
    }
    @FXML
    void onSearchBySecondName(ActionEvent event) {
        students.clear();
        students.addAll(dao.findBySurname(tfSecondName.getText().trim()));
        tableView.sort();
        lInfo.setText("");
    }
    @FXML
    void onViewAll(ActionEvent event) {
        students.clear();
        students.addAll(dao.findALl());
        tableView.sort();
        lInfo.setText("");
    }
    private StudentDao dao;
    public Controller(){
        dao = new StudentDao();
    }
    private void showDialog(Student student, boolean update) {
        FXMLLoader loader = new FXMLLoader();
        loader.setLocation(MainApplication.class.getResource("AddEditStudent.fxml"));
        try {
            Parent root = loader.load();
            Scene scene = new Scene(root);
            Stage addStage = new Stage();
            addStage.setTitle("Информация о студенте");
            addStage.setScene(scene);
            addStage.initModality(Modality.APPLICATION_MODAL);
            addStage.initOwner(MainApplication.getMainStage());
            EditController editController = loader.getController();
            if(update)
                editController.setStudent(student,true);
            else
                editController.setStudent(student);
            editController.setEditStage(addStage);
            addStage.showAndWait();
        } catch (IOException e) {
            lInfo.setText("Ошибка загрузки");
        }
    }
    @FXML
    void onExit(ActionEvent event) {
        Platform.exit();
    }
    @FXML
    void onRemove(ActionEvent event) {
        Student student = tableView.getSelectionModel().getSelectedItem();
        tableView.getItems().remove(tableView.getSelectionModel().getSelectedIndex());
        dao.delete(student);
        tableView.sort();
    }
    protected ObservableList<Student> students = FXCollections.observableArrayList();
    @FXML
    void initialize() {
        students.addAll(dao.findALl());
        surNameColumn.setCellValueFactory(s -> new SimpleStringProperty(s.getValue().getSurName()));
        nameColumn.setCellValueFactory(s -> new SimpleStringProperty(s.getValue().getName()));
        patronymColumn.setCellValueFactory(s -> new
                SimpleStringProperty(s.getValue().getPatronym()));
        ageColumn.setCellValueFactory(s -> new
                SimpleObjectProperty<Integer>(s.getValue().getAge()));
        cityColumn.setCellValueFactory(s -> new SimpleStringProperty(s.getValue().getCity()));
        groupColumn.setCellValueFactory(s -> new SimpleStringProperty(s.getValue().getGroup()));
        tableView.setItems(students);
        tableView.getSortOrder().add(surNameColumn);
        tableView.getSortOrder().add(nameColumn);
        tableView.getSortOrder().add(patronymColumn);
        tableView.getSelectionModel().selectedItemProperty().addListener(new ChangeListener<Student>() {
            @Override
            public void changed(ObservableValue<? extends Student> observableValue, Student student, Student t1) {
                if (t1 != null) {
                    showStudent(t1);
                }
            }
        });
    }
    private void showStudent(Student student) {
        lInfo.setText(student.toString());
    }

}
