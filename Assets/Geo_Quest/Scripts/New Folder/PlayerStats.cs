using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "Scene_2";

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        switch (collision.tag)
        {
            case "Death":  //respawn if dies
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish": //next Scene
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}


 
