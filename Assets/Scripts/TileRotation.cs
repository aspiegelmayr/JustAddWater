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
        foreach (var angle in rotationAngles)
        {
            Debug.Log (angle);
            if (angle % 360 != 0)
            {
                return false;
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
