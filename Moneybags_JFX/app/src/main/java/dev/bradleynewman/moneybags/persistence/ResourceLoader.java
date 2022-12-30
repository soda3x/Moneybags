package dev.bradleynewman.moneybags.persistence;

import java.io.InputStream;
import java.net.URL;

public class ResourceLoader {

    private ResourceLoader() {
        // Disable no-args constructor
    }

    /**
     * Load resource from URL based on relative path from the class calling this
     * method.
     * 
     * @param path  to resource
     * @param clazz class calling this method
     * @return resource
     */
    public static URL loadURL(String path, Class<?> clazz) {
        return clazz.getResource(path);
    }

    /**
     * Load resource from String {@code path} based on relative path from the class
     * calling this method.
     * 
     * @param path  to resource
     * @param clazz class calling this method
     * @return resource
     */
    public static String load(String path, Class<?> clazz) {
        return loadURL(path, clazz).toString();
    }

    public static InputStream loadStream(String name, Class<?> clazz) {
        return clazz.getResourceAsStream(name);
    }
}
