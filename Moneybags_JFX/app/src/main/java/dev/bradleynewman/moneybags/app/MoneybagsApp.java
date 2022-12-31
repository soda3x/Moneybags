package dev.bradleynewman.moneybags.app;

import dev.bradleynewman.moneybags.interfaces.GUIManager;

public class MoneybagsApp {

    public static final String VERSION = "1.0";

    public static void main(String[] args) {
        System.out.println("Starting Moneybags..."); // NOSONAR
        GUIManager.getInstance().startGUI();
    }
}