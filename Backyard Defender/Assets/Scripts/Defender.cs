using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 100;


    public void AddStars(int starAmount)
    {
        FindObjectOfType<StarDisplay>().AddStars(starAmount);
    }

    public int GetStarCost()
    {
        return starCost;
    }
}
