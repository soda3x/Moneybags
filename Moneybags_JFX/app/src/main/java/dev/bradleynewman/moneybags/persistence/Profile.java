package dev.bradleynewman.moneybags.persistence;

/**
 * The Profile class is the container holding a user's information.
 * The User's information is stored in a key-value collection.
 */
public class Profile extends KeyValueStore {

    public Profile() {
        super();
    }

    public Profile(String profileString, String delimiter) {
        super(profileString, delimiter);
    }

}
