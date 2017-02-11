using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderPlayer : MonoBehaviour {

    private bool isPlayable = false;
    private float lateralVelocity = 5;

    public void setPlayable()
    {
        isPlayable = !isPlayable;
    }
    public bool getPlayable()
    {
        return this.isPlayable;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if ( isPlayable )
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * lateralVelocity * Time.deltaTime;
                Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * lateralVelocity * Time.deltaTime;
                Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
            }
            else
            {
                Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
            }
        }
	}

}
