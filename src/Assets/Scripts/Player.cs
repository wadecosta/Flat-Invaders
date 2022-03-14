using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;

  public float speed = 5f;

  public Transform shottingOffset;
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);

        Destroy(shot, 3f);

      }

      if (Input.GetKey(KeyCode.A))
      {
	      transform.position += transform.right * Time.deltaTime * -speed;
      }
      else if (Input.GetKey(KeyCode.D))
      {
	      transform.position += transform.right * Time.deltaTime * speed;
      }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
	    Destroy(gameObject);
	    MainMenu.PlayCredits();

    }
}
