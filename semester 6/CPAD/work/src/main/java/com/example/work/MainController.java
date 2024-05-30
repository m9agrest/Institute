package com.example.work;

import com.example.work.struct.Student;
import javafx.beans.property.IntegerProperty;
import javafx.beans.property.SimpleIntegerProperty;
import javafx.beans.property.SimpleStringProperty;
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
    private TableColumn<Student, String> name, surname;
    @FXML
    private TableColumn<Student, Integer> age;
    Service service = new Service("localhost", (short)3306, "java_work", "root", "");
    @FXML
    void initialize(){

        service.connection();

        surname.setCellValueFactory(s -> new SimpleStringProperty(s.getValue().getName()));
        name.setCellValueFactory(s -> new SimpleStringProperty(s.getValue().getSurname()));
        age.setCellValueFactory(s -> (new SimpleIntegerProperty(s.getValue().getAge())).asObject());

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
        controller.setService(service);
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