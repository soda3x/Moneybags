package dev.bradleynewman.moneybags.interfaces;

import dev.bradleynewman.moneybags.persistence.ResourceLoader;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

/**
 * GUI Manager handles all GUI Controllers.<br>
 * Creation of GUI Controllers occur here.
 */
public class GUIManager extends Application {

    private LaunchScreenController launchScreenController;

    /**
     * Configure and start the main screen and stage.
     */
    @Override
    public void start(Stage primaryStage) throws Exception {
        FXMLLoader loader = new FXMLLoader(ResourceLoader.loadURL("fxml/main.fxml", this.getClass()));
        launchScreenController = new LaunchScreenController(primaryStage);
        loader.setControllerFactory(controller -> launchScreenController);
        Parent root = loader.load();
        Scene scene = new Scene(root);
        scene.setFill(Color.TRANSPARENT);
        primaryStage.setScene(scene);
        primaryStage.setResizable(false);
        primaryStage.setTitle("Moneybags");
        primaryStage.getIcons().add(new Image(ResourceLoader.load("images/moneybags-logo-5.png", this.getClass())));
        primaryStage.show();
    }

    /**
     * Start the JavaFX Application
     */
    public void startGUI() {
        Application.launch();
    }

    public LaunchScreenController getLaunchScreenController() {
        return launchScreenController;
    }

}
