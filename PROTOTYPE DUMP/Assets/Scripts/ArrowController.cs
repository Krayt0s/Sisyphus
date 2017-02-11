using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

    public float speed;

	// Use this for initialization
	void Start () {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 archerPosition = transform.position;
        Vector2 direction = mousePosition - archerPosition;
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Boulder")
        {
            Destroy(collision.gameObject);
        }
        else if ( collision.tag != "Player" )
        {
            Destroy(gameObject);
        }
    }
}
