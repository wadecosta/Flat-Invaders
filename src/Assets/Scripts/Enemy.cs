using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;

    public Transform shottingOffset;

    void Update()
    {
	    //GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
	    //Destroy(shot, 3f);
    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
	    Score.score++;
	    Destroy(gameObject);


    }
}
