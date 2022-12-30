package dev.bradleynewman.moneybags.interfaces;

import java.io.IOException;
import java.net.URL;
import java.util.Map;
import java.util.ResourceBundle;

import dev.bradleynewman.moneybags.persistence.ResourceLoader;
import io.github.palexdev.materialfx.controls.MFXButton;
import io.github.palexdev.materialfx.controls.MFXTableColumn;
import io.github.palexdev.materialfx.controls.MFXTableView;
import io.github.palexdev.materialfx.dialogs.MFXGenericDialog;
import io.github.palexdev.materialfx.dialogs.MFXGenericDialogBuilder;
import io.github.palexdev.materialfx.dialogs.MFXStageDialog;
import io.github.palexdev.materialfx.effects.DepthLevel;
import io.github.palexdev.materialfx.enums.ButtonType;
import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.StackPane;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

public class LaunchScreenController implements Initializable {

    private StringProperty titleProperty;
    private StringProperty subtitleProperty;
    private StringProperty personaButtonTextProperty;

    private boolean windowOpen = false;

    @FXML
    private StackPane container;
    @FXML
    private MFXButton loadInvoiceBtn;
    @FXML
    private MFXButton loadQuoteBtn;
    @FXML
    private MFXButton manageInventoryBtn;
    @FXML
    private MFXButton managePersonaBtn;
    @FXML
    private MFXButton newInvoiceBtn;
    @FXML
    private MFXButton newQuoteBtn;
    @FXML
    private MFXButton recent1;
    @FXML
    private MFXButton recent2;
    @FXML
    private MFXButton recent3;
    @FXML
    private MFXButton recent4;
    @FXML
    private MFXButton recent5;
    @FXML
    private Label titleLabel;
    @FXML
    private Label subtitleLabel;

    @FXML
    void loadInvoicePressed(ActionEvent event) {

    }

    @FXML
    void loadQuotePressed(ActionEvent event) {

    }

    @FXML
    void manageInventoryPressed(ActionEvent event) {

    }

    @FXML
    void managePersonaPressed(ActionEvent event) {
        if (!windowOpen) {
            createManagePersonaWindow();
        }
    }

    @FXML
    void newInvoicePressed(ActionEvent event) {

    }

    @FXML
    void newQuotePressed(ActionEvent event) {

    }

    protected LaunchScreenController(Stage stage) {
        // TODO: Implement this
    }

    @Override
    public void initialize(URL location, ResourceBundle resources) {
        // TODO: Implement this
        this.titleProperty = new SimpleStringProperty("Hi! 👋");
        this.subtitleProperty = new SimpleStringProperty("Welcome to Moneybags, create a Persona to begin.");
        this.personaButtonTextProperty = new SimpleStringProperty("Create Persona");
        this.titleLabel.textProperty().bind(this.titleProperty);
        this.subtitleLabel.textProperty().bind(this.subtitleProperty);
        this.managePersonaBtn.textProperty().bind(this.personaButtonTextProperty);
    }

    public void setTitle(String title) {
        this.titleProperty.set(title);
    }

    public void setSubtitle(String subtitle) {
        this.subtitleProperty.set(subtitle);
    }

    public void setPersonaBtnText(String buttonText) {
        this.personaButtonTextProperty.set(buttonText);
    }

    public void createManagePersonaWindow() {
        FXMLLoader loader = new FXMLLoader(ResourceLoader.loadURL("fxml/managePersona.fxml", this.getClass()));
        Parent root = new AnchorPane();
        try {
        root = loader.load();
        } catch (IOException e) {
            System.out.println(e);
        }
        Stage stage = new Stage();
        Scene scene = new Scene(root);
        scene.setFill(Color.TRANSPARENT);
        stage.setScene(scene);
        stage.setResizable(true);
        stage.setOnCloseRequest(e -> windowOpen = false);

        stage.setTitle("Moneybags - Manage Persona");
        stage.getIcons().add(new Image(ResourceLoader.load("images/moneybags-logo-5.png", this.getClass())));

        stage.show();
        windowOpen = true;
    }

}
