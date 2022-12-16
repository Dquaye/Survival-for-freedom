using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DetectCollision : MonoBehaviour
{

    private GameManager gameManager;
    public static ScoreManager scoremanager;

    public static DetectCollision dt;
    public static PauseMenu pauseMenu;
    [SerializeField] public GameObject pausePanel;
    [SerializeField] public GameObject shield;
    //[SerializeField] public GameObject health;
    public GameObject collectEffect;
    public Text goldtext;
    public Text startext;
    public int star = 0;
    public int gold = 0;
    public int newgold = 0;
    public string ngold;
    public string nstar;
    public int shldnum = 0;
    public int hlthnum = 0;

    public GameObject l1,l2, l3;
    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip death;

    public Text scoretxt;
    public Text highscoretxt;
    public Text shldnumtxt;
    public Text hlthnumtxt;

    //public Text goldtext;
    public Text leveltxt;
    public int score = 0;
    public int highscore = 0;
    public string sco, hsco;
    int counter = 3;
    int baselevelscore = 0;
    int addscore =1000;
    int multiplier = 1;
    //public int gold = 0;



    /* int psd;
     public Text onn;*/

    public bool tr;


    private void Awake()
    {
        if (dt == null)
        {
            dt = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoretxt.text = score.ToString();
        highscoretxt.text = highscore.ToString();

        gold = PlayerPrefs.GetInt("gold", 0);
        
        goldtext.text = gold.ToString();
        ngold = PlayerPrefs.GetInt("gold", 0).ToString();

        star = PlayerPrefs.GetInt("star", 0);

        startext.text = star.ToString();
        nstar = PlayerPrefs.GetInt("star", 0).ToString();

        shldnum = PlayerPrefs.GetInt("shieldnum", 0);
        shldnumtxt.text = shldnum.ToString();

        hlthnum = PlayerPrefs.GetInt("healthnum", 0);
        hlthnumtxt.text = hlthnum.ToString();

        //gold = PlayerPrefs.GetInt("gold", 0);
        //scoretxt.text = score.ToString();
        //goldtext.text = gold.ToString();


        //pauseMenu = FindObjectOfType<PauseMenu>();

        //  Debug.Log(pauseMenu.ispaused);
        //Debug.Log(psd);
        //Debug.Log(pauseMenu);
        // psd = PauseMenu.pauseMenu.on;
        // Debug.Log(psd);

        //Debug.Log(pauseMenu.on);
        //onn.text = PauseMenu.pauseMenu.on;
        //Debug.Log(onn.text);
        /*tr = pauseMenu.pasd;
        Debug.Log(tr);*/

    }

    // Update is called once per frame
    void Update()
    {
        
        //Checkpause();
        // Debug.Log(psd);
        //Debug.Log(pauseMenu.ispaused);
        if (!pausePanel.activeSelf)
        {
            Countscore();
        }
        
        
        
    }

    public void Countscore()
    {
        
            score += 1;
            baselevelscore = score;
            scoretxt.text = score.ToString();
            if (highscore < score)
            {
                PlayerPrefs.SetInt("highscore", score);
                highscore = PlayerPrefs.GetInt("highscore", 0);
                highscoretxt.text = highscore.ToString();
            }

            if (baselevelscore == multiplier * addscore)
            {
            //Debug.Log(baselevelscore);
                multiplier++;
                leveltxt.text = "Level: " + multiplier;
                //rend.sharedMaterial = material[Random.Range(0, 3)];
            
            }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (counter == 3&& collision.gameObject.CompareTag("enemy"))
        {
            counter--;
            l1.SetActive(false);
            playerAudio.PlayOneShot(death, 1.0f);
            Destroy(collision.gameObject);

        }
        else if (counter == 2 && collision.gameObject.CompareTag("enemy"))
        {
            counter--;
            l2.SetActive(false);
            playerAudio.PlayOneShot(death, 1.0f);
            Destroy(collision.gameObject);
        }
        else if (counter==1 && collision.gameObject.CompareTag("enemy"))
        {
            counter--;
            l3.SetActive(false);
            playerAudio.PlayOneShot(death, 1.0f);
            Destroy(collision.gameObject);
            Handheld.Vibrate();
            Debug.Log("Score: " + score + " Highscore: " + highscore);
            sco = scoretxt.text;
            hsco = highscoretxt.text;
            //FindObjectOfType<Gameover>().ScoreandHighscore(dt.score, dt.highscore);

            //gameManager.AddLives(-1);
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScreen");
           /* if (collision.gameObject.CompareTag("coin"))
            {
                if (collectEffect)
                    Instantiate(collectEffect, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);

                gold += 5;
                PlayerPrefs.SetInt("gold", gold);
                gold = PlayerPrefs.GetInt("gold", 0);
                goldtext.text = gold.ToString();
                ngold = goldtext.text;
            }*/
        }
        
        
        
        
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            Instantiate(collectEffect, transform.position, Quaternion.identity);
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

            gold += 5;
            
            PlayerPrefs.SetInt("gold", gold);
            gold = PlayerPrefs.GetInt("gold", 0);
            goldtext.text = gold.ToString();
            ngold = goldtext.text;
        }
        else if (other.tag == "star")
        {
            Instantiate(collectEffect, transform.position, Quaternion.identity);
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

            
            star += 1;
            PlayerPrefs.SetInt("star", star);
            star = PlayerPrefs.GetInt("star", 0);
            startext.text = star.ToString();
            nstar = startext.text;
        }

    }

    public void ActivateShield()
    {
        if (shldnum > 0 && !shield.activeSelf )
        {
            
            shield.SetActive(true);
            shldnum -= 1;
            PlayerPrefs.SetInt("shieldnum", shldnum);
            shldnumtxt.text = shldnum.ToString();
        }
    }

    public void Activatelife()
    {
        if (hlthnum > 0 && counter < 3)
        {
            if (counter == 2)
            {
                counter++;
                l1.SetActive(true);
            }
            else if (counter == 1)
            {
                counter++;
                l2.SetActive(true);
            }
        }
       
    }

}
