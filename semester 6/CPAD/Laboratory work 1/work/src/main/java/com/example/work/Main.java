package com.example.work;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.stage.Stage;

import java.io.IOException;

public class Main extends Application {
    @Override
    public void start(Stage stage) throws IOException {
        FXMLLoader fxmlLoader = new FXMLLoader(HelloApplication.class.getResource("main-window.fxml"));
        Scene scene = new Scene(fxmlLoader.load(), 450, 400);
        stage.setMinHeight(400);
        stage.setMinWidth(450);
        stage.setTitle("main!");
        stage.setScene(scene);
        stage.show();
    }
    public static void main(String[] args) {
        launch();
    }
}
