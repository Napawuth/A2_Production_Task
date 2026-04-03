using UnityEngine;

public class SelfDestructTimer : MonoBehaviour
{
    public float lifetime = 3f; // how long object lives for, can change in Unity
    private float timer; //counts how much time is left

    void Start()
    {
        timer = lifetime; //sets timer to 3 when object created
    }

    void Update()
    {
        timer -= Time.deltaTime; // Time.deltatime is the time in seconds since the last frame
                                // timer counts down in real time
        if (timer <= 0f) //if timer reaches 0 or below, destroy
        {
            Destroy(gameObject); 
        }
    }
}