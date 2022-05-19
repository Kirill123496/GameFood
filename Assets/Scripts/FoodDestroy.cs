using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDestroy : MonoBehaviour
{
    [SerializeField] private FoodSpawn foodSpawn;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        foodSpawn.i--;
    }
}
