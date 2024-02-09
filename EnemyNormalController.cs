using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNormalController : MonoBehaviour
{
    public Rigidbody2D theRigidBody;
    public float moveSpeed;
    private Transform target;
    //attack
    public float damage;
    public float hitWaitTime = 1f;
    private float hitCounter;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        //follow PlayerController
        theRigidBody.velocity = (target.position - transform.position).normalized * moveSpeed;
        //attack
        if(hitCounter > 0f){
            hitCounter -= Time.deltaTime;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //identify it collides player, using tag "Player"
        if(collision.gameObject.tag == "Player"&&hitCounter<=0f)
        {
        //damage
          PlayerHealthController.instance.TakeDamage(damage);
          hitCounter = hitWaitTime;
        }
    }
}
