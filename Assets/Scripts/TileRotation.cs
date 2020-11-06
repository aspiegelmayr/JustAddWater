using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TileRotation : MonoBehaviour
{
    public Button[] tiles;
    private Button selectedSquare;
    private float deselectedAlpha = 0.6f;

    private void Start(){
        DeselectAllSquares();
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].onClick.AddListener(ButtonClicked);
        }
        SelectSquare(tiles[0]);
    }

     private void Update()
     {
         if (Input.GetKeyDown(KeyCode.R)){
             Debug.Log("R");
             RotateLeft();
         }
     }

     void SelectSquare(Button square){
         if(selectedSquare != null){
             DeselectSquare(selectedSquare);
         }
        Color color = square.image.color;
        color.a = 1.0f;
        square.image.color = color;

        selectedSquare = square;

     }

     void DeselectAllSquares(){
         foreach (var square in tiles)
         {
             DeselectSquare(square);
         }
     }

     void DeselectSquare(Button square){
         Color color = square.image.color;
         color.a = deselectedAlpha;
        square.image.color = color;
     }

     void DeselectSquare(int index){
        Color color = tiles[index].image.color;
         color.a = deselectedAlpha;
        tiles[index].image.color = color;
     }

     void RotateLeft () {
        selectedSquare.transform.Rotate (Vector3.forward * -90);
 }

 void ButtonClicked()
    {
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        SelectSquare(EventSystem.current.currentSelectedGameObject.GetComponent<Button>());
    }
}
