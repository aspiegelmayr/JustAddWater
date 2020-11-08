using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenDialogue : MonoBehaviour
{
    private List<Quote> responses = new List<Quote>();
    public Text name;
    public Text text;
    public Button next;
    private int index;
    public GameObject speechBox;
    public Image noodles;

    void Start(){
        noodles.enabled = false;
        index = 0;
        next.onClick.AddListener(ShowNext);
        if(PlayerPrefs.GetInt("KitchenDialogue") == 1){
            ShowFirstDialogue();
        } else {
            ShowOtherDialogue();
        }
    }

    void ShowFirstDialogue(){
        this.responses.Add(new Quote("Kohlkopf", "Hm, Wasser. Ich brauche Wasser."));
        this.responses.Add(new Quote("Kohlkopf", "Ich werd wohl zur Ausgabe schauen müssen."));
        ShowFirstText();
    }

    void ShowOtherDialogue(){
        this.responses.Clear();
        this.responses.Add(new Quote("Kohlkopf", "Endlich, endlich, endlich."));
        this.responses.Add(new Quote("Kohlkopf", "Es hat lange gedauert, aber jetzt ..."));
        this.responses.Add(new Quote("Kohlkopf", "Jetzt ist es soweit."));
        noodles.enabled = true;
    }

    void ShowFirstText(){
        name.text = responses[index].name;
        text.text = responses[index].text;
    }

    void ShowNext(){
        if(!(index+1 > responses.Count -1)){
        index++;
            name.text = responses[index].name;
            text.text = responses[index].text;
        } else {
            speechBox.SetActive(false);
        }
    }
}
