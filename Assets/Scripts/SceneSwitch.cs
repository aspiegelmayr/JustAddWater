using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneSwitch : MonoBehaviour
{
    public void GoToKitchen()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void GoToBrokenPipeRoom()
    {
        SceneManager.LoadScene("BrokenPipeRoom");
    }

    public void GoToCafeteria()
    {
        SceneManager.LoadScene("Cafeteria");
    }

    public void GoToHammockRoom()
    {
        SceneManager.LoadScene("HammockRoom");
    }

    public void GoToMainRoom()
    {
        SceneManager.LoadScene("MainRoom");
    }

    public void GoToMedicineRoom()
    {
        SceneManager.LoadScene("MedicineRoom");
    }

    public void GoToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void GoToPipeMinigame()
    {
        SceneManager.LoadScene("PipeMinigame");
    }
}
