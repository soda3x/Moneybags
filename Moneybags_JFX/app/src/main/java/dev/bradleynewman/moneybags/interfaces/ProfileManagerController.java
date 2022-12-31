package dev.bradleynewman.moneybags.interfaces;

import java.net.URL;
import java.util.ResourceBundle;

import io.github.palexdev.materialfx.controls.MFXButton;
import io.github.palexdev.materialfx.controls.MFXTableView;
import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.stage.Stage;

public class ProfileManagerController implements Initializable {

    private StringProperty profileInfoProperty;

    protected ProfileManagerController(Stage stage) {
        // TODO: Implement this
    }

    @Override
    public void initialize(URL location, ResourceBundle resources) {
        // TODO: Implement this
        this.profileInfoProperty = new SimpleStringProperty(
                "Create and manage your Profile here. A profile contains all of your personal information which is to be displayed on your invoices and quotes.");
        this.profileInformationLbl.textProperty().bind(this.profileInfoProperty);
    }

    @FXML
    private MFXButton createNewPersonaBtn;

    @FXML
    private MFXButton loadPersonaFileBtn;

    @FXML
    private MFXTableView<?> personaKVView;

    @FXML
    private Label profileInformationLbl;

    @FXML
    private MFXButton saveAndUsePersonaBtn;

}