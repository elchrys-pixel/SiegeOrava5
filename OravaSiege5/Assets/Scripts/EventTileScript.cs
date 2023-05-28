using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTileScript : MonoBehaviour
{
    public ExampleTileHandler reftoTileTracker;
    public bool swamp, ice, mountain, jungle;
    // Start is called before the first frame update
    void Start()
    {
        swamp = false;
        ice = false;
        mountain = false;
        jungle = false;
        reftoTileTracker = GetComponent<ExampleTileHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
