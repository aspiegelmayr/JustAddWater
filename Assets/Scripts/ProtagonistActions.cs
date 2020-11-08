using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Web;

public class ProtagonistActions : MonoBehaviour
{

    public GameObject speechBubble;
    public Button hideSpeechBubbleBtn;
    public static bool speechBubbleShown;

    public Button[] inventorySpaces;

    public GameObject inventory;

    private bool inventoryShown;

    public GameObject menu;

    public Button tutorialBtn;

    public Button quitBtn;

    public bool menuShown;

    public static bool sliderPuzzleWon;

    public static bool PipePuzzleWon;

    public Sprite keyImg, waterImg, pills1Img, pills2Img;


    void Start()
    {
        inventoryShown = false;
        inventory.SetActive(false);

        menuShown = false;
        menu.SetActive(false);

        if(speechBubble != null)
        speechBubble.SetActive(true);

        AddButtonListeners();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleInventory();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleSpeechBox();
        }
    }

    void AddButtonListeners()
    {
        tutorialBtn.onClick.AddListener (OpenTutorial);
        quitBtn.onClick.AddListener (CloseGame);
        if(hideSpeechBubbleBtn != null){
            hideSpeechBubbleBtn.onClick.AddListener(ToggleSpeechBox);
        }
    }

    public void ToggleSpeechBox(){
         if (!speechBubbleShown)
        {
            speechBubble.SetActive(true);
            speechBubbleShown = true;
        }
        else
        {
            speechBubble.SetActive(false);
            speechBubbleShown = false;
        }
    }

    void OpenTutorial()
    {
        //TODO
        Debug.Log("tutorial");
    }

    void CloseGame()
    {
        Application.Quit();
    }

    void ToggleInventory()
    {
        if (!inventoryShown)
        {
            inventory.SetActive(true);
            inventoryShown = true;
            UpdateInventory();
        }
        else
        {
            inventory.SetActive(false);
            inventoryShown = false;
        }
    }

    void UpdateInventory(){
        if(PlayerPrefs.HasKey("HasKey") && PlayerPrefs.GetInt("HasKey") == 1){
            inventorySpaces[0].image.sprite = keyImg;
        }
        if(PlayerPrefs.HasKey("Water") && PlayerPrefs.GetInt("Water") == 1){
            inventorySpaces[3].image.sprite = waterImg;
        }
        if(PlayerPrefs.HasKey("Pills1") && PlayerPrefs.GetInt("Pills1") == 1){
            inventorySpaces[1].image.sprite = pills1Img;
        }
        if(PlayerPrefs.HasKey("Pills2") && PlayerPrefs.GetInt("Pills2") == 1){
            inventorySpaces[2].image.sprite = pills2Img;
        }
    }

    void ToggleMenu()
    {
        if (!menuShown)
        {
            menu.SetActive(true);
            menuShown = true;
        }
        else
        {
            menu.SetActive(false);
            menuShown = false;
        }
    }
}
