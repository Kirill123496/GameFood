using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    [SerializeField] public GameObject foodPrefabs;
    public int amountFood =6;
    public int i =0;
    private Vector2 _randomSpawnPosition;
    [SerializeField] private GameObject platformDestroy;

    private void Update()
    {
        
        for (; i<amountFood;i++)
        {
            SpawnEl(foodPrefabs);
        }
        
    }

    public void SpawnEl(GameObject objectFood)
    {
         _randomSpawnPosition = new Vector2(Random.Range(-7, 10), 7);
         objectFood = SpawnFood(_randomSpawnPosition);
    }
    private GameObject SpawnFood(Vector2 spawnPoint)
    {
        foodPrefabs.GetComponent<Transform>().position = spawnPoint;
        return Instantiate(foodPrefabs);
    }
}
