using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public class MenuUiHelper : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] Text HighScore;

    private void Start()
    {
        if(GameManager.Instance.PlayerHighScoreName.Equals(""))
        {
            HighScore.text = "Best Score: ";
            return;
        }

        HighScore.text = $"Best Score: {GameManager.Instance.PlayerHighScoreName} :{GameManager.Instance.HighScore}";
    }

    public void StartGame()
    {
        GameManager.Instance.PlayerName = inputField.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
