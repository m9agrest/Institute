package com.example.laboratorywork7;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.scene.layout.Pane;
import javafx.stage.Stage;

public class Window extends Application {
    private TextField inputA, inputB, inputC;
    private Click click;
    public String getA(){
        return inputA.getText();
    }
    public String getB(){
        return inputB.getText();
    }
    public String getC(){
        return inputC.getText();
    }
    @Override
    public void start(Stage stage) throws Exception {
        stage.setTitle("Laboratory work 7");
        final int windowHeight = 190;
        final int windowWidth = 250;
        final int elementHeight = 25;
        final int elementWidth = 200;
        final int elementX = 20;

        click = new Click(this);


        stage.setHeight(windowHeight);
        stage.setMaxHeight(windowHeight);
        stage.setMinHeight(windowHeight);
        stage.setWidth(windowWidth);
        stage.setMaxWidth(windowWidth);
        stage.setMinWidth(windowWidth);
        Pane root = new Pane();


        inputA = new TextField();
        inputA.setPrefHeight(elementHeight);
        inputA.setPrefWidth(elementWidth);
        inputA.setPromptText("Введите сторону A");
        inputA.setLayoutX(elementX);
        inputA.setLayoutY(10);

        inputB = new TextField();
        inputB.setPrefHeight(elementHeight);
        inputB.setPrefWidth(elementWidth);
        inputB.setPromptText("Введите сторону B");
        inputB.setLayoutX(elementX);
        inputB.setLayoutY(45);

        inputC = new TextField();
        inputC.setPrefHeight(elementHeight);
        inputC.setPrefWidth(elementWidth);
        inputC.setPromptText("Введите сторону C");
        inputC.setLayoutX(elementX);
        inputC.setLayoutY(80);

        Button btn = new Button();
        btn.setPrefHeight(elementHeight);
        btn.setPrefWidth(elementWidth);
        btn.setText("Проверить");
        btn.setLayoutX(elementX);
        btn.setLayoutY(115);
        btn.setOnMouseClicked(click);


        root.getChildren().addAll(inputA, inputB, inputC, btn);
        stage.setScene(new Scene(root, windowHeight, windowWidth));
        stage.show();
    }


    public static void main(String[] arg){
        launch();
    }
}
