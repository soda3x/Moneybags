package dev.bradleynewman.moneybags.persistence;

import java.util.Arrays;
import java.util.List;

/**
 * The Persona class is the container holding a user's information.
 * The User's information is stored in a key-value collection.
 */
public class Persona extends KeyValueStore {

    public Persona() {
        super();
    }

    public Persona(String personaString, String delimiter) {
        super(personaString, delimiter);
    }

}
