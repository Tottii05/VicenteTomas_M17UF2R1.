using UnityEngine;

public class ObjectRoomSpawner : MonoBehaviour
{
    public GridController grid;
    public RandomSpawner[] spawnerData;

    public void InitialiseObjectSpawning()
    {
        foreach (RandomSpawner rs in spawnerData)
        {
            SpawnObjects(rs);
        }
    }

    void SpawnObjects(RandomSpawner data)
    {
        int randomIteration = Random.Range(data.spawnerData.minSpawn, data.spawnerData.maxSpawn + 1);

        for(int i = 0; i < randomIteration; i++)
        {
            int randomPos = Random.Range(0, grid.avaliablePoints.Count - 1);
            GameObject go = Instantiate(data.spawnerData.itemToSpawn, grid.avaliablePoints[randomPos], Quaternion.identity, transform); 
            grid.avaliablePoints.RemoveAt(randomPos);
        }   
    }
}
