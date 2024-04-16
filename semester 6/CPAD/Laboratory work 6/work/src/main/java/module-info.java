module ru.m9studio.work {
    requires javafx.controls;
    requires javafx.fxml;


    opens ru.m9studio.work to javafx.fxml;
    exports ru.m9studio.work;
}