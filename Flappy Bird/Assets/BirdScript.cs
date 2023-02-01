using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdAlive = true;
    public float noFlyZone = -13;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdAlive == true && transform.position.y > noFlyZone)
        {
             myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if(transform.position.y < noFlyZone)
        {
            Debug.Log("Bird has fallen");
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        logic.gameOver();
        birdAlive = false;
    }
}
