package dev.bradleynewman.moneybags.app;

import dev.bradleynewman.moneybags.interfaces.GUIManager;

public class MoneybagsApp {

    public static void main(String[] args) {
        System.out.println("Starting Moneybags..."); // NOSONAR
        GUIManager guiManager = new GUIManager();
        guiManager.startGUI();
    }
}