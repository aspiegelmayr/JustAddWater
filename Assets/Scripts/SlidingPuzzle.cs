using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidingPuzzle : MonoBehaviour
{
    public PuzzleTile tile;

    private List<PuzzleTile> puzzleTiles = new List<PuzzleTile>();

    private Vector2 startPosition = new Vector2(-3.0f, 4.1f);

    private Vector2 offset = new Vector2(3.0f, 3.0f);

    public LayerMask collisionMask;

    public Texture[] images;

    Ray

            rayUp,
            rayDown,
            rayLeft,
            rayRight;

    RaycastHit hit;

    private BoxCollider collider;

    private Vector3 colliderSize;

    private Vector3 colliderCenter;

    // Start is called before the first frame update
    void Start()
    {
        CreatePuzzle();
        SetStartPosition();
        ApplyMaterial();
    }

    // Update is called once per frame
    void Update()
    {
        if(!CheckWin()){
        MovePuzzle();
        }
    }

    void CreatePuzzle()
    {
        for (int i = 0; i < 8; i++)
        {
            puzzleTiles
                .Add(Instantiate(tile,
                new Vector3(0.0f, 0.0f, 0.0f),
                new Quaternion(0.0f, 0.0f, 180.0f, 0.0f)) as
                PuzzleTile);
        }
    }

    void SetStartPosition()
    {
        puzzleTiles[0].transform.position =
            new Vector3(startPosition.x, startPosition.y, 0.0f);
        puzzleTiles[1].transform.position =
            new Vector3(startPosition.x + offset.x, startPosition.y, 0.0f);
        puzzleTiles[2].transform.position =
            new Vector3(startPosition.x + 2 * offset.x, startPosition.y, 0.0f);

        puzzleTiles[3].transform.position =
            new Vector3(startPosition.x, startPosition.y - offset.y, 0.0f);
        puzzleTiles[4].transform.position =
            new Vector3(startPosition.x + offset.x,
                startPosition.y - offset.y,
                0.0f);
        puzzleTiles[5].transform.position =
            new Vector3(startPosition.x + 2 * offset.x,
                startPosition.y - offset.y,
                0.0f);

        puzzleTiles[6].transform.position =
            new Vector3(startPosition.x, startPosition.y - 2 * offset.y, 0.0f);
        puzzleTiles[7].transform.position =
            new Vector3(startPosition.x + offset.x,
                startPosition.y - 2 * offset.y,
                0.0f);
    }

    void MovePuzzle()
    {
        foreach (PuzzleTile tile in puzzleTiles)
        {
            tile.moveAmount = offset.x;

            if (tile.clicked)
            {
                collider = tile.GetComponent<BoxCollider>();
                colliderSize = collider.size;
                colliderCenter = collider.center;

                float moveAmount = offset.x;
                float direction = Mathf.Sign(moveAmount);

                float x =
                    (
                    tile.transform.position.x +
                    colliderCenter.x -
                    colliderSize.x / 2
                    ) +
                    colliderSize.x / 2;
                float yUp =
                    tile.transform.position.y +
                    colliderCenter.y +
                    colliderSize.y / 2 * direction;
                float yDown =
                    tile.transform.position.y +
                    colliderCenter.y +
                    colliderSize.y / 2 * -direction;

                rayUp =
                    new Ray(new Vector2(x, yUp), new Vector2(0f, direction));
                rayDown =
                    new Ray(new Vector2(x, yDown), new Vector2(0f, -direction));

                float y =
                    (
                    tile.transform.position.y +
                    colliderCenter.y -
                    colliderSize.y / 2
                    ) +
                    colliderSize.y / 2;
                float xRight =
                    tile.transform.position.x +
                    colliderCenter.x +
                    colliderSize.x / 2 * direction;
                float xLeft =
                    tile.transform.position.x +
                    colliderCenter.x +
                    colliderSize.x / 2 * -direction;

                rayLeft =
                    new Ray(new Vector2(xLeft, y), new Vector2(-direction, 0f));
                rayRight =
                    new Ray(new Vector2(xRight, y), new Vector2(direction, 0f));

                if (
                    (
                    Physics.Raycast(rayUp, out hit, 1.0f, collisionMask) ==
                    false
                    ) &&
                    (tile.moved == false) &&
                    (tile.transform.position.y < startPosition.y)
                )
                {
                    tile.moveUp = true;
                }
                if (
                    Physics.Raycast(rayDown, out hit, 1.0f, collisionMask) ==
                    false &&
                    !tile.moved &&
                    tile.transform.position.y > (startPosition.y - 2 * offset.y)
                )
                {
                    tile.moveDown = true;
                }

                if (
                    !Physics.Raycast(rayRight, out hit, 1.0f, collisionMask) &&
                    !tile.moved &&
                    tile.transform.position.x < (startPosition.x + 2 * offset.x)
                )
                {
                    tile.moveRight = true;
                }
                if (
                    !Physics.Raycast(rayLeft, out hit, 1.0f, collisionMask) &&
                    !tile.moved &&
                    tile.transform.position.x > startPosition.x
                )
                {
                    tile.moveLeft = true;
                    
                }
            }
        }
    }

    void ApplyMaterial()
    {
        for(int i = 0; i < 8; i++){
            puzzleTiles[i].GetComponent<Renderer>().material.mainTexture = images[i];
        }
        
    }

    bool CheckWin(){
        //position0: -3, 4.1
        //pos1: 0, 4.1
        // pos2: 3, 4.1
        // -3, 1.1
        // 0, 1.1
        // 3, 1.1
        // -3, -1.9
        // 0, -1.9
        if(puzzleTiles[0].transform.position.x == -3 && puzzleTiles[0].transform.position.y == 4.1 &&
        puzzleTiles[1].transform.position.x == -0 && puzzleTiles[1].transform.position.y == 4.1 &&
        puzzleTiles[2].transform.position.x == 3 && puzzleTiles[3].transform.position.y == 4.1 &&
        puzzleTiles[3].transform.position.x == -3 && puzzleTiles[3].transform.position.y == 1.1 &&
        puzzleTiles[4].transform.position.x == 0 && puzzleTiles[4].transform.position.y == 1.1 &&
        puzzleTiles[5].transform.position.x == 3 && puzzleTiles[5].transform.position.y == 1.1 &&
        puzzleTiles[6].transform.position.x == -3 && puzzleTiles[6].transform.position.y == -1.9 &&
        puzzleTiles[7].transform.position.x == 0 && puzzleTiles[7].transform.position.y == -1.9){
            ProtagonistActions.sliderPuzzleWon = true;
            return true;
        }
        return false;
    }
}
