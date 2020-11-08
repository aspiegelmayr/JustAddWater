using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CafeteriaDialogue : MonoBehaviour
{
    private List<Quote> responses;

    public Text name;

    public Text text;

    public Button next;

    private int index;

    public Button trigger;

    public GameObject speechBox;

    private bool textShown;

    public Button waterButton;

    void Start()
    {
        ToggleWaterButton();
        this.responses = new List<Quote>();
        speechBox.SetActive(false);
        index = 0;
        trigger.onClick.AddListener(SetDialogue);
        next.onClick.AddListener (ShowNext);
        waterButton.onClick.AddListener(GrabWater);
    }

    void SetDialogue(){
        int number = PlayerPrefs.GetInt("CafeteriaDialogue");
        if(number == 0 || number == 1) {
            SetFirstDialogue();
        } else {
            SetOtherDialogue();
        }
    }

    void ToggleWaterButton(){
        GameObject button = GameObject.Find ("Water");
        if(PlayerPrefs.GetInt("Water") == 1){
        button.SetActive(true);
        } else {
            button.SetActive(false);
        }
    }

    void GrabWater(){
        PlayerPrefs.SetInt("Water", 1);
        PlayerPrefs.Save();
        ToggleWaterButton();
        this.responses.Clear();
        this.responses.Add(new Quote("Oma Spiegelafro", "Das hast du gerade nicht getan!"));
        this.responses.Add(new Quote("Kohlkopf", "*ergreift Flucht*"));
        ShowFirstText();
    }

    void SetFirstDialogue(){
        this.responses.Add(new Quote("Oma Spiegelafro", "Hallo, junges Gemüse. Sag, wie kann ich dir behilflich sein."));
        this.responses.Add(new Quote("Kohlkopf", "Was machst du hier oben?"));
        this.responses.Add(new Quote("Oma Spiegelafro", "Natürlich das Essen bewachen..."));
        this.responses.Add(new Quote("Oma Spiegelafro", "... und mich Schminken. Soll ichs bei dir auch mal versuchen?"));
        this.responses.Add(new Quote("Kohlkopf", "Also eigentlich wollte ich nur Wasser"));
        this.responses.Add(new Quote("Oma Spiegelafro", "Keine Bange, das haben wir gleich."));
        this.responses.Add(new Quote("Oma Spiegelafro", "Auch wenn ich gerade kein Wasser habe. Nur Schminke."));
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
        
        if(PlayerPrefs.GetInt("CafeteriaDialogue") == 2){
            this.responses.Clear();
            this.responses.Add(new Quote("Kohlkopf", "Hast du Wasser für mich?"));
        this.responses.Add(new Quote("Oma Spiegelafro", "Allgemein schon."));
        this.responses.Add(new Quote("Oma Spiegelafro", "Aber leider sind gerade die Rohre vor dem Filter kaputt. Darum sitzen wir auf dem Trockenen."));
        ShowFirstText();
        }
        
        if(PlayerPrefs.GetInt("CafeteriaDialogue") == 3){ //after winning pipe puzzle
            this.responses.Clear();
            
            this.responses.Add(new Quote("Oma Spiegelafro", "Na, junges Gemüse?"));
            this.responses.Add(new Quote("Kohlkopf", "Bekomme ich bitte endlich mein Wasser?"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Natürlich noch nicht."));
            this.responses.Add(new Quote("Oma Spiegelafro", "Ich bin noch nicht bereit, dir welches zu geben. *pudert sich die Nase*"));
            this.responses.Add(new Quote("Kohlkopf", "Musst du dich wirklich erst schminken?"));
            this.responses.Add(new Quote("Kohlkopf", "Gib mir doch einfach mein Wasser."));
            this.responses.Add(new Quote("Oma Spiegelafro", "Lass mich kurz darüber nachdenken."));
            this.responses.Add(new Quote("Oma Spiegelafro", "..."));
            this.responses.Add(new Quote("Oma Spiegelafro", "Mmmmmmm ..."));
            this.responses.Add(new Quote("Oma Spiegelafro", "Nein, nicht bevor ich geschminkt bin."));
            this.responses.Add(new Quote("Kohlkopf", "Dann nehme ich es mir einfach selber."));
            this.responses.Add(new Quote("Oma Spiegelafro", "Aber dann werd ich Babsi nicht mehr davon abhalten ..."));
            this.responses.Add(new Quote("Oma Spiegelafro", "... sich einfach selber deine Zähne zu nehmen."));
            this.responses.Add(new Quote("Oma Spiegelafro", "Also warte, bis ich geschminkt bin!"));
            this.responses.Add(new Quote("Kohlkopf", "Und wie lange wird das dauern?"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Nun, ich brauche so lange, bis ich meinen Spiegel gefunden habe."));
            this.responses.Add(new Quote("Oma Spiegelafro", "Vorher steht erst einmal alles."));
            this.responses.Add(new Quote("Kohlkopf", "Ist das dein voller Ernst?"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Du kannst mir ja helfen, meinen Spiegel zu finden."));
            this.responses.Add(new Quote("Oma Spiegelafro", "Dann kann ich mich fertigschminken und du bekommst dein Wasser."));
            this.responses.Add(new Quote("Kohlkopf", "Nun..."));
            this.responses.Add(new Quote("Kohlkopf", "Er ist in deinen Haaren!"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Was versuchst du mir da für Dinge zu erzählen?"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Wenn mein Spiegel in meinen Haaren wäre, würde ich das merken."));
            this.responses.Add(new Quote("Kohlkopf", "NA OFFENSICHTLICH NICHT!!"));
            this.responses.Add(new Quote("Oma Spiegelafro", "..."));
            this.responses.Add(new Quote("Kohlkopf", "Ob du mir glaubst oder nicht, bitte taste deine Haare ab."));
            this.responses.Add(new Quote("Kohlkopf", "UND NIMM DEN SPIEGEL VON DORT!"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Also anschreien lass ich mich von einem Junggemüse sicher nicht."));
            this.responses.Add(new Quote("Kohlkopf", "Mit dir zu diskutieren hat keinen Zweck."));
            waterButton.enabled = true;
        } 
        
        if(PlayerPrefs.GetInt("CafeteriaDialogue") == 4){ //idle after pipe game
            this.responses.Clear();
            
            this.responses.Add(new Quote("Oma Spiegelafro", "Was willst du denn?!"));
            this.responses.Add(new Quote("Oma Spiegelafro", "Gib mir eine Stunde, dann hab ich den Spiegel sicher gefunden."));
            this.responses.Add(new Quote("Oma Spiegelafro", "Und dann bin ich auch endlich richtig geschminkt."));
            this.responses.Add(new Quote("Kohlkopf", "..."));
        }
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
            if(PlayerPrefs.GetInt("CafeteriaDialogue")== 1 || PlayerPrefs.GetInt("CafeteriaDialogue")== 2){
            PlayerPrefs.SetInt("CafeteriaDialogue", 2); //idle before puzzle
            } else {
                PlayerPrefs.SetInt("CafeteriaDialogue", 4); //idle
            }
            PlayerPrefs.Save();
            speechBox.SetActive(false);
        }
    }
}


 

