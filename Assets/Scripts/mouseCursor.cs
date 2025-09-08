using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor : MonoBehaviour
{
    private SpriteRenderer rend;        //Creates a private sprite render called "rend".
    public Sprite clickCursor;          //Creates a public sprite called "clickCursor".
    public Sprite normalCursor;         //Creates a public sprite called "normalCursor".


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;                   //Cursor is not visible.
        rend = GetComponent<SpriteRenderer>();    //Getting a component from the SpriteRenderer.
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);      //The position of the cursor on the screen. 
        transform.position = cursorPos;           //The sprite will appear on cursors position on the screen.                 

        if (Input.GetMouseButtonDown(0))          //Was the left mouse button clicked?
        {
            rend.sprite = clickCursor;            //Change sprite appearance to clickCursor.
        }
        else if (Input.GetMouseButtonUp(0))       //Was the left mouse button let go  
        {
            rend.sprite = normalCursor;           //Change sprite appearance back to normalCursor
        }
    }
}
