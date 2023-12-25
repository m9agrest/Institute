package com.example.laboratorywork7;

import javafx.event.EventHandler;
import javafx.scene.control.Alert;
import javafx.scene.input.MouseEvent;

public class Click implements EventHandler<MouseEvent> {
    private Window app;
    public Click(Window app){
        this.app = app;
    }
    @Override
    public void handle(MouseEvent mouseEvent) {
        int a = 0, b = 0, c = 0;
        try {
            a = Integer.parseInt(app.getA());
        } catch (Exception e){
            AlertErrorParse("A", app.getA());
            return;
        }
        try {
            b = Integer.parseInt(app.getB());
        } catch (Exception e){
            AlertErrorParse("B", app.getB());
            return;
        }
        try {
            c = Integer.parseInt(app.getC());
        } catch (Exception e){
            AlertErrorParse("C", app.getC());
            return;
        }
        if(a <= 0){
            AlertErrorValid("A", app.getA());
            return;
        }
        if(b <= 0){
            AlertErrorValid("B", app.getB());
            return;
        }
        if(c <= 0){
            AlertErrorValid("C", app.getC());
            return;
        }
        Alert alert = new Alert(Alert.AlertType.INFORMATION);
        alert.setTitle("Результат проверки");
        if(a + b > c){
            alert.setHeaderText("Ваши данные верны!");
            alert.setContentText("Треугольник с введенными данными может существовать");
        }else{
            alert.setHeaderText("Ваши данные не верны!");
            alert.setContentText("Треугольник с введенными данными не может существовать");
        }
        alert.showAndWait();
    }
    private void AlertErrorParse(String name, String value){
        Alert alert = new Alert(Alert.AlertType.ERROR);
        alert.setTitle("Ошибка!");
        alert.setHeaderText("Данные введены не коректно!");
        alert.setContentText("В строке "+name+" введено: " + value + ", что в свою очередь не является числом!");
        alert.showAndWait();
    }
    private void AlertErrorValid(String name, String value){
        Alert alert = new Alert(Alert.AlertType.ERROR);
        alert.setTitle("Ошибка!");
        alert.setHeaderText("Данные введены не коректно!");
        alert.setContentText("В строке "+name+" введено: " + value + ", введите другое число, которое больше 0!");
        alert.showAndWait();
    }
}
