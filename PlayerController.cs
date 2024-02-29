using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //trait
    public float moveSpeed;
    //animator
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent(Animator);
        anim.SetBool("isMovingUpDown",false);
        anim.SetBool("isMovingLeft",false);
        anim.SetBool("isMovingRight",false); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = new Vector3(0f,0f,0f);
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        transform.position += moveInput * moveSpeed*Time.deltaTime;
        // set bool for moving animation by if condition 
        if(moveInput != Vector3.zero){
            if(moveInput.x>0 ||
            (moveInput.x>0 && Input.GetAxisRaw("Vertical")==1)||
            (moveInput.x>0 && Input.GetAxisRaw("Vertical")==-1)
            )
        {
            anim.SetBool("isMovingRight",true);
        }
            if(moveInput.x<0||
            (moveInput.x<0 && Input.GetAxisRaw("Vertical")==1)||
            (moveInput.x<0 && Input.GetAxisRaw("Vertical")==-1)
            )
        {
            anim.SetBool("isMovingLeft",true);
        }
            if(Input.GetAxisRaw("Vertical")==1 || Input.GetAxisRaw("Vertical")==-1)
        {
            anim.SetBool("isMovingUpDown",true);
        }
        }

        else{
            anim.SetBool("isMovingUpDown",false);
            anim.SetBool("isMovingLeft",false);
            anim.SetBool("isMovingRight",false); 
        }    

}
}
