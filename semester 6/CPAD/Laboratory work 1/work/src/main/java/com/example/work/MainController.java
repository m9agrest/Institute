package com.example.work;

import javafx.fxml.FXML;
import javafx.scene.control.Slider;
import javafx.scene.control.TextField;

public class MainController {
    @FXML
    private TextField InputA, InputB, InputC;
    @FXML
    private Slider SliderA, SliderB, SliderC;
    @FXML
    private void Check(){
        Triangle triangle = new Triangle(InputA.getText(), InputB.getText(), InputC.getText());
        triangle.Check();
    }
    @FXML
    private void DragA(){
        Drag(InputA, SliderA.getValue());
    }
    @FXML
    private void DragB(){
        Drag(InputB, SliderB.getValue());
    }
    @FXML
    private void DragC(){
        Drag(InputC, SliderC.getValue());
    }
    private void Drag(TextField field, double value){
        value -= value % 0.1;
        field.setText(value + "");
    }
}
