using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;


    void Update()
    {



	    //GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
	    //Destroy(shot, 3f);
    }

    /*
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
	    Score.score++;
	    Destroy(this.gameObject);
	    Debug.Log(collision.gameObject.tag);
	    if(collision.gameObject.tag == "10")
	    {
		    Debug.Log("GOT HERE");
		    Score.score += 10;
	    }
	    else if(collision.gameObject.tag == "20")
	    {
		    Score.score += 20;
	    }
	    else if(collision.gameObject.tag == "30")
	    {
		    Score.score += 30;
	    }


    }
    */
}
