using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    public GameObject prefab;
    public float checkRadius = 1.0f; 

    public GameObject currentPrefab;
    
    //Variables for checking spawn coordinates against previous spawn points.
    private float tempX;
    private float tempZ;

    void Update()
    {
        GeneratePrefabAtRandomPosition();
    }

    public void GeneratePrefabAtRandomPosition()
    {

        if(currentPrefab == null)
        {
            Vector3 randomPosition;
            Collider[] colliders;
            float x, y, z;
            do
            {
                Debug.Log("Checking for spot...");
                // Define the range for your random position
                x = Random.Range(-42.0f, 50.0f);
                y = Random.Range(2f, 25.0f);
                z = Random.Range(20.0f, -120.0f);

                randomPosition = new Vector3(x, y, z);
                // Check if there are any objects at the random position
                colliders = Physics.OverlapSphere(randomPosition, checkRadius);
            }
            while (colliders.Length > 0 || Mathf.Abs(tempX - x) <= 4 || Mathf.Abs(tempZ - z) <= 4); 
            // Repeat until a position with no objects is found and does not overlap too closely with previous spawns.
            
            // Instantiate the prefab at the random position
            currentPrefab = Instantiate(prefab, randomPosition, Quaternion.identity);
            //Save values for comparison against future spawns.
            tempX = x;
            tempZ = z;
        }
    }
}
