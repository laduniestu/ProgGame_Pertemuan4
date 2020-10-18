using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KubusMerah : MonoBehaviour
{
    public Image imgCircle;
    public float totalTime = 1;
    bool gvrStatus;
    public float gvrTimer;

    void Update()
    {
        if(gvrStatus) {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }   
    }

    public void textKubusMerahOn(){
        gvrStatus = true;
    }

    public void textKubusMerahOff() {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }
}