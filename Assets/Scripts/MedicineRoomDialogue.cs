using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedicineRoomDialogue : MonoBehaviour
{
    private List<Quote> responses = new List<Quote>();

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
        int dialogueNumber = PlayerPrefs.GetInt("MedicineRoomDialogue");
        speechBox.SetActive(false);
        index = 0;
        if (dialogueNumber == null || dialogueNumber < 2)
        {
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
        } else {
            this.responses.Add(new Quote("bye", "bbye"));
        }
        trigger.onClick.AddListener (ShowFirstText);
        next.onClick.AddListener (ShowNext);
    }

    void ShowFirstText()
    {
        speechBox.SetActive(true);
        name.text = responses[index].name;
        text.text = responses[index].text;
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
