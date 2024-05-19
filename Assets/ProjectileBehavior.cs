using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float speed = 3
    ;
    public Rigidbody2D rb;

    // Update is called once per frame
    private void Update()
    {
        rb.velocity = transform.right * speed;
    }

}
