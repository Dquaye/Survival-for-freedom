using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Purchase : MonoBehaviour
{
    public GameObject pl;
    public GameObject notpanelstar;
    public GameObject notpanelcoins;


    public int gold = 0,  starnum = 0;
    public Text gs, star;

    int star1 = 200;
    int star2 = 500;
    int star3 = 1000;

    int coin1 = 100;
    int coin2 = 300;
    int coin3 = 700;

    int gold1 = 200;
    int gold2 = 300;

    int shieldnum = 0;
    int healthnum = 0;
    // Start is called before the first frame update
    public void Awake()
    {
        gold = PlayerPrefs.GetInt("gold", 0);
            
        starnum = PlayerPrefs.GetInt("star", 0);

        shieldnum = PlayerPrefs.GetInt("shieldnum", 0);

        healthnum = PlayerPrefs.GetInt("healthnum", 0);


    }

    public void BuyCoins1()
    {
        if (starnum<star1)
        {
            notpanelstar.SetActive(true);
        }
        else
        {
            starnum = starnum - star1;
            star.text = starnum.ToString();
            PlayerPrefs.SetInt("star", starnum);
            gold = gold + coin1;
            gs.text = gold.ToString();
            PlayerPrefs.SetInt("gold", gold);
        }
    }

    public void BuyCoins2()
    {
        if (starnum < star2)
        {
            notpanelstar.SetActive(true);
        }
        else
        {
            starnum = starnum - star2;
            star.text = starnum.ToString();
            PlayerPrefs.SetInt("star", starnum);
            gold = gold + coin2;
            gs.text = gold.ToString();
            PlayerPrefs.SetInt("gold", gold);
        }
    }

    public void BuyCoins3()
    {
        if (starnum < star3)
        {
            notpanelstar.SetActive(true);
        }
        else
        {
            starnum = starnum - star3;
            star.text = starnum.ToString();
            PlayerPrefs.SetInt("star", starnum);
            gold = gold + coin3;
            gs.text = gold.ToString();
            PlayerPrefs.SetInt("gold", gold);
        }
    }

    public void BuySheild()
    {
        if (gold < gold1)
        {
            notpanelcoins.SetActive(true);
        }
        else
        {
            gold = gold - gold1;
            gs.text = gold.ToString();
            PlayerPrefs.SetInt("gold", gold);
            shieldnum += 1;
            PlayerPrefs.SetInt("shieldnum", shieldnum);

        }
    }

    public void BuyHealth()
    {
        if (gold < gold2)
        {
            notpanelcoins.SetActive(true);
        }
        else
        {
            gold = gold - gold2;
            gs.text = gold.ToString();
            PlayerPrefs.SetInt("gold", gold);
            healthnum += 1;
            PlayerPrefs.SetInt("healthnum", healthnum);
        }
    }

    public void HideWarningStar()
    {
        notpanelstar.SetActive(false);
    }

    public void HideWarningCoin()
    {
        notpanelcoins.SetActive(false);
    }


}
