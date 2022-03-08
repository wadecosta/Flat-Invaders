using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int count;
    public int newEnemy;
    //private float time = 5f;
    public float period = 0.0f;

    //public Transform E10;
    //public Transform E20;
    //public Transform E30;
    //public Transform Erand;

    // Start is called before the first frame update
    void Start()
    {
	    count = 0;
	    newEnemy = 1;

	   // var object10 = Instantiate(E10);
	    //var object20 = Instantiate(E20);
	    //var object30 = Instantiate(E30);
	    //var objectRand = Instantiate(Erand);

        
    }

    // Update is called once per frame
    void Update()
    {
	    int randNum = Random.Range(1,5);


	    if((period > 2) && (count < 5))
	    {

     	        float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x+2, y, 0);
                count++;

		period = 0;

		//Instantiate(E10, new Vector3(-8, 4, 0), Quaternion.identity);


	    }

	    if((period > 2) && (count == 5))
	    {
		    float x = transform.position.x;
                    float y = transform.position.y;

		    transform.position = new Vector3(x, y-1, 0);
		    count++;

		    period = 0;
	    }

	    if((period > 2) && (count > 5) && (count < 10))  
            {       
                
                float x = transform.position.x;
                float y = transform.position.y;             

                transform.position = new Vector3(x-2, y, 0);
                count++;
                
                period = 0;

            }

	    if((period > 2) && (count == 10))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x, y-1, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count > 10) && (count < 15))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x+2, y, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count == 15))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x, y-1, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count > 15) && (count < 20))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x-2, y, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count == 20))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x, y-1, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count > 20) && (count < 25))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x+2, y, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count == 25))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x, y-1, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count > 25) && (count < 30))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x-2, y, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count == 30))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x, y-1, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count > 30) && (count < 35))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x+2, y, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count == 35))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x, y-1, 0);
                count++;

                period = 0;

            }

	    if((period > 2) && (count > 35) && (count < 40))
            {

                float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x, y-1, 0);
                count++;

                period = 0;

            }


	    period += Time.deltaTime;
        
    }
}
