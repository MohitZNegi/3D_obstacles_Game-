using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] List<GameObject> Checkpoints;
    [SerializeField] Vector3 vectorPoint;
    [SerializeField] float dead;


  
 void Awake()  {
   if (player.transform.position.y < -dead)
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
}
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -dead)
        {
            player.transform.position = vectorPoint;
        }
    }

    private void OnTriggerEnter(Collider other) {
        vectorPoint = player.transform.position;
        Destroy(other.gameObject);
    }
}
