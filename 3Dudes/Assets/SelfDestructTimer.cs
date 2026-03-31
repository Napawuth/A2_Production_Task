using UnityEngine;

public class SelfDestructTimer : MonoBehaviour
{
    public float lifetime = 3f; // seconds before destruction
    private float timer;

    void Start()
    {
        timer = lifetime;
    }

    void Update()
    {
        timer -= Time.deltaTime; // subtract time passed each frame
        if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}