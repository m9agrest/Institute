module com.example.work {
    requires javafx.controls;
    requires javafx.fxml;
    requires java.sql;


    opens com.example.work.controllers to javafx.fxml;
    exports com.example.work;
    exports com.example.work.utils;
    opens com.example.work.utils to javafx.fxml;
}