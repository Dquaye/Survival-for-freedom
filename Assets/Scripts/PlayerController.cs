using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput, verticalInput;
    private float movementSpeed = 15.0f;
    private float xRange = 4.05f;
    private float poszRange = 16.0f;
    private float negzRange = 0.0f;
    public float pizStartpsZ = 2.0f;

    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    private PlayerController playerController;


    public bool mobileInputs;
    public FixedJoystick joystick;
    public SceneSwitcher ss;
    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        GameStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
    }
    void OnDestroy()
    {
        GameStateManager.Instance.OnGameStateChanged -= OnGameStateChanged;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ss.playGame();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        playerMove();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pizastartPosZ = new Vector3(transform.position.x, transform.position.y, transform.position.z+pizStartpsZ);
            //launch a projectice from player

            Instantiate(projectilePrefab,  pizastartPosZ, projectilePrefab.transform.rotation);
        }
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        enabled = newGameState == GameState.Gameplay;
    }

    void playerMove()
    {
        if(mobileInputs == true)
        {
            // accept input movement from player
            horizontalInput = joystick.Horizontal;
            //verticalInput = joystick.Vertical;

            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed * horizontalInput);
            //transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed * verticalInput);

            //Prevent player from going out of bounce from left
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

            //Prevent player from going out of bounce from right
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

            //Prevent player from going out of bounce from top
            if (transform.position.z > poszRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, poszRange);
            }

            //Prevent player from going out of bounce from bottom
            if (transform.position.z < negzRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, negzRange);
            }
        }
        else 
        {
            // accept input movement from player
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed * horizontalInput);
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed * verticalInput);

            //Prevent player from going out of bounce from left
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

            //Prevent player from going out of bounce from right
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

            //Prevent player from going out of bounce from top
            if (transform.position.z > poszRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, poszRange);
            }

            //Prevent player from going out of bounce from bottom
            if (transform.position.z < negzRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, negzRange);
            }
        }
    }

    
}
