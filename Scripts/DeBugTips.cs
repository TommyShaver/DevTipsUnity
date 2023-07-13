using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeBugTips : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // this is some code to help debug more items with better code.
        // here are all the codes for debug message.
        // <b></b> = bold word
        // <size=#></size> = font size
        // <color=(color name)></color>


        // Bais Message
        Debug.Log("This is a basic message");

        //Bolding words in the debug log
        Debug.Log("This is a meesage with a <b>message</b>");

        // Chaning Size
        Debug.Log("This is a message that changes <size=20>size</size>");

        // Chaning color
        Debug.Log("This changes <color=Yellow>color</color>");

        //Error Log Message
        Debug.LogError("This is an Error message"); 
    }

   
}
