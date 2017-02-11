using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sisyphus : MonoBehaviour {

    private float speed = 5;
    public Transform firingPosition;
    public GameObject arrow;

    void Start ()
    {
		
	}
	
	void Update ()
    {
      
        if ( Input.GetMouseButtonDown( 0 ) )
        {
            Instantiate( arrow, firingPosition.position, firingPosition.rotation );
        }
        if ( Input.GetKey( KeyCode.W ) || Input.GetKey( KeyCode.UpArrow ) )
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            Camera.main.transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey( KeyCode.S ) || Input.GetKey( KeyCode.DownArrow ) )
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            Camera.main.transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey( KeyCode.A ) || Input.GetKey( KeyCode.LeftArrow ) )
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            Camera.main.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey( KeyCode.D ) || Input.GetKey( KeyCode.RightArrow ) )
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            Camera.main.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
    
}
