using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yenidenbasla : MonoBehaviour
{
    OyunKont oyunK;
    // Start is called before the first frame update
    void Start()
    {
        oyunK = GameObject.Find("_Script").GetComponent<OyunKont>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void YenidenBasla()
    {
        SceneManager.LoadScene("oyun");
    }

}
