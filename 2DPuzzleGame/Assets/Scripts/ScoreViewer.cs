using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreViewer : MonoBehaviour
{
    private ComboCounter m_comboCounter => GetComponent<ComboCounter>();

    [SerializeField] private TextMeshProUGUI m_scoreText;

    private int comboRate = 10;

    private void Update()
    {
        m_scoreText.text = $"Score:{m_comboCounter.CurrentComboCount * comboRate} ";
    }
}
