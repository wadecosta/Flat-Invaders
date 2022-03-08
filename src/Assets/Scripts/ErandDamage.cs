using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErandDamage : MonoBehaviour
{
    int randNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randNum = Random.Range(1,11);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
            Score.score += randNum * 10;
            Destroy(this.gameObject);
    }
}
