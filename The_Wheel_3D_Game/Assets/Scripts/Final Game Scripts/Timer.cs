using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public float timeStart;

    [SerializeField] public GameObject gameover;
    [SerializeField] public GameObject gamecompleted;
[SerializeField] public GameObject bg;    
     [SerializeField] public GameObject stage1;
       [SerializeField] public GameObject stage2;
         [SerializeField] public GameObject stage3;
           [SerializeField] public GameObject stage4;
             [SerializeField] public GameObject stage5;
    [SerializeField] public GameObject Player;
    public Text textBox;
    bool timerActive = true;

    


	// Use this for initialization
	void Start () {
        textBox.text ="Time:" + timeStart.ToString("F2");
         gameover.GetComponent<GameObject>();
          gamecompleted.GetComponent<GameObject>();
           bg.GetComponent<GameObject>();
          stage1.GetComponent<GameObject>();
          stage2.GetComponent<GameObject>();
          stage3.GetComponent<GameObject>();
          stage4.GetComponent<GameObject>();
          stage5.GetComponent<GameObject>();
          Player.GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if(timerActive){
            timeStart += Time.deltaTime;
            textBox.text ="Time:" + timeStart.ToString("F2");
        }

        if (timeStart >= 300.0f)
        {
              timerActive = false;
              gameover.SetActive(true);
                Player.SetActive(false);
                textBox.text="Score:00";


        }
     
	}

      private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "end")
        {
          timerActive = false;
           gamecompleted.SetActive(true);
            bg.SetActive(true);
            Player.SetActive(false);
             textBox.text="Score: "+ (Mathf.Round(timeStart * 10f) / 100f) * 100 ;

          
        }

        
    }

    private void OnTriggerEnter(Collider other) {
         if(other.gameObject.tag == "Stage1")
        {
       
           stage1.SetActive(true);
           
          
        }

          if(other.gameObject.tag == "Stage2")
        {
       
          
            stage2.SetActive(true);
            

          
        }
          if(other.gameObject.tag == "Stage3")
        {
       
        
             stage3.SetActive(true);
            

          
        }
          if(other.gameObject.tag == "Stage4")
        {
       
         
              stage4.SetActive(true);
            
         

          
        }
          if(other.gameObject.tag == "Stage5")
        {
       
         
               stage5.SetActive(true);
         

          
        }

         if(other.gameObject.tag == "Checkpoint")
        {
       
           stage1.SetActive(false);
            stage2.SetActive(false);
             stage3.SetActive(false);
              stage4.SetActive(false);
               stage5.SetActive(false);
           
          
        }
         
        
    }


}