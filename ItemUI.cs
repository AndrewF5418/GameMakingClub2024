using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemUI : MonoBehaviour
{
    //setup
    public int startItemQuantity;
    public Text itemQuantity;

    public static int currentItemQuantity;
    // Start is called before the first frame update
    void Start()
    {
        //set player's item quantity at the start
        currentItemQuantity = startItemQuantity;
    }

    // Update is called once per frame
    void Update()
    {
        //update the number of item
        itemQuantity.text = currentItemQuantity.ToString();
    }
}
