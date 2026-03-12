using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBounds : MonoBehaviour
{
    private GameManager gameManager;
    private Rigidbody rb;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager == null) 
            Debug.Log($"Отсутствует компонент {nameof(gameManager)}!");
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Vector3 currentPos = rb.position;

        float clampX = Mathf.Clamp(rb.position.x, gameManager.zoneX.x, gameManager.zoneX.y);
        float clampZ = Mathf.Clamp(rb.position.z, gameManager.zoneZ.x, gameManager.zoneZ.y);


        if (Mathf.Abs(rb.position.x - clampX) > 0.01f) 
        {
            rb.position = new Vector3(clampX, rb.position.y, clampZ);
        }
        if (Mathf.Abs(rb.position.z - clampZ) > 0.01f)
        {
            rb.position = new Vector3(clampX, rb.position.y, clampZ);

        }
    }
}
