using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public GameObject streetX;
    public GameObject streetZ;
    public GameObject streetC;
    public int mapWidth = 20;
    public int mapHeight = 20;
    int[,] mapgrid;
    int buildingFootprint = 3;

    void Start()
    {
        mapgrid = new int[mapWidth, mapHeight];
        // Generate map data
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                mapgrid[w, h] = (int)(Mathf.PerlinNoise(w / 10.0f, h / 10.0f) * 15);
            }
        }
        //Building streets
        int x = 0;
        for (int n = 0; n < 50; n++)
        {
            for (int h = 0; h < mapHeight; h++)
            {
                mapgrid[x, h] = -1;
            }
            x += Random.Range(2, 10);
            if (x >= mapWidth) break;
        }

        int z = 0;
        for (int n = 0; n < 10; n++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                if (mapgrid[w, z] == -1)
                    mapgrid[w, z] = -3;
                else
                    mapgrid[w, z] = -2;
            }
            z += Random.Range(5, 20);
            if (z >= mapHeight) break;
        }

        // float seed = 15;
        // float seed = Random.Range(0, 100);
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                int result = mapgrid[w, h];
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                if (result < -2)
                {
                    Instantiate(streetC, pos, streetC.transform.rotation);
                }
                else if (result < -1)
                {
                    Instantiate(streetX, pos, streetX.transform.rotation);
                }
                else if (result < 0)
                {
                    Instantiate(streetZ, pos, streetZ.transform.rotation);
                }
                else if (result < 2)
                {
                    Instantiate(buildings[0], pos, Quaternion.identity);
                }
                else if (result < 3)
                {
                    Instantiate(buildings[1], pos, Quaternion.identity);
                }
                else if (result < 4)
                {
                    Instantiate(buildings[2], pos, Quaternion.identity);
                }
                else if (result < 5)
                {
                    Instantiate(buildings[3], pos, Quaternion.identity);
                }
                else if (result < 6)
                {
                    Instantiate(buildings[4], pos, Quaternion.identity);
                }
                else if (result < 7)
                {
                    Instantiate(buildings[5], pos, Quaternion.identity);
                }
                else if (result < 8)
                {
                    Instantiate(buildings[6], pos, Quaternion.identity);
                }
                else if (result < 9)
                {
                    Instantiate(buildings[7], pos, Quaternion.identity);
                }
                else if (result < 10)
                {
                    Instantiate(buildings[8], pos, Quaternion.identity);
                }
                else if (result < 11)
                {
                    Instantiate(buildings[9], pos, Quaternion.identity);
                }
                else if (result < 15)
                {
                    Instantiate(buildings[10], pos, Quaternion.identity);
                }



                // int n = Random.Range(0, buildings.Length);

            }
        }
    }
}
