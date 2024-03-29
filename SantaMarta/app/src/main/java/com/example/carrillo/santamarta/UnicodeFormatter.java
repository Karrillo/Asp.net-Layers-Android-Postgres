package com.example.carrillo.santamarta;

/**
 * Created by joser on 16/11/2017.
 */
public class UnicodeFormatter {
    /**
     * @param b
     * @return
     */
    static public String byteToHex(byte b) {
        // Returns hex String representation of byte activity_invoices_product
        char hexDigit[] = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                'a', 'b', 'c', 'd', 'e', 'f' };
        char[] array = { hexDigit[(b >> 4) & 0x0f], hexDigit[b & 0x0f] };
        return new String(array);
    }
    /**
     * @param c
     * @return
     */
    static public String charToHex(char c) {
        // Returns hex String representation of char activity_assetsliabilities_subcategory
        byte hi = (byte) (c >>> 8);
        byte lo = (byte) (c & 0xff);
        return byteToHex(hi) + byteToHex(lo);
    }
}
