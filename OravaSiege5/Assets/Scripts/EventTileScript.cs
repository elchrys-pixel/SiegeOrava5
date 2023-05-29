using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTileScript : MonoBehaviour
{
    public ExampleTileHandler reftoTileTracker;
    public bool swamp, ice, mountain, jungle;
    public string CardID;
    public float SortingCards;
    public GameObject swamp1, swamp2, swamp3, swamp4, swamp5, swamp6, mount1, mount2, mount3, mount4, jung1, jung2, jung3, jung4, ice1, ice2, ice3, ice4;
    public GameManager reftoGameMan;

    // Start is called before the first frame update
    void Start()
    {
        swamp = false;
        ice = false;
        mountain = false;
        jungle = false;
        reftoTileTracker = GetComponent<ExampleTileHandler>();
        reftoGameMan= GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (reftoGameMan.gameState == "playable")
        {

            //SWAMP
            if (swamp == true)
            {
                SortingCards = Random.Range(1, 6);
                //random range and create cards ID, positioning and make set active; 

                if (SortingCards == 1)
                {
                    CardID = "1";
                    if (CardID == "1")
                    {
                        swamp1.SetActive(true);
                    }
                }

                if (SortingCards == 2)
                {
                    CardID = "2";
                    if (CardID == "2")
                    {
                        swamp2.SetActive(true);
                    }
                }

                if (SortingCards == 3)
                {
                    CardID = "3";
                    if (CardID == "3")
                    {
                        swamp3.SetActive(true);
                    }
                }

                if (SortingCards == 4)
                {
                    CardID = "4";
                    if (CardID == "4")
                    {
                        swamp4.SetActive(true);
                    }
                }

                if (SortingCards == 5)
                {
                    CardID = "5";
                    if (CardID == "5")
                    {
                        swamp5.SetActive(true);
                    }
                }

                if (SortingCards == 6)
                {
                    CardID = "6";
                    if (CardID == "6")
                    {
                        swamp6.SetActive(true);
                    }
                }

            }

            //MOUNTAIN
            if (mountain == true)
            {
                SortingCards = Random.Range(1, 4);
                if (SortingCards == 1)
                {
                    CardID = "7";
                    if (CardID == "7")
                    {
                        mount1.SetActive(true);
                    }
                }

                if (SortingCards == 2)
                {
                    CardID = "8";
                    if (CardID == "8")
                    {
                        mount2.SetActive(true);
                    }
                }

                if (SortingCards == 3)
                {
                    CardID = "9";
                    if (CardID == "9")
                    {
                        mount3.SetActive(true);
                    }
                }

                if (SortingCards == 4)
                {
                    CardID = "11";
                    if (CardID == "11")
                    {
                        mount4.SetActive(true);
                    }
                }
            }
            //JUNGLE
            if (jungle == true)
            {
                SortingCards = Random.Range(1, 4);
                if (SortingCards == 1)
                {
                    CardID = "12";
                    if (CardID == "12")
                    {
                        jung1.SetActive(true);
                    }
                }

                if (SortingCards == 2)
                {
                    CardID = "13";
                    if (CardID == "13")
                    {
                        jung2.SetActive(true);
                    }
                }

                if (SortingCards == 3)
                {
                    CardID = "14";
                    if (CardID == "14")
                    {
                        jung3.SetActive(true);
                    }
                }

                if (SortingCards == 4)
                {
                    CardID = "15";
                    if (CardID == "15")
                    {
                        jung4.SetActive(true);
                    }
                }

            }
            //ICE
            if (ice == true)
            {
                SortingCards = Random.Range(1, 4);
                if (SortingCards == 1)
                {
                    CardID = "16";
                    if (CardID == "16")
                    {
                        ice1.SetActive(true);
                    }
                }

                if (SortingCards == 2)
                {
                    CardID = "17";
                    if (CardID == "17")
                    {
                        ice2.SetActive(true);
                    }
                }

                if (SortingCards == 3)
                {
                    CardID = "18";
                    if (CardID == "18")
                    {
                        ice3.SetActive(true);
                    }
                }

                if (SortingCards == 4)
                {
                    CardID = "19";
                    if (CardID == "19")
                    {
                        ice4.SetActive(true);
                    }
                } //HOW TO DEACTIVATE THEM AFTER BEEN SET ACTIVE (DELETE COMPLETELY)

            }
        }
    }
}
