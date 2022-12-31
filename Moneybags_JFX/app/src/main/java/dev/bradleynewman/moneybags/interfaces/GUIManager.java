package dev.bradleynewman.moneybags.interfaces;

import java.io.IOException;
import java.util.Objects;

import dev.bradleynewman.moneybags.persistence.ResourceLoader;
import javafx.application.Application;
import javafx.application.Platform;
import javafx.concurrent.Task;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.layout.AnchorPane;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

/**
 * GUI Manager is a singleton class that handles all GUI Controllers.<br>
 * Creation of GUI Controllers occur here.
 */
public class GUIManager extends Application {
    private static boolean isProfileManagerWindowOpen = false;

    private LaunchScreenController launchScreenController;
    private ProfileManagerController profileManagerController;

    private static GUIManager instance;

    public static GUIManager getInstance() {
        if (Objects.isNull(instance)) {
            instance = new GUIManager();
        }
        return instance;
    }

    /**
     * Configure and start the main screen and stage.
     */
    @Override
    public void start(Stage primaryStage) throws Exception {
        FXMLLoader loader = new FXMLLoader(ResourceLoader.loadURL("fxml/main.fxml", GUIManager.class));
        launchScreenController = new LaunchScreenController(primaryStage);
        loader.setController(launchScreenController);
        Parent root = loader.load();
        Scene scene = new Scene(root);
        primaryStage.setScene(scene);
        primaryStage.setResizable(true);
        primaryStage.setMinHeight(720);
        primaryStage.setMinWidth(1280);
        primaryStage.setTitle("Moneybags");
        primaryStage.getIcons().add(new Image(ResourceLoader.load("images/moneybags-logo-5.png", GUIManager.class)));
        primaryStage.show();
        new Thread(ProgramManager.getInstance().getStartupTask()).start();
    }

    /**
     * Configure and create the Profile Manager window
     */
    public void createManageProfileWindow() {
        Platform.runLater(() -> {
            Stage stage = new Stage();
            FXMLLoader loader = new FXMLLoader(ResourceLoader.loadURL("fxml/manageProfile.fxml", GUIManager.class));
            profileManagerController = new ProfileManagerController(stage);
            loader.setControllerFactory(controller -> profileManagerController);
            Parent root = new AnchorPane();
            try {
                root = loader.load();
            } catch (IOException e) {
                System.out.println(e);
            }
            Scene scene = new Scene(root);
            scene.setFill(Color.TRANSPARENT);
            stage.setScene(scene);
            stage.setResizable(true);
            stage.setOnCloseRequest(e -> isProfileManagerWindowOpen = false);

            stage.setTitle("Moneybags - Profile Manager");
            stage.getIcons().add(new Image(ResourceLoader.load("images/moneybags-logo-5.png", this.getClass())));

            stage.show();
            isProfileManagerWindowOpen = true;
        });
    }

    /**
     * 
     * @return whether Profile Manager is open or not
     */
    public static boolean isProfileManagerWindowOpen() {
        return isProfileManagerWindowOpen;
    }

    /**
     * Start the JavaFX Application
     */
    public void startGUI() {
        Application.launch();
    }

    /**
     * 
     * @return Launch Screen Controller
     */
    public LaunchScreenController getLaunchScreenController() {
        return this.launchScreenController;
    }

    /**
     * 
     * @return Profile Manager Controller
     */
    public ProfileManagerController getProfileManagerController() {
        return this.profileManagerController;
    }

    public void setUpdatesLabelText(String text, boolean spinnerVisible) {
        if (Objects.nonNull(GUIManager.getInstance().getLaunchScreenController())) {
            Platform.runLater(() -> {
                GUIManager.getInstance().getLaunchScreenController().setUpdatesLabelText(text, spinnerVisible);
            });
        }
    }

}
