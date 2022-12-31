package dev.bradleynewman.moneybags.persistence;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import dev.bradleynewman.moneybags.models.Item;

/**
 * The Inventory list stores all inventory items either created on-the-fly or
 * loaded from a CSV file.
 * The Inventory is an array list of Items.
 */
public class Inventory {

    List<Item> items;

    public Inventory() {
        items = new ArrayList<>();
    }

    public Inventory(String inventoryString, String delimiter) {
        // Get each separate line as items
        List<String> loadedItems = Arrays.asList(inventoryString.split(System.getProperty("line.separator")));
        // Process each line into Items and add them to the inventory
        loadedItems.forEach(itemString -> items.add(new Item(itemString.split(delimiter))));
    }

    /**
     * Add an item to the Inventory.
     * 
     * @param item to add to the Inventory.
     */
    public void add(Item item) {
        items.add(item);
    }

    /**
     * Remove an item from the Inventory.
     * 
     * @param item to remove
     * @return the removed item
     */
    public Item remove(Item item) {
        return items.remove(items.indexOf(item));
    }

    /**
     * Retrieve item from Inventory.<br>
     * Returns null if the item could not be found.
     * 
     * @param item to get
     * @return Item
     */
    public Item get(Item item) {
        return items.get(items.indexOf(item));
    }

    /**
     * Retrieve item from Inventory.<br>
     * Returns null if the item could not be found.
     * 
     * @param itemCode
     * @return Item
     */
    public Item get(String itemCode) {
        for (Item item : items) {
            if (item.getItemCode().equals(itemCode)) {
                return item;
            }
        }
        return null;
    }

    /**
     * Get Inventory as String.
     * This will be represented in {@code itemCode;itemDesc;unitPrice} rows to ease
     * saving to file.
     */
    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        items.forEach(item -> sb.append(item.toString() + System.getProperty("line.separator")));
        return sb.toString().trim();
    }

}
