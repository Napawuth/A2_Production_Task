using UnityEngine;
using System.Collections;

public class SelfDestructCoroutine : MonoBehaviour
{
    public float lifetime = 3f; // seconds before destruction

    void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }

    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}