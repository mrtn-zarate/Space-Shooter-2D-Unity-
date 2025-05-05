using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI_Canvas : MonoBehaviour
{
    public GameObject textmeshpro_instrucciones;
    public GameObject textmeshpro_totalkills;
    public GameObject textmeshpro_totallives;
    public GameObject pausepanel;
    public GameObject gameoverpanel;
    public bool panelabierto = false;
    static public int kills = 0;
    static public int lives = 3;
    TextMeshProUGUI textmeshpro_totalkills_text;
    TextMeshProUGUI textmeshpro_totallives_text;

    void Start()
    {
        Time.timeScale = 1;
        kills = 0;
        lives = 3;
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
        if (lives <= 0)
        {
            Time.timeScale = 0;
            gameoverpanel.SetActive(true);
            
        }
        if (Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.Escape))
        {
            if(panelabierto)
            {
                pausepanel.SetActive(false);
                Time.timeScale = 1;
                panelabierto = false;
            }
            else
            {
                pausepanel.SetActive(true);
                Time.timeScale = 0;
                panelabierto = true;
            }
        }
    }
    public void reiniciarjuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void abrirpanel()
    {
        pausepanel.SetActive(true);
        Time.timeScale = 0;
        panelabierto = true;
    }
    public void cerrarpanel()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1;
        panelabierto = false;
    }
    public void mandaralmenuprincipal()
    {
        SceneManager.LoadScene("titlescreen");
    }
    public void cerrareljuego()
    {
        Application.Quit();
    }

}
