package dev.bradleynewman.moneybags.models;

import java.util.Objects;

public class Item {

    private static final int VALID_NO_OF_FIELDS = 3;

    private String itemCode;
    private String itemDescription;
    private double unitPrice;

    /**
     * Item for use in invoices and the Inventory (which is a collection of unique
     * items).
     * 
     * @param itemCode        to use
     * @param itemDescription to use
     * @param unitPrice       to use
     */
    public Item(String itemCode, String itemDescription, double unitPrice) {
        this.itemCode = itemCode;
        this.itemDescription = itemDescription;
        this.unitPrice = unitPrice;
    }

    /**
     * Create Item from a String array created from splitting a CSV string.
     * 
     * @param fields a String array containg the item code, description and unit
     *               price of the item.
     * @throws IllegalArgumentException if the item cannot be created due to
     *                                  either
     *                                  too many / too little fields, or the unit
     *                                  price cannot be parsed as a number.
     */
    public Item(String[] fields) {
        if (Objects.isNull(fields) || fields.length != VALID_NO_OF_FIELDS) {
            throw new IllegalArgumentException(
                    "Unable to create item from this array of strings as there are either too little or too many arguments.");
        }
        try {
            this.itemCode = fields[0];
            this.itemDescription = fields[1];
            this.unitPrice = Double.parseDouble(fields[2]);
        } catch (NumberFormatException e) {
            throw new IllegalArgumentException(
                    "Unable to create item from this array of strings. The unit price is not a valid number.");
        }
    }

    /**
     * 
     * @return Item Code
     */
    public String getItemCode() {
        return this.itemCode;
    }

    /**
     * 
     * @return Item Description
     */
    public String getItemDesc() {
        return this.itemDescription;
    }

    /**
     * 
     * @return Unit Price (without currency)
     */
    public double getUnitPrice() {
        return this.unitPrice;
    }

    @Override
    public String toString() {
        return String.join(";", this.getItemCode(), this.getItemDesc(), Double.toString(this.getUnitPrice()));
    }
}
