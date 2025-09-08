using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.SceneManagement;public class scriptPlayer : MonoBehaviour{    public float score;          //Creates a public variable named "Score".    public float timer;          //Creates a public variable named "Timer".
    public float maximumTimer;   //Creates a public variable named "Timer".
    public float goal;           //Creates a public variable named "Goal".
    public float ammunition;     //Creates a public variable named "Ammunition".

    public GameObject lazer;      //Creates a public game object for your particle system effect.
    AudioSource playerSpeakers;   //Allows audio to play in the scene.    //Audios:    public AudioClip laserhit;        public AudioClip lasermiss;    public AudioClip obliterate;    public Font defaultFont;         //Set a public font.
    GUIStyle defaultStyle;           //Set the GUI font to "default Style".

    // Start is called before the first frame update
    void Start()    {        playerSpeakers = GetComponent<AudioSource>();                         //Getting audio from the audio source.        InvokeRepeating("Countdown", 1, 1);                                   //Starts the repeating function called "Countdown".

        //Font Style Settings
        defaultStyle = new GUIStyle();        defaultStyle.fontSize = 50;        defaultStyle.font = defaultFont;        defaultStyle.normal.textColor = Color.white;        PlayerPrefs.SetInt("lastLevel", SceneManager.GetActiveScene().buildIndex);      //Remembers current scene as the "lastLevel".    }    // Update is called once per frame    void Update()    {
        if (Input.GetKeyDown("r"))                //Did you press down the "r" key?           
        {
            ammunition += 10;                     //Add 10 ammo to your ammunition.
            if (ammunition >= 10)                 //Is the ammuntion more than 10?
            {
                ammunition = 10;                  //Keep the ammunition at 10.
            }

        }        if (Input.GetMouseButtonDown(0) && ammunition >=0)                    //Did you click the left mouse button and is ammo greater than equal too 0?        {            ammunition -= 1;                           //Take 1 ammo from ammunition.            RaycastHit hit;                            //Create a collision with a ray            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);      //Creates a ray into the camera view from the mouse position                 if (Physics.Raycast(ray, out hit))         //Did I hit something with a collider?            {                if (hit.transform.tag == "Enemy")      //Did I hit something tagged with Enemy?
                {                    scriptEnemy enemyBrain = hit.transform.GetComponent<scriptEnemy>();         //We are getting information from the targetted enemy script                    enemyBrain.hitPoints -= 1;         //Take 1 point off the enemy's hitPoint.                     if (enemyBrain.hitPoints <= 0)     //Are the enemy's "hitPoinst" less than or equal to 0?                    {                        playerSpeakers.clip = obliterate;     //Have the "obliterate" sound effect on standby. 
                        playerSpeakers.Play();                //Play the "obliterate" sound effect.
                        Instantiate(lazer, hit.transform.position, transform.rotation);                         //Play designated particle effect.                        enemyBrain.hitPoints = enemyBrain.maximumHitPoints;                                     //resetting the hitPoints back to the enemy's maximumHitPoints                        hit.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0);      //The range where the enemy can respawn too.                        enemyBrain.speedX = Random.Range(-2f, +2f);                //resetting speed of the enemy                        enemyBrain.speedY = Random.Range(-2f, +2f);                //resetting speed of the enemy                        score += enemyBrain.pointValue;                            //Add 1 to "Score" variable                    }                    else            //If the enemy is not completely destroyed yet...
                    {
                        playerSpeakers.clip = laserhit;        //Have the "lasehit" sound effect on standby. 
                        playerSpeakers.Play();                 //Play the "laserhit" sound effect.
                    }                }                if (hit.transform.tag == "Powerup")            //Is the gameobject you hit tagged as "Powerup"?
                {
                        playerSpeakers.clip = laserhit;        //Have the "lasehit" sound effect on standby.
                        playerSpeakers.Play();                 //Play the "laserhit" sound effect.
                        timer += 3;                            //Add 3 seconds to timer
                        hit.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0);       //The range where the powerup can respawn.  
                }            }            else            {                score -= 1;                       //Take away 1 point from score because you didn't hit anything.
                playerSpeakers.clip = lasermiss;  //Have the "lasermiss" sound effect on standby.                playerSpeakers.Play();            //Play the "lasermiss" sound effect.            }
        }        if (Input.GetKey(KeyCode.Escape))              //Was the escape key clicked?
        {
            SceneManager.LoadScene("sceneMainMenu");     //Go to Main Menu.
        }    }    void Countdown()    {        timer -= 1;              //Take away 1 second from timer        if (timer <= 0)          //Check if timer is less than or equal to 0.        {            CancelInvoke("Countdown");             //Stop the function "Countdown"
            if (score >= goal)                     //Is your score more than or equal too the given goal for the level?
            {
                SceneManager.LoadScene("sceneWin");      //Go to win page.
            }            else                                   //Score is less than given goal
            {
                SceneManager.LoadScene("sceneLose");     //Go to lose page.
            }        }    }    void OnGUI()    {        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + score, defaultStyle);              //Displays the "Score" on the game screen.        GUI.Label(new Rect(10, 60, 100, 20), "Time: " + timer, defaultStyle);               //Displays the "Timer" on the game screen.
        GUI.Label(new Rect(10, 110, 100, 20), "Ammuntion: " + ammunition, defaultStyle);    //Displays your ammuntion status.
        GUI.Label(new Rect(10, 160, 100, 20), "Goal: " + goal, defaultStyle);               //Displays your objective for the level.
    }}