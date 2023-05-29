using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtSeperateScreen : MonoBehaviour
{
    public Transform targetA, targetW, targetM;
    public bool archerTarget, warriorTarget, mageTarget;
    public GameManager reftoGameMan;
    public GameObject reftoCharacterCam, reftoMainCam;
    // Start is called before the first frame update
    void Start()
    {
        reftoCharacterCam.SetActive(false);
        archerTarget = false;
        warriorTarget = false;
        mageTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        //look at target
        if (reftoGameMan.gameState == "playable")
        { 
            reftoCharacterCam.SetActive(true);

            if (archerTarget == true)
            {
                transform.LookAt(targetA);
            }

            if (warriorTarget == true)
            {
                transform.LookAt(targetW);
            }

            if (mageTarget == true)
            {
                transform.LookAt(targetM);
            }

        }

    }
}
