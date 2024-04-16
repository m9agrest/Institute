module com.example.work {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.work to javafx.fxml;
    exports com.example.work;
}