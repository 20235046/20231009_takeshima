﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextballoonscP05: MonoBehaviour
{
    public GameObject nextballoon;

    // Start is called before the first frame update
    void Start()
    {
        nextballoon.SetActive(false);
        StartCoroutine("Next");
    }
    IEnumerator Next()
    {
        //ここに処理を書く

        yield return new WaitForSeconds(41);

        nextballoon.SetActive(true);//ここに再開後の処理を書く
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
