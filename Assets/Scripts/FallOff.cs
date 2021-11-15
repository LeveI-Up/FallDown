using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallOff : MonoBehaviour
{
    [SerializeField] GameOver gameover;
    [SerializeField] Score score;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameover.Setup(score.GetNumber());    // Input can either be a serial number or a name; here we use name.
            Destroy(other);
            
        }
    }
}
