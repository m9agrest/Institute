package com.example.work;

import javafx.scene.control.Alert;
import javafx.scene.control.TextField;

public class Triangle {
    private String A, B, C;
    public Triangle(String a, String b, String c){
        A = a;
        B = b;
        C = c;
    }
    public void Check(){
        double a, b, c;
        try {
            a = Parse(A);
            b = Parse(B);
            c = Parse(C);
        }catch (Exception e){
            AlertError(e.getMessage());
            return;
        }
        if(a + b > c && b + c > a && c + a > b){
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Результат!");
            alert.setHeaderText("Ваш треугольник:");
            if(a == b && b == c){
                alert.setContentText("Равностороний!");
            }else if(a == b || b == c || c == a){
                alert.setContentText("Равноедренный!");
            }else{
                double A, B;
                if(a > b && a > c){
                    A = a*a;
                    B = b*b + c*c;
                }else if(b > a && b > c){
                    A = b*b;
                    B = a*a + c*c;
                }else{
                    A = c*c;
                    B = b*b + a*a;
                }
                if(A == B){
                    alert.setContentText("Прямоугольный!");
                }else if(A > B){
                    alert.setContentText("Тупой!");
                }else{
                    alert.setContentText("Острый!");
                }
            }
            alert.showAndWait();
        }else{
            AlertError("Треугольник с вашими сторонами, не может существовать!");
        }
    }
    private double Parse(String text) throws Exception {
        double a;
        try {
            a = Double.parseDouble(text);
        }catch (Exception e){
            throw new Exception("'" + text + "' Не является числом!");
        }
        if(a > 0){
            return a;
        }
        throw new Exception("'" + text + "' является недопустимым числом!");
    }

    private void AlertError(String text){
        Alert alert = new Alert(Alert.AlertType.ERROR);
        alert.setTitle("Ошибка!");
        alert.setHeaderText("Данные введены не коректно!");
        alert.setContentText(text);
        alert.showAndWait();
    }
}
