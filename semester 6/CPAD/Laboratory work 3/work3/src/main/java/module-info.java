module com.example.work3 {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.work3 to javafx.fxml;
    exports com.example.work3;
}