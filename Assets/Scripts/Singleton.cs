using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; } // This is the instance of the Singleton class.
    
    public bool exampleBool = false; // This is an example of a variable that can be accessed from anywhere.

    private void Awake() 
    {
        if (Instance != null && Instance != this) // If there is an instance, and it's not me, delete myself. 
        { 
            Destroy(this); 
        } 
        else // Otherwise, set the instance to me and don't destroy me.
        { 
            Instance = this; 
            DontDestroyOnLoad(gameObject);
        } 
    }
}
