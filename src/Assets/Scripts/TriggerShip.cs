using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShip : MonoBehaviour
{
    private Animator ship;
    private string shipFire = "ShipFire";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKey(KeyCode.Space))
	    {
		    ship.Play(shipFire, 0, 0.0f);
	    }
    }
}
