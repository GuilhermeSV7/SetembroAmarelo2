using UnityEngine;
using System.Collections;   
using UnityEngine.UI;
using TMPro;

public class coinmanager : MonoBehaviour
{
     public int coinCount = 0;
    public TextMeshProUGUI coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   // Update is called once per frame
    void Update()
    {
        coinText.text = " Pontos Confiabilidade: " + coinCount.ToString();
    }
}
