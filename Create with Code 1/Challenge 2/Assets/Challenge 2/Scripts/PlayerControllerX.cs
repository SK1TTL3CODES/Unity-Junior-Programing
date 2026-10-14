using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class CoroutineSpawner : MonoBehaviour
{
    public float Hold = 1.0f;
    public GameObject dogPrefab;
    public InputAction fireAction;
    private bool isSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (fireAction.triggered) 
        {
            if (fireAction.triggered && !isSpawning)
            {
                StartCoroutine(SpawnRoutine());
            }

        }
    }
    
    IEnumerator SpawnRoutine()
    {

        isSpawning = true;

        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        yield return new WaitForSeconds(Hold);

        isSpawning = false;
    }
}
