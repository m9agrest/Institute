package com.example.work.dao;

import com.example.work.MainApplication;
import com.example.work.domains.Student;
import javafx.scene.control.Alert;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
public class StudentDao implements Dao<Student, Long> {
    private static String FIND_ALL = "SELECT * FROM teststudents";
    private static String SAVE = "INSERT INTO teststudents (surname, name, patronym, age, city, groupp) VALUES (?, ?, ?, ?, ?, ?)";
    private static String DELETE = "DELETE FROM teststudents WHERE surname=? AND name=? AND patronym=? AND age=? AND city=? AND groupp=?";
    private static String FIND_BY_SURNAME = "SELECT * FROM teststudents WHERE surname=?";
    private static String UPDATE = "UPDATE teststudents SET age=?, city = ?, groupp=? WHERE surname = ? AND name = ? AND patronym = ?";
    private static void Alert(String text){
        Alert alert;
        alert = new Alert(Alert.AlertType.ERROR);
        alert.setTitle("Ошибка");
        alert.setContentText(null);
        alert.setHeaderText(text);
        alert.showAndWait();
    }
    @Override
    public Student findById(Long id) {
        throw new UnsupportedOperationException("Метод не реализован");
    }
    protected List<Student> mapper(ResultSet rs){
        List<Student> list = new ArrayList<>();
        try {
            while (rs.next()){
                list.add(new Student(
                        rs.getString("surname"),
                        rs.getString("name"),
                        rs.getString("patronym"),
                        rs.getInt("age"),
                        rs.getString("city"),
                        rs.getString("groupp")));
            }
        }
        catch (SQLException e){
            System.out.println(e.getMessage());
            //Alert
        }
        return list;
    }
    public List<Student> findBySurname(String surname){
        List<Student> list = null;
        ResultSet rs = null;
        try(PreparedStatement statement =
                    MainApplication.getConnection().prepareStatement(FIND_BY_SURNAME)){
            statement.setString(1,surname);
            rs = statement.executeQuery();
            list = mapper(rs);
        }
        catch (SQLException e){
            System.out.println(e.getMessage());
            //Alert
        }
        return list;
    }
    @Override
    public List<Student> findALl() {
        List<Student> list = null;
        ResultSet rs = null;
        try(PreparedStatement statement =
                    MainApplication.getConnection().prepareStatement(FIND_ALL)){
            rs = statement.executeQuery();
            list = mapper(rs);
        }
        catch (SQLException e){
            System.out.println(e.getMessage());
            //Alert
        }
        return list;
    }
    @Override
    public Student save(Student student) {
        try(PreparedStatement statement = MainApplication.getConnection().prepareStatement(SAVE)){
            statement.setString(1,student.getSurName());
            statement.setString(2,student.getName());
            statement.setString(3,student.getPatronym());
            statement.setInt(4,student.getAge());
            statement.setString(5,student.getCity());
            statement.setString(6,student.getGroup());
            statement.executeUpdate();
        }
        catch (SQLException e){
            System.out.println(e.getMessage());
            System.out.println(1);
            //Alert
        }
        return student;
    }
    @Override
    public Student update(Student student) {
        try(PreparedStatement statement = MainApplication.getConnection().prepareStatement(UPDATE)){
            statement.setInt(1,student.getAge());
            statement.setString(2,student.getCity());
            statement.setString(3,student.getGroup());
            statement.setString(4,student.getSurName());
            statement.setString(5,student.getName());
            statement.setString(6,student.getPatronym());
            statement.executeUpdate();
        }
        catch (SQLException e){
            System.out.println(e.getMessage());
            System.out.println(1);
            //Alert
        }
        return student;
    }
    @Override
    public void delete(Student student) {
        try(PreparedStatement statement = MainApplication.getConnection().prepareStatement(DELETE)){
            statement.setString(1,student.getSurName());
            statement.setString(2,student.getName());
            statement.setString(3,student.getPatronym());
            statement.setInt(4,student.getAge());
            statement.setString(5,student.getCity());
            statement.setString(6,student.getGroup());
            statement.execute();
        }
        catch (SQLException e){
            System.out.println(e.getMessage());
            //Alert
        }
    }
    @Override
    public void deleteById(Long id) {
        throw new UnsupportedOperationException("Метод не реализован");
    }
}