﻿using UnityEngine;

public class News_View : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player.fields.money_display4.SetText(Player.fields.money.ToString()+ "₽");
        for (int i=0;i<3;i++)
            if (!News_Model.News[i].instanced && Player.fields.day >= News_Model.News[i].day)
            {
                News_Model.Blocks[i].transform.SetLocalPositionAndRotation(new Vector3(0, News_Model.Blocks[i].transform.localPosition.y - 13, 0), new Quaternion(0, 0, 0, 0));
                News_Model.News[i].instanced = true;
            }
    }
}
