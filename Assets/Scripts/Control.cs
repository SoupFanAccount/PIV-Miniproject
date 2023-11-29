using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Transform playerCamera;
    public float timer = 30.0f;
    private Transform spawnPoint;
    private Transform playerPos;
    public bool paused = false;
    public float delay = 2.0f;
    public DialogueManager dialogueManager;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        spawnPoint = GameObject.FindGameObjectWithTag("Respawn").transform;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;

        transform.Translate(movement, Space.World);

        float horizontalCam = Input.GetAxis("Mouse X");

        playerCamera.transform.RotateAround(playerPos.position, Vector3.down, horizontalCam);

        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);

        if (!paused)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0.1f)
        {
            Debug.Log("timer ended");
            timerEnded();
        }
    }

    void timerEnded()
    {
        moveSpeed = 0.0f;

        StartCoroutine(ResetMovementAfterDelay(2.0f));
    }

    IEnumerator ResetMovementAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        moveSpeed = 5.0f;
        paused = false;

        playerPos.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
        timer = 30.0f;
    }
}
