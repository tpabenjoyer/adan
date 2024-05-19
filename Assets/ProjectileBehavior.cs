using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float speed = 3;
    public Rigidbody2D rb; 
    public float damage = 3;

    // Update is called once per frame
    private void Update()
    {
        rb.velocity = transform.right * speed;
    }

    void OnColliOnsionEnter2D(Collision2D other)
    {
        if(other.tag == "Enemy") {
            // Deal damage to the enemy
            Enemy enemy = other.GetComponent<Enemy>();

            if(enemy != null) {
                enemy.Health -= damage;
            }
        }
        Destroy(gameObject);
    }
    

}
