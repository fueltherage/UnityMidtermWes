using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class cube1 : MonoBehaviour {
	GameObject[] spheres;
	// Use this for initialization
	void Start () {
		spheres = GameObject.FindGameObjectsWithTag("ball");
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider hit)
	{
		if(hit.gameObject.tag == "Player")
		{
			foreach(GameObject ball in spheres)
			{
				ball.GetComponent<SphereMid>().TurnYellow();
			}
		}
	}
	void OnTriggerExit(Collider hit)
	{
		if(hit.gameObject.tag == "Player")
		{
			foreach(GameObject ball in spheres)
			{
				ball.GetComponent<SphereMid>().TurnWhite();
			}
		}
	}
}
