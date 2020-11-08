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

    void Start()
    {
        this.responses = new List<Quote>();
        speechBox.SetActive(false);
        index = 0;
        triggerBabsi.onClick.AddListener(SetDialogueBabsi);
        triggerUschi.onClick.AddListener(SetDialogueUschi);
        next.onClick.AddListener (ShowNext);
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
                if(PlayerPrefs.GetInt("HasKey") == 1){
                    this.responses.Clear();
                this.responses.Add(new Quote("Uschi", "Putzen, putzen, putzen."));
                this.responses.Add(new Quote("Uschi", "Fast so schlimm wie das 82er Desaster."));
                this.responses.Add(new Quote("Kohlkopf", "Das was?"));
                } else {
                    this.responses.Clear();
                this.responses.Add(new Quote("Uschi", "Babsi is grade voll blöde."));
                this.responses.Add(new Quote("Kohlkopf", "Na wenn du das sagst."));
                }
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
            PlayerPrefs.SetInt("MedicineRoomDialogue", 2);
            PlayerPrefs.Save();
            speechBox.SetActive(false);
        }
    }
}
