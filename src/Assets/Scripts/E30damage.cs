using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E30damage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
            Score.score += 30;
            Destroy(this.gameObject);
    }
}
