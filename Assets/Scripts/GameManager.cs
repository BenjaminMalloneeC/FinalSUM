using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject player;

    //Camera follow player code
    public CameraFollow cameraFollow;
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        //Camera follows player positon
        cameraFollow.Setup(() => playerTransform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
