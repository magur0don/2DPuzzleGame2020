using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGenerater : MonoBehaviour
{


    [SerializeField] private Transform m_orbGenerater = null;

    [SerializeField] private List<GameObject> m_OrbObjects = new List<GameObject>();

    [SerializeField] private ComboCounter m_comboCounter = null;

    private int m_maxOrbCount = 20;

    void Start()
    {
        OrbGenerate(m_maxOrbCount);
    }

    public void OrbGenerate(int generateOrbCount)
    {

        for (int i = 0; i < generateOrbCount; i++)
        {
            var orb = Instantiate(m_OrbObjects[Random.Range(0, 4)], m_orbGenerater);
            orb.GetComponent<OrbController>().comboCounter = m_comboCounter;
            orb.GetComponent<OrbController>().OrbGenerater = this;
            orb.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-4,4), Random.Range(-4, 0)));
        }
    }
}
