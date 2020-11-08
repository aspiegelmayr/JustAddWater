using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class TileRotation : MonoBehaviour
{
    public Button[] tiles;

    private Button selectedSquare;

    private float deselectedAlpha = 0.6f;

    private int[] rotationAngles;

    private bool gameIsActive;

    private void Start()
    {
        gameIsActive = true;
        rotationAngles = new int[tiles.Length];
        DeselectAllSquares();
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].onClick.AddListener(ButtonClicked);
        }
        SelectSquare(tiles[0]);
        ShuffleSquares();
    }

    int getIndexFromSquare(Button square)
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            if (square == tiles[i])
            {
                return i;
            }
        }
        return -1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RotateLeft();
        }
    }

    void SelectSquare(Button square)
    {
        if (gameIsActive)
        {
            if (selectedSquare != null)
            {
                DeselectSquare (selectedSquare);
            }
            Color color = square.image.color;
            color.a = 1.0f;
            square.image.color = color;

            selectedSquare = square;
        }
    }

    void DeselectAllSquares()
    {
        foreach (var square in tiles)
        {
            DeselectSquare (square);
        }
    }

    void DeselectSquare(Button square)
    {
        Color color = square.image.color;
        color.a = deselectedAlpha;
        square.image.color = color;
    }

    void DeselectSquare(int index)
    {
        Color color = tiles[index].image.color;
        color.a = deselectedAlpha;
        tiles[index].image.color = color;
    }

    void ShuffleSquares()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            rotationAngles[i] = RandomlyRotate(tiles[i]);
        }
    }

    bool CheckSolution()
    {
        for (int i = 0; i < rotationAngles.Length; i++)
        {
            if(i == 8 || i == 17 || i == 9 || i == 16 || i == 24 || i == 32 || i == 33 || i == 34 || i == 26 || i == 27 || i == 35 || i == 43 || i == 44 || i == 36 || i == 28 || 
            i == 29 || i == 37 || i == 38 || i == 39 || i == 19 || i == 11 || i == 12 || i == 4 || i == 5 || i == 6 || i == 7 || i == 14 || i == 15 || i == 22 || i == 30){
            if (rotationAngles[i] % 360 != 0)
            {
                return false;
            }
        }
        
    }
    return true;
    }

    int RandomlyRotate(Button square)
    {
        var angles = new List<int> { 0, 90, 180, 270 };
        int index = Random.Range(0, angles.Count);
        square.transform.Rotate(Vector3.forward * angles[index]);
        return angles[index];
    }

    void RotateLeft()
    {
        if (gameIsActive)
        {
            selectedSquare.transform.Rotate(Vector3.forward * -90);
            int index = getIndexFromSquare(selectedSquare);
            rotationAngles[index] -= 90;
            if (CheckSolution())
            {
                gameIsActive = false;
                ProtagonistActions.PipePuzzleWon = true;
                PlayerPrefs.SetInt("PipePuzzleSolved", 1);
                PlayerPrefs.SetInt("CafeteriaDialogue", 3);
                PlayerPrefs.Save();
                Debug.Log("game won");
            }
            else
            {
                Debug.Log("game lost");
            }
        }
    }

    void ButtonClicked()
    {
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        SelectSquare(EventSystem
            .current
            .currentSelectedGameObject
            .GetComponent<Button>());
    }
}
