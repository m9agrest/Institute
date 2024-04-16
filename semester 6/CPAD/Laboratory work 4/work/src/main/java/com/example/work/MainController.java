package com.example.work;

import javafx.fxml.FXML;
import javafx.scene.control.Label;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class MainController {
    Connection connection;
    String user = "root";
    String password = "";
    void Request(String request){

    }


    final static String DB_URL = "jdbc:mysql://localhost:3306/lab_work_4_";
    @FXML
    private Label infoTest;

    @FXML
    void connection() {
        try {
            connection = DriverManager.getConnection(DB_URL, "root", "");
            infoTest.setText("Connection succesfull.");
            //код для работы с соединением
        } catch (SQLException ex) {
            infoTest.setText(ex.getMessage());
        }
    }
}
