using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E10damage : MonoBehaviour
{
    public GameObject bullet;
    public Transform shottingOffset;

    public float time = 0.0f;
    public float speed = 5;

    public Rigidbody2D shot;

    public Animator explosion;

    public string explosionString = "BOOM!";


    // Start is called before the first frame update
    void Start()
    {
	    time = 0;
	    //shot = GetComponent<Rigidbody2D>();
	    //Shoot();
        
    }

    // Update is called once per frame
    void Update()
    {
	    time += Time.deltaTime;

	    if(time > 5)
	    {
		    //GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            	    //Destroy(shot, 3f);
		    time = 0;
	    }
	    //GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
	    //Destroy(shot, 3f);
        
    }

    //private void Shoot()
    //{
//	    shot = Vector2.down * speed;
  //  }

    void OnCollisionEnter2D(Collision2D collision)
    {
            Score.score += 10;
            Destroy(this.gameObject);

	    //explosion.Play(explosion.String, 0, 0.0f);
    }
}
