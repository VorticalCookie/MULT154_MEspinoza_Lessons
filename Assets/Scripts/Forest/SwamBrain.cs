using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwamBrain : MonoBehaviour
{
    private bool hasHive = true;
    private Patrol patrol;
    private Bot bot;
    // Start is called before the first frame update
    void Start()
    {
        patrol = GetComponent<Patrol>();
        bot = GetComponent<Bot>();
        HivePickUp.HivePickedUp += HiveTaken;
    }

    void HiveTaken()
    {
        hasHive = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(hasHive)
        {
            patrol.PatrolWayPoints();
        }
        else
        {
            bot.Pursue();
        }
    }
}
