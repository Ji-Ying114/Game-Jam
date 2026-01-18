using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggroUI : MonoBehaviour
{   
    [SerializeField] SpriteRenderer ui;
    [SerializeField] Sprite[] aggroSprites; //存储不同aggro等级的图片
//-----------------------------------------------------------------------------------
     private float aggroValue;
//-----------------------------------------------------------------------------------
    void Start()
    {
        ui.enabled = false;
    }
//-----------------------------------------------------------------------------------
    //根据aggro值更新UI显示的图片
    void Update(){
        if (aggroValue >= 0 && aggroValue < 20)
        {
            ui.sprite = aggroSprites[0];
        }
        else if (aggroValue >= 20 && aggroValue < 40)
        {
            ui.sprite = aggroSprites[1];
        }
        else if (aggroValue >= 40 && aggroValue < 60)
        {
            ui.sprite = aggroSprites[2];
        }
        else if (aggroValue >= 60 && aggroValue < 80)
        {
            ui.sprite = aggroSprites[3];
        }
        else if (aggroValue >= 80 && aggroValue < 100)
        {
            ui.sprite = aggroSprites[4];
        }
        else if (aggroValue = 100)
        {
            ui.sprite = aggroSprites[5];
        }
    }
//-----------------------------------------------------------------------------------
    //更新aggro值
    public void UpdateAggro(float aggroValue)
    {
        this.aggroValue = aggroValue;
    }
//-----------------------------------------------------------------------------------
    //显示/隐藏UI
    public void ShowUI()
    {
        ui.enabled = true;
    }
    public void HideUI()
    {
        ui.enabled = false;
    }
}
