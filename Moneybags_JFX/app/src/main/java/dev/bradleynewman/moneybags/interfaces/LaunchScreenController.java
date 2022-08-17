package dev.bradleynewman.moneybags.interfaces;

import java.net.URL;
import java.util.ResourceBundle;
import io.github.palexdev.materialfx.controls.MFXButton;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.stage.Stage;

public class LaunchScreenController implements Initializable {

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
    }

}
