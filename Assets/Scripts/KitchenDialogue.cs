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

    void Start(){
        index = 0;
        this.responses.Add(new Quote("Kohlkopf", "Hm, Wasser. Ich brauche Wasser."));
        this.responses.Add(new Quote("Kohlkopf", "Ich werd wohl zur Ausgabe schauen müssen."));
        next.onClick.AddListener(ShowNext);
        ShowFirstText();
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
