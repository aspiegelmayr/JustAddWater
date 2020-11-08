using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainRoomDialogue : MonoBehaviour
{
    private List<Quote> responses;

    public Text name;

    public Text text;

    public Button next;

    private int index;

    public Button trigger;

    public GameObject speechBox;

    private bool textShown;

    void Start()
    {
        this.responses = new List<Quote>();
        speechBox.SetActive(false);
        index = 0;
        trigger.onClick.AddListener(SetDialogue);
        next.onClick.AddListener (ShowNext);
    }

    void SetDialogue(){
        int number = PlayerPrefs.GetInt("MainRoomDialogue");
        if(number == 0 || number == 1) {
            SetFirstDialogue();
        } else {
            SetOtherDialogue();
        }
    }

    void SetFirstDialogue(){
        this
                .responses
                .Add(new Quote("Kohlkopf",
                    "GUTEN MORGEN HERR GENERALOBERSTFELDWEBEL LEUTNANT S. T. EINADLER!!"));
            this
                .responses
                .Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler", "STEINADLER, Adler Stein!"));
            this
                .responses
                .Add(new Quote("Kohlkopf",
                    "Hätte ich nicht besser sagen können!"));
            this
                .responses
                .Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler",
                    "Stein, Steinadler Adler Stein. Steinadler, Adler Adler. ADLER!"));
            this
                .responses
                .Add(new Quote("Kohlkopf",
                    "Die Wasserrohre? Völlig demoliert?"));
            this
                .responses
                .Add(new Quote("Kohlkopf", "Wie konnte das passieren?")); //"Ich dachte Streusel hätte das erst letzte Woche warten sollen?"
            this
                .responses
                .Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler",
                    "Steinadler! Adler Stein, Stein Stein Adler!"));
            this
                .responses
                .Add(new Quote("Kohlkopf",
                    "Natürlich ist das so kein Zustand, aber warum ..."));
            this
                .responses
                .Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler",
                    "*saugt Luft ein* S T E I N A D L E R !!"));
            this
                .responses
                .Add(new Quote("Kohlkopf",
                    "Okay, okay, okay ... Hab schon verstanden. Ich kümmer mich darum."));
            this
                .responses
                .Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler", "Ad Stein. Steinadleeer"));
            this.responses.Add(new Quote("Kohlkopf", "Verstanden, Leutnant!"));
            ShowFirstText();
    }

    void ShowFirstText()
    {
        index = 0;
        speechBox.SetActive(true);
        name.text = responses[index].name;
        text.text = responses[index].text;
    }

    void SetOtherDialogue()
    {
        if (PlayerPrefs.GetInt("MainRoomDialogue") == 2)
        {
            this.responses.Clear();
            this.responses.Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler", "Stein? Steinadler!"));
            this.responses.Add(new Quote("Kohlkopf", "Jawohl, Herr Generaloberstfeldwebel Leutnant S. T. Einadler! Ich sollte mich wirklich um den Rohrbruch kümmern."));
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
            PlayerPrefs.SetInt("MainRoomDialogue", 2);
            PlayerPrefs.Save();
            speechBox.SetActive(false);
        }
    }
}
