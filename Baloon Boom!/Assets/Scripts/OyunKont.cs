using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKont : MonoBehaviour
{
    public Button btn;
    public Text zamanText, balonText, tebrik;
    public GameObject inGame;
    public GameObject gameOver;
    public GameObject mainMenu;
    public GameObject patlama;
    public float zamanSayaci = 250f;
    int patlayanBalon = 0;
    bool oyundevam = true;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        gameOver.SetActive(false);
        inGame.SetActive(false);
        Time.timeScale = 0;
        balonText.text = "Point : " + patlayanBalon;
    }

    public void GameScreen()
    {
        Time.timeScale = 1;
        mainMenu.SetActive(false);
        inGame.SetActive(true);
        gameOver.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        mainMenu.SetActive(false);
        inGame.SetActive(false);
        gameOver.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (zamanSayaci > 0) {
        zamanSayaci -= Time.deltaTime;
            zamanText.text = "Time : " + (int)zamanSayaci;
        }
        else
        { GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i = 0; i < go.Length; i++)
            {
                
                Instantiate(patlama, go [i].transform.position, go [i].transform.rotation);
                Destroy(go[i]);
                
            }
            oyundevam = false;
            if (oyundevam==false)
            {
                tebrik.text = "Nice!! " + patlayanBalon + " Baloon Boom!";
                btn.gameObject.SetActive(true);
                tebrik.gameObject.SetActive(true);
            }
        }
    }
    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Point : " + patlayanBalon;
    }
}
