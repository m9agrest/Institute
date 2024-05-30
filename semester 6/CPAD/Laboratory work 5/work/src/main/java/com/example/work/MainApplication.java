package com.example.work;
import com.example.work.utils.DataBaseHelper;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.stage.Stage;
import java.io.IOException;
import java.sql.Connection;
import java.sql.SQLException;

public class MainApplication extends Application {
    public static Connection getConnection(){
        return connection;
    }
    private static Connection connection;
    public static Stage getMainStage() {
        return mainStage;
    }
    private static Stage mainStage;
    @Override
    public void stop() throws Exception {
        if(connection != null){
            connection.close();
        }
        super.stop();
    }
    @Override
    public void start(Stage stage) throws IOException {
        try{
            connection = DataBaseHelper.getConnection();
        }
        catch (SQLException e){
            System.out.println(e.getMessage());
            // Alert
        }
        mainStage = stage;
        FXMLLoader fxmlLoader = new FXMLLoader(MainApplication.class.getResource("main.fxml"));
        Scene scene = new Scene(fxmlLoader.load(), 800, 600);
        stage.setMinWidth(800);
        stage.setMinHeight(600);
        stage.setTitle("Табличный вид!");
        stage.setScene(scene);
        stage.show();
    }
    public static void main(String[] args) throws ClassNotFoundException {
        //Class.forName("com.mysql.jdbc");
        launch();
    }
}
