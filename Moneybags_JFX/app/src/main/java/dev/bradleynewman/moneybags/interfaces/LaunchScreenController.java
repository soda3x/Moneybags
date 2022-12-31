package dev.bradleynewman.moneybags.interfaces;

import java.net.URL;
import java.util.ResourceBundle;

import io.github.palexdev.materialfx.controls.MFXButton;
import io.github.palexdev.materialfx.controls.MFXSpinner;
import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.scene.layout.StackPane;
import javafx.stage.Stage;

public class LaunchScreenController implements Initializable {

    private StringProperty titleProperty;
    private StringProperty subtitleProperty;
    private StringProperty profileButtonTextProperty;
    private StringProperty updateProperty;

    @FXML
    private StackPane container;
    @FXML
    private MFXButton loadInvoiceBtn;
    @FXML
    private MFXButton loadQuoteBtn;
    @FXML
    private MFXButton manageInventoryBtn;
    @FXML
    private MFXButton manageProfileBtn;
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
    private MFXSpinner updatesSpinner;
    @FXML
    private Label checkingForUpdatesLbl;

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
    void manageProfilePressed(ActionEvent event) {
        if (!GUIManager.isProfileManagerWindowOpen()) {
            GUIManager.getInstance().createManageProfileWindow();
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
        this.subtitleProperty = new SimpleStringProperty("Welcome to Moneybags, create a Profile to begin.");
        this.profileButtonTextProperty = new SimpleStringProperty("Profile Manager");
        this.updateProperty = new SimpleStringProperty("Starting Moneybags...");
        this.titleLabel.textProperty().bind(this.titleProperty);
        this.subtitleLabel.textProperty().bind(this.subtitleProperty);
        this.manageProfileBtn.textProperty().bind(this.profileButtonTextProperty);
        this.checkingForUpdatesLbl.textProperty().bind(this.updateProperty);
    }

    public void setTitle(String title) {
        this.titleProperty.set(title);
    }

    public void setSubtitle(String subtitle) {
        this.subtitleProperty.set(subtitle);
    }

    public void setProfileBtnText(String buttonText) {
        this.profileButtonTextProperty.set(buttonText);
    }

    public void setUpdatesLabelText(String updatesText, boolean spinnerVisible) {
        this.updateProperty.set(updatesText);
        this.updatesSpinner.setVisible(spinnerVisible);
    }

}
