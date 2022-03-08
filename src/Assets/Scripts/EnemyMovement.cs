using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int count;
    //private float time = 5f;
    public float period = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
	    count = 0;

        
    }

    // Update is called once per frame
    void Update()
    {

	    if((period > 2) && (count < 5))
	    {

     	        float x = transform.position.x;
                float y = transform.position.y;

                transform.position = new Vector3(x+2, y, 0);
                count++;

		period = 0;


	    }

	    if((period > 2) && (count == 5))
	    {
		    float x = transform.position.x;
                    float y = transform.position.y;

		    transform.position = new Vector3(x, y-1, 0);
		    count++;

		    period = 0;
	    }

	    if((period > 2) && (count > 5))  
            {       
                
                float x = transform.position.x;
                float y = transform.position.y;             

                transform.position = new Vector3(x-2, y, 0);
                count++;
                
                period = 0;
                    

            }


	    period += Time.deltaTime;
        
    }
}
