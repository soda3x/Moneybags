package dev.bradleynewman.moneybags.interfaces;

import java.io.IOException;
import java.net.URL;
import java.util.Objects;
import java.util.Scanner;

import javafx.concurrent.Task;

public class ProgramManager {

    private static ProgramManager instance;

    public static ProgramManager getInstance() {
        if (Objects.isNull(instance)) {
            instance = new ProgramManager();
        }
        return instance;
    }

    /**
     * This method reads the required files for starting the app cleanly.
     * 
     */
    private void startup() {
        System.out.println("Doing startup task...");
        checkForUpdates();
        loadLastUsedProfile();
        // TODO: Set First Name / Company name on title screen
        // TODO: Load last used Inventory from path stored in currentInventory file
        // TODO: Load 5 recent invoices or quotes
        System.out.println("Moneybags has now started.");
    }

    private void loadLastUsedProfile() {
        // if last profile file exists
        // load the last used profile file contents into a string
        // using that path, load the profile file it references
        // load THAT files contents as our profile

        // if last profile file doesn't exist
        // update title screen to instruct user to create a profile
    }

    private void checkForUpdates() {
        GUIManager.getInstance().setUpdatesLabelText("Hold tight! We're making sure you're on the latest version...",
                true);
        try {
            URL url = new URL("https://raw.githubusercontent.com/soda3x/Moneybags/master/version.txt");
            Scanner s = new Scanner(url.openStream());
            GUIManager.getInstance().setUpdatesLabelText("Latest version is " + s.nextLine(), false);
        } catch (IOException ex) {
            GUIManager.getInstance().setUpdatesLabelText(
                    "Hmm, we were unable to check for updates, please check your network connection.\r\nYou may not have the latest version of Moneybags.",
                    false);
        }
    }

    public Task<Void> getStartupTask() {
        return new Task<Void>() {
            @Override
            protected Void call() throws Exception {
                // Run Program Manager start-up sequence
                ProgramManager.getInstance().startup();
                return null;
            }
        };
    }
}
