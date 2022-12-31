package dev.bradleynewman.moneybags.persistence;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

class ProfileTests {

    private static final String PROFILE_STR = "AddressLine2;Ganton, Los Santos"
            + "\r\nAddressLine1;1 Grove St"
            + "\r\nFirstName;John"
            + "\r\nPhoneNumber;12345678"
            + "\r\nLastName;Appleseed";

    @Test
    void testProfilePutAndGet() {
        Profile p = new Profile();
        p.put("Hello", "World");
        Assertions.assertEquals("World", p.get("Hello"));
        // Cannot retrieve value of non-existent key
        Assertions.assertNotEquals("Hello", p.get("World"));
        // Cannot retrieve value of non-existent key
        Assertions.assertNull(p.get("Hello World"));
    }

    @Test
    void testProfileFromString() {
        Profile p = new Profile(PROFILE_STR, ";");
        Assertions.assertEquals("Ganton, Los Santos", p.get("AddressLine2"));
        Assertions.assertEquals("1 Grove St", p.get("AddressLine1"));
        Assertions.assertEquals("John", p.get("FirstName"));
        Assertions.assertEquals("12345678", p.get("PhoneNumber"));
        Assertions.assertEquals("Appleseed", p.get("LastName"));
    }

    @Test
    void testProfileToString() {
        Profile p = new Profile();
        p.put("FirstName", "John");
        p.put("LastName", "Appleseed");
        p.put("AddressLine1", "1 Grove St");
        p.put("AddressLine2", "Ganton, Los Santos");
        p.put("PhoneNumber", "12345678");
        Assertions.assertEquals(PROFILE_STR, p.toString());
    }
}
