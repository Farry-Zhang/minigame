using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed = 2f;
    public float lifetime = 30f;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

    private void Update()
    {
        MoveLeft();
    }

    private void MoveLeft()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}