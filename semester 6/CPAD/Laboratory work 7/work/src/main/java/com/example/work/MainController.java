package com.example.work;

import javafx.application.Platform;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.ButtonType;
import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
public class MainController {
    public PanelController leftPanelController, rightPanelController;
    public PanelController src = null, dst = null;
    void setSrcAndDst(){
        if(leftPanelController.getSelectedFileName()==null &&
                rightPanelController.getSelectedFileName() == null){
            Alert alert = new Alert(Alert.AlertType.ERROR, "File is not choice", ButtonType.OK);
            alert.showAndWait();
            return;
        }
        if(leftPanelController.getSelectedFileName() != null){
            src = leftPanelController;
            dst = rightPanelController;
        }
        else {
            src = rightPanelController;
            dst = leftPanelController;
        }
    }
    @FXML
    void onCopy(ActionEvent event){
        setSrcAndDst();
        Path srcPath = Paths.get(src.getCurrentPath(), src.getSelectedFileName());
        Path dstPath = Paths.get(dst.getCurrentPath()).resolve(srcPath.getFileName());
        try {
            Files.copy(srcPath, dstPath);
            dst.updateList(Paths.get(dst.getCurrentPath()));
            src.updateList(Paths.get(src.getCurrentPath()));
        } catch (IOException e) {
            Alert alert = new Alert(Alert.AlertType.ERROR, "Error of copying", ButtonType.OK);
            alert.showAndWait();
        }
    }
    @FXML
    void onMove(){
        setSrcAndDst();
        Path srcPath = Paths.get(src.getCurrentPath(), src.getSelectedFileName());
        Path dstPath = Paths.get(dst.getCurrentPath()).resolve(srcPath.getFileName());
        try {
            Files.move(srcPath, dstPath);
            dst.updateList(Paths.get(dst.getCurrentPath()));
            src.updateList(Paths.get(src.getCurrentPath()));
        } catch (IOException e) {
            Alert alert = new Alert(Alert.AlertType.ERROR, "Error of moving", ButtonType.OK);
            alert.showAndWait();
        }
    }
    @FXML
    void onDelete(){
        setSrcAndDst();
        Path srcPath = Paths.get(src.getCurrentPath(), src.getSelectedFileName());
        try {
            Files.delete(srcPath);
            src.updateList(Paths.get(src.getCurrentPath()));
        } catch (IOException e) {
            Alert alert = new Alert(Alert.AlertType.ERROR, "Error of deleting", ButtonType.OK);
            alert.showAndWait();
        }
    }
    @FXML
    void onExit(){
        Platform.exit();
    }
}
