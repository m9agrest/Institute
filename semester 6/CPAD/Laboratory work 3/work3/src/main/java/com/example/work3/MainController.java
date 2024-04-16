package com.example.work3;

import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

public class MainController  implements Initializable {
    private ObservableList<Student> students = FXCollections.observableArrayList();
    @FXML
    private Label info;
    @FXML
    private TableView<Student> table;
    @FXML
    private TableColumn<Student, String> name, surname, patronymic, group, city;
    @FXML
    private TableColumn<Student, Integer> age;

    @FXML
    void initialize(){
        students.add(new Student("a","a1","", 1, "new york","A-1"));
        students.add(new Student("b","b2","", 2, "moskow","A-1"));
        students.add(new Student("c","c3","", 3, "murom","B-2"));
        students.add(new Student("d","d4","", 4, "vladimir","B-2"));

        surname.setCellValueFactory(s -> s.getValue().getPropertySurname());
        name.setCellValueFactory(s -> s.getValue().getPropertyName());
        patronymic.setCellValueFactory(s -> s.getValue().getPropertyPatronymic());
        age.setCellValueFactory(s -> s.getValue().getPropertyAge().asObject());
        city.setCellValueFactory(s -> s.getValue().getPropertyCity());
        group.setCellValueFactory(s -> s.getValue().getPropertyGroup());


        table.setItems(students);

        table.getSelectionModel().selectedItemProperty().addListener(
                new ChangeListener<Student>() {
                    @Override
                    public void changed(
                            ObservableValue<? extends Student> observableValue,
                            Student student, Student t1) {
                        if(t1 != null){
                            showStudent(t1);
                        }
                    }
                });
    }
    private void showStudent(Student value){
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.append("Студент: ");
        stringBuilder.append(value.getName());
        stringBuilder.append(" ");
        stringBuilder.append(value.getSurname());
        stringBuilder.append("; Возраст: ");
        stringBuilder.append(value.getAge());
        stringBuilder.append(" лет;");


        info.setText(stringBuilder.toString());
    }
    @FXML
    private void onAdd(){
        try{
            showDialog(null);
        }catch (Exception e){
            info.setText("Ошибка добавления");
        }
    }
    @FXML
    private void onEdit(){
        Student selectedStudent = table.getSelectionModel().getSelectedItem();
        if(selectedStudent != null){
            try{
                showDialog(selectedStudent);
            }catch (Exception e){
                info.setText("Ошибка редактирования");
            }

        }
    }
    private void showDialog(Student student) throws IOException {
        FXMLLoader loader = new FXMLLoader();
        loader.setLocation(MainController.class.getResource(
                "student-view.fxml"));
        Parent page = loader.load();
        Stage addStage = new Stage();
        addStage.setTitle("Информация о студенте");
        addStage.initModality(Modality.WINDOW_MODAL);
        addStage.initOwner((Stage) info.getScene().getWindow());
        Scene scene = new Scene(page);
        addStage.setScene(scene);
        StudentController controller = loader.getController();
        //controller.setAddStage(addStage);
        controller.setObservable(students);
        controller.setStudent(student);
        addStage.showAndWait();
    }




    @FXML
    private void onRemove(){
        int index = table.getSelectionModel().getSelectedIndex();
        if(students.size() > index){
            students.remove(index);
        }
        info.setText("Студент удален!");
    }
    @FXML
    private void onExit(){
        Stage stage = (Stage) info.getScene().getWindow();
        stage.close();
    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        initialize();
    }
}