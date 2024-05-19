using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Enemy : MonoBehaviour
{
    public float health = 1;
    Animator animator;


    public float Health {
        set {
            health = value;

            if(health <= 0) {
                Defeated();
            }
        }
        get {
            return health;
        }
    }

    private void Start() {
        animator = GetComponent<Animator>();
    }



    void Defeated(){
        animator.SetTrigger("Defeated");
    }

    
    

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Projectile")
        {
            Health -= 1;
            Destroy(other.gameObject);
        }
        
    }

    public void RemoveEnemy() {
        Destroy(gameObject);
    }
}
