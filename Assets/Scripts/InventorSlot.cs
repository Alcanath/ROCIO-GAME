using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot {
    ItemID item;
    Vector2 pixelCoord;

    InventorySlot(ItemID item, Vector2 pixelCoord) {

        item = this.item;
        pixelCoord = this.pixelCoord;

        }
    ItemID getItemId() {
        return this.item;
        }

    Vector2 getPixelCoord() {
        return this.pixelCoord;
        }


    }
