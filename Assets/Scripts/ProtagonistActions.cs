using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Web;

public class ProtagonistActions : MonoBehaviour
{
    public TextAsset textFile;
    
    public string jsonFilePath;

    public GameObject speechBubble;
    public Button hideSpeechBubbleBtn;
    public bool speechBubbleShown;

    public Button[] inventorySpaces;

    public GameObject inventory;

    private bool inventoryShown;

    public GameObject menu;

    public Button tutorialBtn;

    public Button quitBtn;

    public bool menuShown;

    public static bool sliderPuzzleWon;

    public static bool PipePuzzleWon;

    void Start()
    {
        inventoryShown = false;
        inventory.SetActive(false);

        menuShown = false;
        menu.SetActive(false);

        if(speechBubble != null)
        speechBubble.SetActive(true);

        AddButtonListeners();
        GetDialogues();
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

    void ToggleSpeechBox(){
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
        }
        else
        {
            inventory.SetActive(false);
            inventoryShown = false;
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
    void GetDialogues(){
        
    }
}
