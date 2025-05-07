using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float highPosY = 1f;
    public float lowPosX = -1f;

    public float holeSizeMin = 2f;
    public float holeSizeMax = 6f;

    public Transform topObject;
    public Transform bottomObject;

    public float widthPadding = 4f;

    MinigameManager minigameManager;

    private void Start()
    {
        minigameManager = MinigameManager.Instance;
    }

    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstaclCount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize  ;

        topObject.localPosition = new Vector3(0, halfHoleSize);
        bottomObject.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosX, highPosY);

        transform.position = placePosition;

        return placePosition;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MiniGamePlayerController miniGamePlayer = collision.GetComponent<MiniGamePlayerController>();
        if (miniGamePlayer != null)
            minigameManager.AddScore(1);
    }
}
