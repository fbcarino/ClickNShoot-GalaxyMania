using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemy : MonoBehaviour
{
    public float hitPoints;             //Creates a public variable named "Hit Points".
    public float maximumHitPoints;      //Creates a public variable named "maximumHitPoints".
    public float pointValue;            //Creates a public variable named "pointValue".
    public float speedX;                //Creates a public variable named "speedX".
    public float speedY;                //Creates a public variable named "speedY".


    // Start is called before the first frame update
    void Start()
    {
        hitPoints = maximumHitPoints;         //Enemy's hitPoints will be its maximumHitPoints.
        speedX = Random.Range(-2f, +2f);      //The enemy's movement range along the x axis.
        speedY = Random.Range(-2f, +2f);      //The enemy's movement range along the y axis.
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3(transform.position.x + speedX * Time.deltaTime,
                transform.position.y + speedY * Time.deltaTime, transform.position.z);    //Enemy's movement speed around screen.
        if (transform.position.x > 8 || transform.position.x < -8)        //Is the enemy beyond the the x boundaries of the screen.           
        {
            speedX *= -1;            //Change directions.
        }
        if (transform.position.y > 4 || transform.position.y < -4)        //Is the enemy beyond the the y boundaries of the screen.  
        {
            speedY *= -1;            //Change directions.
        }

    }
}
