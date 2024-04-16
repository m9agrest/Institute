package com.example.work;

import javafx.fxml.FXML;
import javafx.scene.control.Slider;
import javafx.scene.effect.BoxBlur;
import javafx.scene.effect.ColorAdjust;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.AnchorPane;
import javafx.stage.FileChooser;

import java.io.File;

public class MainController {
    @FXML
    AnchorPane paneImage;
    @FXML
    private Slider sliderBlur, sliderHue, sliderSaturation, sliderBrightness, sliderContrast;
    @FXML
    private ImageView mainImage;
    @FXML
    private void onOpen(){
        FileChooser fileChooser = new FileChooser();
        fileChooser.setTitle("Open Image File");
        FileChooser.ExtensionFilter filter1 = new FileChooser.ExtensionFilter("All image files", "*.png", "*.jpg", "*.gif");
        FileChooser.ExtensionFilter filter2 = new FileChooser.ExtensionFilter("JPEG files", "*.jpg");
        FileChooser.ExtensionFilter filter3 = new FileChooser.ExtensionFilter("PNG image Files","*.png");
        FileChooser.ExtensionFilter filter4 = new FileChooser.ExtensionFilter("GIF image Files","*.gif");
        fileChooser.getExtensionFilters().addAll(filter1, filter2, filter3, filter4);
        File file = fileChooser.showOpenDialog(Main.getStage());
        if(file != null){
            Image img = new Image(file.toURI().toString());
            mainImage.setImage(img);
        }
    }
    @FXML
    private void onSource() {
        Image img = null;
        try{
            img = new Image(MainController.class.getResourceAsStream("image/img.gif"));
        }catch (Exception e){ }
        if(img != null){
            mainImage.setImage(img);
        }
    }


    BoxBlur boxBlur = new BoxBlur(10,10,0);
    ColorAdjust colorAdjust = new ColorAdjust();

    @FXML
    private void onDragBlur(){
        boxBlur.setIterations((int)sliderBlur.getValue());
        boxBlur.setInput(colorAdjust);
        mainImage.setEffect(boxBlur);
    }
    @FXML
    private void onDragAdjust(){
        colorAdjust.setHue(sliderHue.getValue());
        colorAdjust.setSaturation(sliderSaturation.getValue());
        colorAdjust.setBrightness(sliderBrightness.getValue());
        colorAdjust.setContrast(sliderContrast.getValue());
        colorAdjust.setInput(boxBlur);
        mainImage.setEffect(colorAdjust);
    }

    @FXML
    private  void onExit(){
        Main.getStage().close();
    }
    @FXML
    private  void onReset(){
        sliderBlur.setValue(0);
        sliderHue.setValue(0);
        sliderBrightness.setValue(0);
        sliderContrast.setValue(0);
        sliderSaturation.setValue(0);
        colorAdjust = new ColorAdjust();
        mainImage.setEffect(null);
    }

}
