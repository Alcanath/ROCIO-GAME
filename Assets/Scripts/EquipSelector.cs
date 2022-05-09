using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipSelector : MonoBehaviour
{
    public int gunSelect = 1;

    void Update()
    {

        if (Input.GetKey(KeyCode.Alpha1)) {
            gunSelect = 1;
            } else if (Input.GetKey(KeyCode.Alpha2)) {
            gunSelect = 2;
            } else if (Input.GetKey(KeyCode.Alpha3)) {
            gunSelect = 3;
            } else if (Input.GetKey(KeyCode.Alpha4)) {
            gunSelect = 4;
            } else if (Input.GetKey(KeyCode.Alpha5)) {
            gunSelect = 5;
            } else if (Input.GetKey(KeyCode.Alpha6)) {
            gunSelect = 6;
            } else if (Input.GetKey(KeyCode.Alpha7)) {
            gunSelect = 7;
            } else if (Input.GetKey(KeyCode.Alpha8)) {
            gunSelect = 8;
            } else if (Input.GetKey(KeyCode.Alpha9)) {
            gunSelect = 9;
            }


        }
}
