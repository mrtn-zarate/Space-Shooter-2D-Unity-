using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Canvas : MonoBehaviour
{
    public GameObject textmeshpro_instrucciones;
    public GameObject textmeshpro_totalkills;
    public GameObject textmeshpro_totallives;
    static public int kills = 0;
    static public int lives = 3;
    TextMeshProUGUI textmeshpro_totalkills_text;
    TextMeshProUGUI textmeshpro_totallives_text;

    void Start()
    {
        textmeshpro_totalkills_text = textmeshpro_totalkills.GetComponent<TextMeshProUGUI>();
        textmeshpro_totallives_text = textmeshpro_totallives.GetComponent<TextMeshProUGUI>();
        
    }

    
    void Update()
    {
        textmeshpro_totalkills_text.text = kills.ToString();
        textmeshpro_totallives_text.text = lives.ToString();
        if(kills==1)
        {
            textmeshpro_instrucciones.gameObject.SetActive(false);
        }
    }

}
