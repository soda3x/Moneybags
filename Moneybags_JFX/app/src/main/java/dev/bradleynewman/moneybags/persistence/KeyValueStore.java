package dev.bradleynewman.moneybags.persistence;

import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public abstract class KeyValueStore {

    private Map<String, String> map;

    /**
     * Create empty KVStore object.
     */
    protected KeyValueStore() {
        map = new HashMap<>();
    }

    /**
     * Create KVStore object from String.
     * This will create a KVStore with the {@code delimiter} separated contents of
     * the string.<br>
     * Each new line is read in as a single key value pair.
     * 
     * @param kvString  to import
     * @param delimiter to split the Key and Value
     */
    protected KeyValueStore(String kvString, String delimiter) {
        super();
        // Get each separate line as key,values
        List<String> loadedKeyValues = Arrays.asList(kvString.split(System.getProperty("line.separator")));
        // Process each of those key values and put them on the store
        loadedKeyValues.forEach(entry -> {
            String[] kv = entry.split(delimiter);
            getMap().put(kv[0], kv[1]);
        });
    }

    /**
     * @return internal HashMap
     */
    protected Map<String, String> getMap() {
        return map;
    }

    /**
     * Add a field to the KV Store.
     * 
     * @param key   to retrieve value with
     * @param value to assign to key
     */
    public void put(String key, String value) {
        map.put(key, value);
    }

    /**
     * Remove field from KV Store
     * 
     * @param key to remove
     * @return the removed value associated with the {@code key}
     */
    public String remove(String key) {
        return map.remove(key);
    }

    /**
     * Retrieve value belonging to {@code key}.
     * 
     * @param key mapping
     * @return value belonging to {@code key}.
     */
    public String get(String key) {
        return map.get(key);
    }

    /**
     * Get KV Store as String.
     * This will be represented in {@code k,v} rows to ease saving to file.
     */
    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        map.forEach((k, v) -> sb.append(String.join(";", k, v) + System.getProperty("line.separator")));
        return sb.toString().trim();
    }

}
