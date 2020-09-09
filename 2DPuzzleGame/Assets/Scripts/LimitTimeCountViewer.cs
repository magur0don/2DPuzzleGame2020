using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LimitTimeCountViewer : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI m_TimeText = null;

    private float m_limitTime = 0f;

    private void Start()
    {
        m_limitTime = 60f;
    }


    private void Update()
    {
        m_limitTime -= Time.deltaTime;
        m_TimeText.text = $"{m_limitTime}";
    }
}
