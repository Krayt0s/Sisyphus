using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{

    private Transform target; //Assign to the object you want to rotate
    private Vector3 mousePosition;
    private Vector3 objectPosition;
    private float angle;

    void Start () {
		
	}
	
	void Update () {
        mousePosition = Input.mousePosition;
        mousePosition.z = 10; //The distance between the camera and object
        objectPosition = Camera.main.WorldToScreenPoint(transform.position);
        mousePosition.x = mousePosition.x - objectPosition.x;
        mousePosition.y = mousePosition.y - objectPosition.y;
        angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180 + angle));

    }
}
