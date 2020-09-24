using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultPresenter : MonoBehaviour
{
    public TextMeshProUGUI m_ScoreText = null;

    void Start()
    {
        var score = PlayerPrefs.GetInt("Score");
        m_ScoreText.text = $"{score}";
    }

    public void GotoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
