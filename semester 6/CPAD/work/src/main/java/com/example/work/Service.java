package com.example.work;

import com.example.work.struct.Interaction;
import com.example.work.struct.Message;
import com.example.work.struct.User;

import java.sql.SQLException;

public class Service {
    private String dbAddress;
    private short dbPort;
    private String dbBase;
    private String dbUser;
    private String dbPassword;
    private DataBase db = new DataBase();
    public Service(String address, short port, String base, String user, String password){
        dbAddress = address;
        dbPort = port;
        dbBase = base;
        dbUser = user;
        dbPassword = password;
    }
    public boolean connection(){
        close();
        try {
            db.connection(dbAddress, dbPort, dbBase, dbUser, dbPassword);
        } catch (SQLException e) {
            return false;
        }
        return true;
    }
    public boolean close(){
        try {
            db.close();
        }catch (Exception e){
            return false;
        }
        return true;
    }
    public void update(User user){

    }
    public void update(Message message){

    }
    public void update(Interaction interaction){

    }









}
