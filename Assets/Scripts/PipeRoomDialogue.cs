using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeRoomDialogue : MonoBehaviour
{
    private List<Quote> responses;

    public Text name;

    public Text text;

    public Button next;

    private int index;

    public Button trigger;

    public GameObject speechBox;

    private bool textShown;

    private bool notDone;

    void Start()
    {
        this.responses = new List<Quote>();
        speechBox.SetActive(false);
        index = 0;
        if(PlayerPrefs.GetInt("PipePuzzleSolved") == 1){
            SetFirstDialogue();
        }
        next.onClick.AddListener (ShowNext);
    }

    void SetDialogue(){
        int number = PlayerPrefs.GetInt("PipeRoomDialogue");
        if(number == 0 || number == 1) {
            SetFirstDialogue();
        } else {
            SetOtherDialogue();
        }
    }

    void SetFirstDialogue(){
            this.responses.Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler", "Stein Stein Aaaadler!"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Sehr gut. Gute Arbeit."));
            this.responses.Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler", "Ler?"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Ja, ich gehe wieder zur Ausgabe, sobald ich mich aufgefrischt habe."));
            this.responses.Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler", "Adler Stein, Stein Steinadler?"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Natürlich. Aber so viel sollte klar sein."));
            this.responses.Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler", "Stein. Steinstein, Adler Stein?"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Jawohl ..."));
            this.responses.Add(new Quote("Oma Spiegelafro", "... Herr Generaloberstfeldwebel Leutnant S. T. Einadler."));
            this.responses.Add(new Quote("Generaloberstfeldwebel Leutnant S.T. Einadler", "Steinadler."));
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
            if(!notDone){
            int newIndex = PlayerPrefs.GetInt("PipeRoomDialogue") + 1;
            PlayerPrefs.SetInt("PipeRoomDialogue", newIndex);
            PlayerPrefs.SetInt("MainRoomDialogue", 3);
            PlayerPrefs.Save();
            speechBox.SetActive(false);
        }
    }
}
}
