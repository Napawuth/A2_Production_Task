using UnityEngine; //allows use of features like MonoBehaviour, Destroy, gameObject, Time, and WaitForSeconds.
using System.Collections; //need because this code used IEnumerator

public class SelfDestructCoroutine : MonoBehaviour   //created a script and MonoBehaviour means it can be attached 
                                                    // to a GameObject in Unity and allows other used functions
{
    public float lifetime = 3f; // amount of seconds before destruction
                                // created a variable shown in unity that can be changed to fit preference
    void Start() //runs when you press play in unity
    {
        StartCoroutine(DestroyAfterTime()); //coroutine tells unity to run the function in the background
    }

    IEnumerator DestroyAfterTime() //we use IEnumerator because the function will pause and resume later
    {
        yield return new WaitForSeconds(lifetime);  // means pause for given lifetime (3) before resuming
                                                    // ensures that only this functions pauses, and 
                                                    // everything else keeps running normally
        Destroy(gameObject); //After wait, delete the object
    }
}