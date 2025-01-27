# Singleton Design Pattern in Unity

> [As described in GeeksforGeeks,](https://www.geeksforgeeks.org/singleton-design-pattern/) The Singleton Design Pattern ensures a class has only one instance and provides a global access point to it. It’s ideal for scenarios requiring centralized control or configuration settings.

Although singleton design patterns are used for many operations, the most common area of ​​use is in scripts that need to keep variables and their values ​​between scenes, such as GameManager.cs. 

This repository aims to demonstrate the use of the singleton design pattern using two simple scenes that demonstrate a bool value that persists between scenes with the help of Singleton.cs.

The code for the singleton used in this project can be downloaded from the [release section of the repository](https://github.com/fsaltunyuva/UnitySingleton/releases) and is as follows:

```csharp
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
            DontDestroyOnLoad(gameObject); // This will keep the Singleton object alive between scenes.
        } 
    }
}

```

As used in this repository, other scripts can access the variables in Singleton.cs as follows:

```csharp
Singleton.Instance.exampleBool
```

Apart from being used directly from Singleton.cs, the Singleton Design Pattern can also be extended by other scripts. An example of this is in this repository and is as follows:

```csharp
public class GameManager : Singleton
{
    // Necessary variables and methods
}
```

> [!NOTE]
> [This question in StackExchange](https://gamedev.stackexchange.com/questions/116009/in-unity-how-do-i-correctly-implement-the-singleton-pattern) and [this article in gamedevbeginner.com](https://gamedevbeginner.com/singletons-in-unity-the-right-way/#game_manager_singletons) are used when creating the project and the README.md file.
