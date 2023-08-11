using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    float speed = 0.02f;
    public GameObject Bullet;
    Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Leftbump")
        {
            speed = 0.02f;
            this.transform.rotation = Quaternion.Euler(0, 0, 00);
        }

        if (collision.gameObject.tag == "Rightbump")
        {
            speed = -0.02f;
            this.transform.rotation = Quaternion.Euler(0, 180, 00);
        }

        if( collision.gameObject.tag == "Bullet")
        {
            animator.SetTrigger("IsDie");
            speed = 0f;
        }
    }
    
}
