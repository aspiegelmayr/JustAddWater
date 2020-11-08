using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedicineRoomDialogue : MonoBehaviour
{
    private List<Quote> responses;

    public Text name;

    public Text text;

    public Button next;

    private int index;

    public Button triggerBabsi;

    public Button triggerUschi;

    public GameObject speechBox;

    private bool textShown;

    public bool keyInInventory;

    private bool notDone;

    public Button pills1;

    public Button pills2;

    private int numberOfPills;

    void Start()
    {
        this.responses = new List<Quote>();
        speechBox.SetActive(false);
        numberOfPills = 0;
        index = 0;
        triggerBabsi.onClick.AddListener(SetDialogueBabsi);
        triggerUschi.onClick.AddListener(SetDialogueUschi);
        next.onClick.AddListener (ShowNext);
        pills1.onClick.AddListener(GrabLeftPills);
        pills2.onClick.AddListener(GrabRightPills);
        if(PlayerPrefs.GetInt("SliderPuzzleSolved") == 1){
            pills1.enabled = true;
            pills2.enabled = true;
        }
    }

    void GrabLeftPills(){
        if(numberOfPills == 0){
            numberOfPills = 1;
        }
        if(!PlayerPrefs.HasKey("numberOfPills") || PlayerPrefs.GetInt("numberOfPills") == 0){
            PlayerPrefs.SetInt("numberOfPills", 1);
            PlayerPrefs.SetInt("HammockRoomDialogue", 5);
            PlayerPrefs.Save();
            } else {
                PlayerPrefs.SetInt("numberOfPills", 2);
                PlayerPrefs.SetInt("HammockRoomDialogue", 6);
                PlayerPrefs.Save();
            }
        PlayerPrefs.SetInt("LeftPills", 1);
        PlayerPrefs.Save();
    }

    void GrabRightPills(){
        if(!PlayerPrefs.HasKey("numberOfPills") || PlayerPrefs.GetInt("numberOfPills") == 0){
            PlayerPrefs.SetInt("numberOfPills", 1);
            PlayerPrefs.SetInt("HammockRoomDialogue", 5);
            PlayerPrefs.Save();
            } else {
                PlayerPrefs.SetInt("numberOfPills", 2);
                PlayerPrefs.SetInt("HammockRoomDialogue", 6);
                PlayerPrefs.Save();
            }
        PlayerPrefs.SetInt("RightPills", 1);
        PlayerPrefs.Save();
    }

    void SetDialogueBabsi(){
       int number = PlayerPrefs.GetInt("MedicineRoomDialogue");
        if(number == 0 || number == 1) {
            SetFirstDialogue();
        } else {
            SetOtherDialogue("Babsi");
        } 
    }

    void SetDialogueUschi(){
       int number = PlayerPrefs.GetInt("MedicineRoomDialogue");
        if(number == 0 || number == 1) {
            SetFirstDialogue();
        } else {
            SetOtherDialogue("Uschi");
        } 
    }
        void SetFirstDialogue(){
            this
                .responses
                .Add(new Quote("Uschi",
                    "Wo ist der Schlüssel? Du hast ihn verschludert, oder? Ich muss da rein und die Sauerei aufwischen!"));
            this
                .responses
                .Add(new Quote("Babsi",
                    "Warum sollte ich den Schlüssel haben? Du bist diejenige, die ständig überall rumschnüffelt!"));
            this
                .responses
                .Add(new Quote("Uschi",
                    "Das ist nicht schnüffeln, das ist arbeiten! Kennst du nicht."));
            this
                .responses
                .Add(new Quote("Babsi",
                    "Oh, ich kenn das sehr gut. Soll ich etwas an dir arbeiten?"));
            this
                .responses
                .Add(new Quote("Uschi",
                    "Lass deine blutigen Finger von mir! Sei froh, dass ich deine Metzgereien aufputze. Also, wo ist der Schlüssel?"));
            this
                .responses
                .Add(new Quote("Kohlkopf", "Wie konnte das passieren?"));
            this
                .responses
                .Add(new Quote("Babsi",
                    "Ich habe keinen Schlüssel. Wer weiß wo du ihn hingeworfen hast?"));
            this
                .responses
                .Add(new Quote("Kohlkopf",
                    "Uh oh, besser ich mische mich nicht ein. Aber wo könnte der Schlüssel sein?"));
                ShowFirstText();
        }

    void ShowFirstText()
    {
        index = 0;
        speechBox.SetActive(true);
        name.text = responses[index].name;
        text.text = responses[index].text;
    }

    void SetOtherDialogue(string withCharacter)
    {
        if (PlayerPrefs.GetInt("MedicineRoomDialogue") == 2)
        {
            if(withCharacter == "Uschi"){
                this.responses.Clear();
                this.responses.Add(new Quote("Uschi", "Babsi is grade voll blöde."));
                this.responses.Add(new Quote("Kohlkopf", "Na wenn du das sagst."));
                notDone = true;
                }
            } else {
                this.responses.Clear();
                this.responses.Add(new Quote("Babsi", "..."));
            }
            if(PlayerPrefs.GetInt("MedicineRoomDialogue") == 3){
                notDone = false;
                this.responses.Clear();
                this.responses.Add(new Quote("Babsi", "Wo hat die Alte jetzt den Schlüssel verschludert?"));
                this.responses.Add(new Quote("Uschi", "Wie hast du mich genannt?!"));
                this.responses.Add(new Quote("Babsi", "Ugh! Sei still!"));
                this.responses.Add(new Quote("Kohlkopf", "Einfach nicht darauf reagieren, einfach den Job erledigen. *sperrt Tür auf*"));
                this.responses.Add(new Quote("Uschi", "Endlich kann ich da drin sauber machen. Gut gemacht, Kohli."));
                this.responses.Add(new Quote("Babsi", "Wenigstens bin ich sie jetzt los. Danke, mein Lieber."));
            }


        if(PlayerPrefs.GetInt("MedicineRoomDialogue") == 4){
            if(withCharacter == "Uschi"){
                this.responses.Add(new Quote("Uschi", "Putzen, putzen, putzen."));
                this.responses.Add(new Quote("Uschi", "Fast so schlimm wie das 82er Desaster."));
                this.responses.Add(new Quote("Kohlkopf", "Das was?"));
            } else {
                this.responses.Clear();
                this.responses.Add(new Quote("Babsi", "Oh hallo, kleine Knolle. Würdest du gerne mal ..."));
                this.responses.Add(new Quote("Babsi", "... mit mir ..."));
                this.responses.Add(new Quote("Babsi", "..."));
                this.responses.Add(new Quote("Babsi", "Zahnarzt spielen?"));
                this.responses.Add(new Quote("Kohlkopf", "Tut mir leid Babsi, aber ..."));
                this.responses.Add(new Quote("Kohlkopf", "... deine Handkreissäge kommt mir etwas gefährlich vor."));
            }
            
        }
        if(PlayerPrefs.GetInt("HasKey") == 1 )
        ShowFirstText();
    }

    void ShowNext()
    {
        if (!(index + 1 > responses.Count - 1))
        {
            index++;
            name.text = responses[index].name;
            text.text = responses[index].text;
        }
        else
        {
            if(PlayerPrefs.GetInt("MedicineRoomDialogue") == 1){
            PlayerPrefs.SetInt("MedicineRoomDialogue", 2);
            PlayerPrefs.SetInt("HammockRoomDialogue", 3);
            PlayerPrefs.Save();
            notDone = true;
            } else if (!notDone){
                int newIndex = PlayerPrefs.GetInt("MedicineRoomDialogue") +1;
                PlayerPrefs.SetInt("MedicineRoomDialogue", newIndex);
                PlayerPrefs.Save();
            }
            speechBox.SetActive(false);
        }
    }
}
