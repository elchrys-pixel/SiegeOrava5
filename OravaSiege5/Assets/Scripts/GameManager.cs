using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string gameState;
    public GameObject startScreen, endScreen, instructionScreen, reftoPlay, reftoBack, reftoAttack, reftoPlayAgain, reftoInstructions, reftoArcher, reftoMage, reftoWarrior;
    public float score;
    EventTileScript reftoETScript;
    CameraLookAtSeperateScreen reftoCamSeperateScreen;

    // Start is called before the first frame update
    void Start()
    {
        gameState = "titlescreen";
        startScreen.SetActive(true);
        endScreen.SetActive(false);
        instructionScreen.SetActive(false);

        reftoETScript = GetComponent<EventTileScript>();
        reftoCamSeperateScreen = GetComponent<CameraLookAtSeperateScreen>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState == "playable")
        {
            //print("kablamm");
            //add buttons to turn on here

            //add if playablearcher if playable mage etc. for movement and buttons. 
        }
    }

    public void PlayButton()
    {
        print("clicked");
        startScreen.SetActive(false);
        endScreen.SetActive(false);
        instructionScreen.SetActive(false);
        gameState = "playable";
    }

    public void InstructionButton()
    {
        print("clickedddd");
        startScreen.SetActive(false);
        endScreen.SetActive(false);
        instructionScreen.SetActive(true);
    }

    public void BackButton()
    {
        startScreen.SetActive(true);
        endScreen.SetActive(false);
        instructionScreen.SetActive(false);
    }

    public void PlayAgainButton()
    {
        startScreen.SetActive(false);
        endScreen.SetActive(false);
        instructionScreen.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }

   
    public void EndTurnButton()
    {
        // player must choose which character to play

        //CAMERA FOLLOW CHARACTERS
        reftoCamSeperateScreen.archerTarget = false;
        reftoCamSeperateScreen.warriorTarget = false;
        reftoCamSeperateScreen.mageTarget = false;

        //ET CARDS
        reftoETScript.swamp1.SetActive(false);
        reftoETScript.swamp2.SetActive(false);
        reftoETScript.swamp3.SetActive(false);
        reftoETScript.swamp4.SetActive(false);
        reftoETScript.swamp5.SetActive(false);
        reftoETScript.swamp6.SetActive(false);

        reftoETScript.mount1.SetActive(false);
        reftoETScript.mount2.SetActive(false);
        reftoETScript.mount3.SetActive(false);
        reftoETScript.mount4.SetActive(false);

        reftoETScript.jung1.SetActive(false);
        reftoETScript.jung2.SetActive(false);
        reftoETScript.jung3.SetActive(false);
        reftoETScript.jung4.SetActive(false);

        reftoETScript.ice1.SetActive(false);
        reftoETScript.ice2.SetActive(false);
        reftoETScript.ice3.SetActive(false);
        reftoETScript.ice4.SetActive(false);
    }

    public void ArcherButton()
    {
        // activates archer movement

        //archer camera
        reftoCamSeperateScreen.archerTarget = true;
    }

    public void MageButton()
    {
        // activates mage movement

        //mage camera
        reftoCamSeperateScreen.mageTarget = true;
    }

    public void WarriorButton()
    {
        // activates warrior movement

        //mage camera
        reftoCamSeperateScreen.warriorTarget = true;
    }

    //play again and back button, play again completely reload scene
}
