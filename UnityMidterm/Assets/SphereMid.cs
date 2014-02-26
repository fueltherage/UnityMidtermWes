using UnityEngine;
using System.Collections;

public class SphereMid : MonoBehaviour {

	// Use this for initialization
	bool colorChanged=false;
	void Start () {
		this.gameObject.renderer.material.color = new Color(1,1,1);
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void TurnRed()
	{
		this.gameObject.renderer.material.color = new Color(1,0,0);
	}

	public void TurnYellow()
	{
		this.gameObject.renderer.material.color = new Color(1,1,0);
	}
	public void TurnWhite()
	{
		this.gameObject.renderer.material.color = new Color(1,1,1);
	}
}
