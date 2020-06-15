using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject[] cooldownObjects;
    Image[] cooldownImages;
    // Start is called before the first frame update
    void Start()
    {
        InitializeUI();
    }

    // Update is called once per frame
    void InitializeUI()
    {
        cooldownImages = new Image[cooldownObjects.Length];
        for (int i = 0; i < cooldownObjects.Length; i++)
        {
            cooldownImages[i] = cooldownObjects[i].GetComponent<Image>();
            cooldownImages[i].fillAmount = 0f;
        }
    }
}
