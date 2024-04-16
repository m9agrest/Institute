package com.example.work;

import java.sql.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class DataBase {
    private Connection connection;
    private Statement statement;
    private void connection(){
        String url = "jdbc:mysql://localhost:3306/ak";
        String username = "root";
        String password = "";
        try{
            connection = DriverManager.getConnection(url, username, password);
            statement = connection.createStatement();
        }catch (Exception e){ }
    }
    public List<ResultSet> Request(String request){
        ArrayList<ResultSet> list = new ArrayList<ResultSet>();
        try{
            ResultSet resultSet = statement.executeQuery(request);
            while(resultSet.next()){
                list.add(resultSet);
            }
        }catch (Exception e){ }
        return list;
    }





    /*
    static ResultSet resultSet;
    public static void Request(String request) throws SQLException {
        close();
        statement.execute(request);
    }
    public static ResultSet Line(String request) throws SQLException {
        close();
        resultSet = statement.executeQuery(request);
        if(resultSet.next()) {
            return resultSet;
        }
        return null;
    }
    private static void close() throws SQLException {
        if(resultSet != null && !resultSet.isClosed()){
            resultSet.close();
        }
    }
    public static void Close() throws SQLException {
        close();
        statement.close();
        connection.close();
    }
    public static boolean isCorrect() throws SQLException {
        return !statement.isClosed() && !connection.isClosed();
    }
    public static long Id(String request)throws SQLException {
        close();
        statement.executeUpdate(request, Statement.RETURN_GENERATED_KEYS);
        resultSet = statement.getGeneratedKeys();
        if (resultSet.next()) {
            return resultSet.getLong(1);
        }
        return 0;
    }*/
}
