using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float speed = 1f; // The speed at which the background moves

    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Calculate the new position by moving the current position to the left
        Vector2 newPosition = new Vector2(_spriteRenderer.material.mainTextureOffset.x - (speed * Time.deltaTime), 0);

        // Update the texture offset
        _spriteRenderer.material.mainTextureOffset = newPosition;
    }
}