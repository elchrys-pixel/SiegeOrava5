using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtSeperateScreen : MonoBehaviour
{
    public Transform target;
    public GameManager reftoGameMan;
    public GameObject reftoCharacterCam, reftoMainCam;
    // Start is called before the first frame update
    void Start()
    {
        reftoCharacterCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //look at target
        if (reftoGameMan.gameState == "playable")
        {
            reftoCharacterCam.SetActive(true);
            transform.LookAt(target);
        }

    }
}
