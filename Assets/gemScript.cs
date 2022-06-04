using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gemScript : MonoBehaviour
{
    public Text timer;
    public int seconds = 25;
    public bool isTime = false;
    public AudioSource audio;
    GameObject[] gems;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,2,0);
        if(seconds > 0) {
            if(!isTime) {
                StartCoroutine(timeCalculate());
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        audio.Play();
        Destroy(gameObject);
    }

    IEnumerator timeCalculate() {
        isTime = true;
        seconds--;
        timer.text = "" + seconds;
        yield return new WaitForSeconds(1);
        isTime = false;
    }
}
