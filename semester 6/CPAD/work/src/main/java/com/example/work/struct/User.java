package com.example.work.struct;

import com.example.work.Service;

import java.sql.ResultSet;
import java.sql.SQLException;

public class User {
    private User(Service service, int id, String name, String email, String password) {
        this.id = id;
        this.name = name;
        this.email = email;
        this.password = password;
    }
    static public User parse(Service service, ResultSet data) throws SQLException {
        return new User(
                service,
                data.getInt("id"),
                data.getString("name"),
                data.getString("email"),
                data.getString("password")
        );
    }
    Service service;
    private int id;
    private String name;
    private String email;
    private String password;
}
