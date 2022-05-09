using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemID {

    int idCode;
    GameObject image;
    GameObject empty;

    public ItemID(int idNum, GameObject imageObject) {

        idCode = idNum;
        image = imageObject;

        }
    public ItemID(int idNum) {

        idCode = idNum;

        }


    }
