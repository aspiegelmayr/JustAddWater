using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammockRoomDialogue : MonoBehaviour
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

    private bool getKey;

    void Start()
    {
        this.responses = new List<Quote>();
        speechBox.SetActive(false);
        index = 0;
        trigger.onClick.AddListener(SetDialogue);
        next.onClick.AddListener (ShowNext);
    }

    void SetDialogue(){
        int number = PlayerPrefs.GetInt("HammockRoomDialogue");
        if(number == 0 || number == 1) {
            SetFirstDialogue();
        } else {
            SetOtherDialogue();
        }
    }

    void SetFirstDialogue(){
        this.responses.Clear();
            this.responses.Add(new Quote("Kohlkopf", "Hallo, Streusel."));
            this.responses.Add(new Quote("Streusel", "Lass mich in Ruhe, ich bin beschäftigt."));
            this.responses.Add(new Quote("Kohlkopf", "Und womit genau?"));
            this.responses.Add(new Quote("Streusel", "Sieht man doch, damit, meine Arbeit nicht zu tun."));
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
        if (PlayerPrefs.GetInt("HammockRoomDialogue") == 2 && PlayerPrefs.GetInt("MedicineRoomDialogue") < 2)
        {
            this.responses.Clear();
            this.responses.Add(new Quote("Kohlkopf", "Hey, Streusel."));
            this.responses.Add(new Quote("Streusel", "Lass mich doch einfach schlafen. Meine Arbeit tut sich immerhin nicht von selbst."));
        }
        if(PlayerPrefs.GetInt("HammockRoomDialogue") == 3){
            this.responses.Clear();
            this.responses.Add(new Quote("Kohlkopf", "Hallo, Streusel."));
            this.responses.Add(new Quote("Streusel", "Hm."));
            this.responses.Add(new Quote("Kohlkopf", "Ich brauch den Notfallschlüssel."));
            this.responses.Add(new Quote("Streusel", "Pillen."));
            this.responses.Add(new Quote("Kohlkopf", "Was?"));
            this.responses.Add(new Quote("Streusel", "Ich brauch meine Medizin."));
            this.responses.Add(new Quote("Kohlkopf", "Dann hol sie dir."));
            this.responses.Add(new Quote("Streusel", "Du willst zum Schlüssel. Ich will nicht aufstehen."));
            this.responses.Add(new Quote("Kohlkopf", "*seufzt* Wo ist deine Medizin?"));
            this.responses.Add(new Quote("Streusel", "Im Medizinschrank, du Kohlkopf."));
            this.responses.Add(new Quote("Kohlkopf", "..."));
            this.responses.Add(new Quote("Streusel", "Bring mir die rot-grüne Pillendose."));
            this.responses.Add(new Quote("Kohlkopf", "Na gut…"));
            this.responses.Add(new Quote("Streusel", "Du willst zum Schlüssel. Bring mir meine Medizin und ich lass dich durch. Jeder gewinnt."));
        }

        if(PlayerPrefs.GetInt("HammockRoomDialogue") == 4){
            notDone = true;
            this.responses.Clear();
            this.responses.Add(new Quote("Streusel", "Na, wirds bald? Die rot-grüne Dose."));
        }
        if(PlayerPrefs.GetInt("HammockRoomDialogue") == 5){
            notDone = true;
            this.responses.Clear();
            this.responses.Add(new Quote("Kohlkopf", "Hier, bitte, Streusel. Deine Medizin."));
            this.responses.Add(new Quote("Streusel", "Das ist die falsche Dose, du Kohlkopf."));
            this.responses.Add(new Quote("Streusel", "Ich hab’ gesagt die rot-grüne, nicht die grün-rote Pillendose."));
            this.responses.Add(new Quote("Streusel", "Kannst du irgendwas richtig machen?"));
            this.responses.Add(new Quote("Kohlkopf", "Na gut, dann eben die andere ..."));
        } if(PlayerPrefs.GetInt("HammockRoomDialogue") == 6){
            notDone = false;
            this.responses.Clear();
            this.responses.Add(new Quote("Kohlkopf", "Hier, nimm. Und jetzt steh auf."));
            this.responses.Add(new Quote("Streusel", "Warum so gereizt heute?"));
            this.responses.Add(new Quote("Streusel", "Oh ja, das hab ich gebraucht. Danke, Kumpel."));
            getKey = true;
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
            if(PlayerPrefs.GetInt("HammockRoomDialogue") == 1 || PlayerPrefs.GetInt("HammockRoomDialogue") == 0){
                speechBox.SetActive(false);
                index = 0;
            }
            else {
            if(!notDone){
            int newIndex = PlayerPrefs.GetInt("HammockRoomDialogue") + 1;
            PlayerPrefs.SetInt("HammockRoomDialogue", newIndex);
            if(PlayerPrefs.GetInt("HammockRoomDialogue") == 6){
                PlayerPrefs.SetInt("HasKey", 1);
                PlayerPrefs.SetInt("MedicineRoomDialogue", 3);
            }
            PlayerPrefs.SetInt("MedicineRoomDialogue", 3);
            PlayerPrefs.Save();
            }
            speechBox.SetActive(false);
        }
        }
    }
}
