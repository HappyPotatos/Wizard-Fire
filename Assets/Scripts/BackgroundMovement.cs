using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float speed = 1f; // The speed at which the background moves

    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Calculate the new position by moving the current position to the left
        Vector2 newPosition = new Vector2(_renderer.material.mainTextureOffset.x - (speed * Time.deltaTime), 0);

        // Update the texture offset
        _renderer.material.mainTextureOffset = newPosition;
    }
}