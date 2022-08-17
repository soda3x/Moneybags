package dev.bradleynewman.moneybags.persistence;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

/**
 * Static class for file loading and saving.
 */
public class IOTools {

    public enum WriteMode {
        OVERWRITE, APPEND
    }

    private static final Logger LOGGER = LogManager.getLogger(IOTools.class);

    private IOTools() {
        // Disable no-args constructor
    }

    /**
     * Read file contents into a String.<br>
     * <br>
     * <b>Note: This method will return {@code null} if file is unable to be
     * read.</b>
     * 
     * @param path to file.
     * @return String containing file contents.<br>
     *         Null if the file was unable to be read.
     */
    public static String readFileIntoString(String path) {
        try {
            return Files.readString(Paths.get(path));
        } catch (IOException e) {
            LOGGER.error("Unable to read file", e);
            return null;
        }
    }

    /**
     * Save string contents to a file, with the choice of either overwriting
     * existing contents or appending.
     * 
     * @param contents  to save to the file.
     * @param path      to file to be saved to, this file will be created if it
     *                  doesn't already exist.
     * @param writeMode File will be overwritten if it exists if {@code OVERWRITE},
     *                  otherwise file will be appended to if {@code APPEND}.
     * @return true if the file was successfully saved, false otherwise.
     */
    public static boolean saveStringToFile(String contents, String path, WriteMode writeMode) {
        try {
            if (writeMode == WriteMode.APPEND) {
                Files.writeString(Paths.get(path), contents, StandardOpenOption.CREATE, StandardOpenOption.APPEND);
            } else {
                Files.writeString(Paths.get(path), contents);
            }
            return true;
        } catch (IOException e) {
            LOGGER.error("Unable to write file", e);
            return false;
        }
    }

}
