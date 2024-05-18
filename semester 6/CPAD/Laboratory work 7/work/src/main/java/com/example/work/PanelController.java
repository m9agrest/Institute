package com.example.work;

import javafx.beans.property.SimpleObjectProperty;
import javafx.beans.property.SimpleStringProperty;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.*;
import javafx.scene.input.MouseEvent;
import java.io.IOException;
import java.nio.file.FileSystems;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.time.format.DateTimeFormatter;
import java.util.stream.Collectors;
public class PanelController {
    @FXML
    private ComboBox<String> diskBox;
    @FXML
    private TableColumn<FileInfo, String> fileNameColumn;
    @FXML
    private TableColumn<FileInfo, Long> fileSizeColumn;
    @FXML
    private TableColumn<FileInfo, String> fileTimeColumn;
    @FXML
    private TableColumn<FileInfo, String> fileTypeColumn;
    @FXML
    private TableView<FileInfo> filesTable;
    @FXML
    private TextField pathField;
    @FXML
    void onPassUp(ActionEvent event) {
        Path upperPath = Paths.get(pathField.getText()).getParent();
        if(upperPath != null){
            updateList(upperPath);
        }
    }
    @FXML
    void onSelectDisk(ActionEvent event) {
        updateList(Paths.get(diskBox.getSelectionModel().getSelectedItem()));
    }
    @FXML
    public void initialize(){
        fileTypeColumn.setCellValueFactory(param -> new
                SimpleStringProperty(param.getValue().getType().getName()));
        fileNameColumn.setCellValueFactory(param -> new
                SimpleStringProperty(param.getValue().getFileName()));
        fileSizeColumn.setCellValueFactory(param -> new
                SimpleObjectProperty<Long>(param.getValue().getSize()));
        fileSizeColumn.setCellFactory(column -> new TableCell<>(){
            @Override
            protected void updateItem(Long size, boolean empty) {
                super.updateItem(size, empty);
                if(size==null || empty){
                    setText(null);
                    setStyle("");
                }
                else{
                    String text = String.format("%,d байт", size);
                    if(size==-1){
                        text = "[DIR]";
                    }
                    setText(text);
                }
            }
        });
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("dd.MM.YY HH:mm");
        fileTimeColumn.setCellValueFactory(param -> new
                SimpleStringProperty(param.getValue().getLastModified().format(dtf)));

        filesTable.getSortOrder().addAll(fileTypeColumn,fileNameColumn,fileSizeColumn,fileTimeColumn);
        diskBox.getItems().clear();
        for(Path p : FileSystems.getDefault().getRootDirectories()){
            diskBox.getItems().add(p.toString());
        }
        diskBox.getSelectionModel().select(1);
        updateList(Paths.get("."));
    }
    protected void updateList(Path path) {
        filesTable.getItems().clear();
        pathField.setText(path.normalize().toAbsolutePath().toString());
        try {
            filesTable.getItems().addAll(
                    Files.list(path).map(FileInfo::new)
                            .collect(Collectors.toList())
            );
        } catch (IOException e) {
            Alert alert = new Alert(Alert.AlertType.WARNING, "Unable to refresh list of files",ButtonType.OK);
            alert.showAndWait();
        }
        filesTable.sort();
    }
    @FXML
    void onTable(MouseEvent event) {
        if(event.getClickCount() == 2){
            Path path = Paths.get(pathField.getText())
                    .resolve(filesTable.getSelectionModel().getSelectedItem().getFileName());
            if(Files.isDirectory(path)){
                updateList(path);
            }
        }
    }
    public String getSelectedFileName(){
        if(!filesTable.isFocused()){
            return null;
        }
        return filesTable.getSelectionModel().getSelectedItem().getFileName();
    }
    public String getCurrentPath(){
        return pathField.getText();
    }
}