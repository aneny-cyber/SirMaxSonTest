using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieScript : MonoBehaviour
{
	public float score;
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Dieline")
			Application.LoadLevel(Application.loadedLevel);
		if (col.gameObject.tag == "Gold")
		{
			score = score + 50;
			Destroy(col.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag == "Aneny")
        {
			Destroy(gameObject);
        }
    }
	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, 100, 100), "Golds: " + score);
	}
}
