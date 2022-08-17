package dev.bradleynewman.moneybags.interfaces;

import java.io.InputStream;
import java.net.URL;

public class ResourceLoader {

    private ResourceLoader() {
        // Disable no-args constructor
    }

    public static URL loadURL(String path) {
        return ResourceLoader.class.getResource(path);
    }

    public static String load(String path) {
        return loadURL(path).toString();
    }

    public static InputStream loadStream(String name) {
        return ResourceLoader.class.getResourceAsStream(name);
    }
}
