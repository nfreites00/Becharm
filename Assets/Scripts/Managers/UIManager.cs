using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager UIManagerInstance;
    [SerializeField] TextMeshProUGUI charmCounterTMP;
    [HideInInspector] public int charmCount;

    private void Awake()
    {
        if (UIManagerInstance == null)
        {
            UIManagerInstance = this;
        } 
        
        else
        {
            Destroy(gameObject);
        }
    }
    public void UpdateCharmCounterUI()
    {
        charmCounterTMP.text = charmCount.ToString();
    }
}
