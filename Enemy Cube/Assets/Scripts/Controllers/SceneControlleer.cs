using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneControlleer : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Sair()
    {
        Application.Quit();
    }
}
