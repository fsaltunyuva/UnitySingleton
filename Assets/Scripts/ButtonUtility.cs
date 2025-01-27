using TMPro;
using UnityEngine;

public class ButtonUtility : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI exampleBoolText;

    private void Awake()
    {
        UpdateText();
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex + 1);
    }
    
    public void LoadPreviousScene()
    {
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex - 1);
    }

    public void ToggleBool()
    {
        Singleton.Instance.exampleBool = !Singleton.Instance.exampleBool;
        UpdateText();
    }
    
    private void UpdateText()
    {
        if(Singleton.Instance.exampleBool)
            exampleBoolText.text = "Example Bool Value: <color=#00FF00>true </color>";
        else
            exampleBoolText.text = "Example Bool Value: <color=#FF0000>false </color>";
    }
}
