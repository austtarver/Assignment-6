using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
	public GameObject player;
	public static int targetsDestroyed = 0;
	public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player");
		Debug.Log("Player found ");
		scoreText.text = "";   
    }
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == player)
		{
			targetsDestroyed += 1;
			Debug.Log("destroyed : " + targetsDestroyed);
			scoreText.text = "Targets destroyed: " + targetsDestroyed;
			this.gameObject.SetActive(false);
		}
	}

   
}
