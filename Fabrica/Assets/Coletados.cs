using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Coletados : MonoBehaviour
{
    private int sludgies_coletatos = 0;

    public TextMeshProUGUI ScoreTXT;




    private void Start()
    {
      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jo�o"))
        {
            AddPoints();
            
        }
        
    }

    void AddPoints()
    {
        sludgies_coletatos++;
        ScoreTXT.text = sludgies_coletatos.ToString();
        Debug.Log("ADDPOINTS");
    }

}
