using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("MainRoomDialogue", 1);
        PlayerPrefs.SetInt("HammockRoomDialogue", 1);
        PlayerPrefs.SetInt("MedicineRoomDialogue", 1);
        PlayerPrefs.SetInt("KitchenDialogue", 1);
        PlayerPrefs.SetInt("CafeteriaDialogue", 1);
        PlayerPrefs.SetInt("SliderPuzzleSolved", 0);
        PlayerPrefs.SetInt("PipePuzzleSolved", 0);
        PlayerPrefs.Save();

        SetInventory();
    }

    void SetInventory(){
            PlayerPrefs.SetInt("HasKey", 0);
            PlayerPrefs.SetInt("Water", 0);
            PlayerPrefs.SetInt("Pills1", 0);
            PlayerPrefs.SetInt("Pills2", 0);
            PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
