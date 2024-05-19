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

    

   
    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

    public void RemoveProjectile(){
        Destroy(gameObject);
    }
    

}
