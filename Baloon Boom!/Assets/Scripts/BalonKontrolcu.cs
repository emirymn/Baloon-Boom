using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolcu : MonoBehaviour
{
    public GameObject patlama;
    OyunKont oyunKontrolScripti;
    void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Script").GetComponent<OyunKont>();
    }
    void OnMouseDown()
    {
        GameObject go =Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.217f);
        oyunKontrolScripti.BalonEkle();
    }
}
    