using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    static int score = 0;
    

    // Start is called before the first frame update

    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, bulletSpeed, 0);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        Debug.Log("score = " + score);
        ScoreScript.gameScore += 1;
        Destroy(collision.gameObject);
    }
}
