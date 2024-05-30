package com.example.work;

import javafx.application.Platform;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.event.ActionEvent;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import java.sql.*;
public class MainController {
    protected ObservableList<Student> students = FXCollections.observableArrayList();
    @FXML
    private TableView<Student> tableView;
    @FXML
    private TableColumn<Student, Integer> ageColumn;
    @FXML
    private TableColumn<Student, String> firstNameColumn;
    @FXML
    private TableColumn<Student, String> secondNameColumn;
    @FXML
    private TextField tAge;
    @FXML
    private TextField tFirstName;
    @FXML
    private TextField tSecondName;
    final static String DB_URL = "jdbc:mysql://127.0.0.1:3306/java_work";
    final static String LOGIN = "root";
    final static String PASSWORD = "";
    private String sqlcommand = "";
    private Connection connection;
    protected void connectionDB() {
        try {
            connection = DriverManager.getConnection(DB_URL, LOGIN, PASSWORD);
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    @FXML
    void onAddStudent(ActionEvent event) {
        if (!tFirstName.getText().trim().isEmpty() && !tSecondName.getText().trim().isEmpty() &&
                !tAge.getText().trim().isEmpty()) {
            students.clear();
            connectionDB();
            try {
                sqlcommand = "INSERT INTO student4 (name, surname, age) " +
                        "values('" + tFirstName.getText().trim() + "','" +
                        tSecondName.getText().trim() +
                        "','" + tAge.getText().trim() + "')";
                Statement st = connection.createStatement();
                st.execute(sqlcommand);
                onViewAll(event);
            } catch (SQLException e) {
                throw new RuntimeException(e);
            }
        }
    }
    @FXML
    void onExit(ActionEvent event) {
        Platform.exit();
    }
    @FXML
    void onRemove(ActionEvent event) {
        if (tableView.getSelectionModel().selectedItemProperty().getValue() != null) {
            Student t1 = tableView.getSelectionModel().selectedItemProperty().getValue();
            students.clear();
            connectionDB();
            try {
                sqlcommand = "DELETE FROM student4 WHERE name = '" + t1.getFirstName() + "' AND surname = '" + t1.getSecondName() + "' AND age = '" + t1.getAge() + "'";
                Statement st = connection.createStatement();
                st.execute(sqlcommand);
                onViewAll(event);
            } catch (SQLException e) {
                throw new RuntimeException(e);
            }
        }
    }
    @FXML
    void onSearchStudent(ActionEvent event) {
        if (!tFirstName.getText().trim().isEmpty() && !tSecondName.getText().trim().isEmpty() &&
                !tAge.getText().trim().isEmpty()) {
            students.clear();
            connectionDB();
            try {
                sqlcommand = "SELECT * FROM student4 WHERE name = '" +
                        tFirstName.getText().trim() + "' AND surname = '" +
                        tSecondName.getText().trim() + "' AND age = '" + tAge.getText().trim() +
                        "'";
                Statement st = connection.createStatement();
                ResultSet resultSet = st.executeQuery(sqlcommand);
                while (resultSet.next()) {
                    students.add(new Student(resultSet.getString("surname"),
                            resultSet.getString("name"), resultSet.getInt("age")));
                }
                initialize();
            } catch (SQLException e) {
                throw new RuntimeException(e);
            }
        }
    }
    @FXML
    void onViewAll(ActionEvent event) {
        connectionDB();
        try {
            sqlcommand = "SELECT * FROM student4";
            Statement st = connection.createStatement();
            ResultSet resultSet = st.executeQuery(sqlcommand);
            while (resultSet.next()) {
                students.add(new Student(resultSet.getString("surname"),
                        resultSet.getString("name"), resultSet.getInt("age")));
            }
            initialize();
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
    @FXML
    void initialize() {
        secondNameColumn.setCellValueFactory(s -> s.getValue().secondNameProperty());
        firstNameColumn.setCellValueFactory(s -> s.getValue().firstNameProperty());
        ageColumn.setCellValueFactory(s -> s.getValue().ageProperty().asObject());
        tableView.setItems(students);
    }
}
