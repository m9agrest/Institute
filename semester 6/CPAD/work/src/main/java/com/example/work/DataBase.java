package com.example.work;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class DataBase {
    private Connection connection;
    private Statement statement;

    /**
     * Подключение к базе данных
     * @param address ip или domain адрресс, где распологается база данных
     * @param port port доступа к базе данных
     * @param base название базы данных
     * @param user пользователь
     * @param password пароль пользователя
     * @throws SQLException
     */
    public void connection(String address, short port, String base, String user, String password) throws SQLException {
        String url = "jdbc:mysql://" + address + ":" + port + "/" + base;
        connection = DriverManager.getConnection(url, user, password);
        statement = connection.createStatement();
    }
    /**
     * Список записей возвращаемых после запроса
     * @param request Запрос
     * @return Список записей
     * @throws SQLException
     */
    public List<ResultSet> Request(String request) throws SQLException {
        ArrayList<ResultSet> list = new ArrayList<ResultSet>();
        ResultSet resultSet = statement.executeQuery(request);
        while(resultSet.next()){
            list.add(resultSet);
        }
        return list;
    }

    /**
     * Отключение от базы данных
     * @throws SQLException
     */
    public void close() throws SQLException {
        statement.close();
        connection.close();
    }
}
