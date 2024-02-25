using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //attach to the item
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        //set player collider box get into the trigger box
        if(other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CircleCollider2D")
        {
            ItemUI.currentItemQuantity +=1;//pass the update number to the ItemUI script
            Destroy(gameObject);//destroy item itself
        }
    }
}
