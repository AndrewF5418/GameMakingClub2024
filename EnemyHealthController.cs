using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//use UI
using UnityEngine.UI;
public class EnemyHealthController : MonoBehaviour
{
    public static EnemyHealthController instance;
    public Transform target;
//slider
    public Slider healthBar;
//trait
    public float adjustSliderPositionHeight=35;
    public float currentHealth, maxHealth;
    // Start is called before the first frame update
    public void Awake(){
        instance = this;
    }
    
    void Start()
    {
        target = FindObjectOfType<EnemyNormalController>().transform;
        currentHealth = maxHealth;
        //set healthbar
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x,target.position.y+adjustSliderPositionHeight,transform.position.z);
    }

    public void TakeDamage(float damageToTake){
        currentHealth -= damageToTake;
        if(currentHealth<=0){
            gameObject.SetActive(false);
        }
        healthBar.value = currentHealth;
    }
}
