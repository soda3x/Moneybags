package dev.bradleynewman.moneybags.persistence;

import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * The Persona class is the container holding a user's information.
 * The User's information is stored in a key-value collection.
 */
public class Persona {
    private Map<String, String> keyValueStore;

    public Persona() {
        keyValueStore = new HashMap<>();
    }

    /**
     * Create Persona object from String representation.
     * This will create a Persona object with the string contents stored in the
     * key-value store.
     * 
     * @param personaString to import
     */
    public Persona(String personaString) {
        keyValueStore = new HashMap<>();
        // Get each separate line as key,values
        List<String> loadedKeyValues = Arrays.asList(personaString.split(System.getProperty("line.separator")));
        // Process each of those key values and put them on the store
        loadedKeyValues.forEach(entry -> {
            String[] kv = entry.split(";");
            keyValueStore.put(kv[0], kv[1]);
        });
    }

    /**
     * Add a field to the Persona.
     * 
     * @param key   to retrieve value with
     * @param value to assign to key
     */
    public void put(String key, String value) {
        keyValueStore.put(key, value);
    }

    /**
     * Remove field from Persona
     * 
     * @param key to remove
     * @return the removed value associated with the {@code key}
     */
    public String remove(String key) {
        return keyValueStore.remove(key);
    }

    /**
     * Retrieve value belonging to {@code key}.
     * 
     * @param key mapping
     * @return value belonging to {@code key}.
     */
    public String get(String key) {
        return keyValueStore.get(key);
    }

    /**
     * Get Persona as String.
     * This will be represented in {@code k,v} rows to ease saving to file.
     */
    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        keyValueStore.forEach((k, v) -> sb.append(String.join(";", k, v) + System.getProperty("line.separator")));
        return sb.toString().trim();
    }
}
