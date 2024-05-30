package com.example.work.test;

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
    public void update(Student student) throws SQLException {
        StringBuilder str = new StringBuilder();
        str.append(new Object[]{
                "CALL student_update(", student.getId(), ", '", student.getName(), "', '", student.getSurname(), "', ", student.getAge(), ");"
        });
        db.request(str.toString());
    }
    public Student addStudent(String name, String surname, int age) throws SQLException {
        StringBuilder str = new StringBuilder();
        str.append("CALL student_add('");
        str.append(name);
        str.append("', '");
        str.append(surname);
        str.append("', ");
        str.append(age);
        str.append(");");
        return Student.parse(this, (db.request(str.toString())).get(0));
    }








}
