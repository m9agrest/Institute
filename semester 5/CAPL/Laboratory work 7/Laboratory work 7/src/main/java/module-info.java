module com.example.laboratorywork7 {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.laboratorywork7 to javafx.fxml;
    exports com.example.laboratorywork7;
}