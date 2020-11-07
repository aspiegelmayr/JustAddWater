using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTile : MonoBehaviour
{
    public bool clicked = false;
    public bool moved = false;
    public bool moveUp, moveDown, moveLeft, moveRight;
    public float moveAmount;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoveTile();
    }


    void OnMouseDown(){
        clicked = true;

        Debug.Log("click");
    }

    void OnMouseUp(){
        clicked = false;
        moved = false;
    }

    void MoveTile(){
        if(moveLeft){
            transform.position =
            new Vector3(transform.position.x - moveAmount,
                transform.position.y,
                transform.position.z);
                moveLeft = false;
                moved = true;
        }

        if(moveRight){
            transform.position =
            new Vector3(transform.position.x + moveAmount,
                transform.position.y,
                transform.position.z);
                moveRight = false;
                moved = true;
        }

        if(moveUp){
            transform.position =
            new Vector3(transform.position.x,
                transform.position.y + moveAmount,
                transform.position.z);
                moveUp = false;
                moved = true;
        }

        if(moveDown){
            transform.position =
            new Vector3(transform.position.x,
                transform.position.y - moveAmount,
                transform.position.z);
                moveDown = false;
                moved = true;
        }
    }
}
