package dev.bradleynewman.moneybags.app;

import dev.bradleynewman.moneybags.interfaces.GUIManager;

public class MoneybagsApp {

    public static void main(String[] args) {
        System.out.println("Starting Moneybags..."); // NOSONAR
        GUIManager guiManager = new GUIManager();
        guiManager.startGUI();
        startup(guiManager);
    }

    /**
     * This method reads the required files for starting the app cleanly.
     * 
     * @param guiManager to use
     */
    private static void startup(GUIManager guiManager) {
        // TODO: Load last used Persona from path stored in currentPersona file
        // TODO: Set First Name / Company name on title screen
        // TODO: Load last used Inventory from path stored in currentInventory file
        // TODO: Load 5 recent invoices or quotes
    }

    private void loadLastUsedPersona() {
        // if last persona file exists
            // load the last used persona file contents into a string
                // using that path, load the persona file it references
                    // load THAT files contents as our persona

        // if last persona file doesn't exist
            // update title screen to instruct user to create a persona
    }
}