package com.example.work.utils;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DataBaseHelper {
    final static String DB_URL = "jdbc:mysql://127.0.0.1:3306/java_work";
    final static String LOGIN = "root";
    final static String PASSWORD = "";
    public static Connection getConnection() throws SQLException {
        return DriverManager.getConnection(DB_URL,LOGIN,PASSWORD);
    }

}
