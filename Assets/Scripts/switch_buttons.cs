using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_buttons : MonoBehaviour {


    public GameObject blueButton, redButton, redBall, blueBall, spawner;
    public float increase;
    private float period = 1;
    private float nextActionTime;

	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
   
            SpawnBall();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            redButton.SetActive(false);
            blueButton.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            blueButton.SetActive(false);
            redButton.SetActive(true);
        }
    }

    public void SpawnBall()
    {
        GameObject clone;
        if (Random.value >= 0.5)
        {
            clone = Instantiate(redBall, spawner.transform.position, spawner.transform.rotation);
            clone.SetActive(true);
        }
        else
        {
            clone = Instantiate(blueBall, spawner.transform.position, spawner.transform.rotation);
            clone.SetActive(true);
        }
    }
}
