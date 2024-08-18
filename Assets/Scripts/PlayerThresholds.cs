using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThresholds : MonoBehaviour

{   //Singleton
    public static PlayerThresholds Instance {get; set;}
    private void Awake() 
    {
        if(Instance != null && Instance !=this)
        {
            Destroy(this);
        }

        else
        {
            Instance = this;
        }
    }

    //Common Variables
    [SerializeField] private static float maxCarryMass = 100f; 
    [SerializeField] private static float throwForce = 5f;
    [SerializeField] private static float holdDistance = 2f;
    public bool isCeilingAbove;
    public float getMaxCarryMass ()
    {
        return maxCarryMass;
    }

        public float getThrowForce ()
    {
        return throwForce;
    }

        public float getHoldDistance ()
    {
        return holdDistance;
    }
    

}