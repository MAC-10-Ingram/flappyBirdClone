using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //-2.15 3.35
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(5,Random.Range(-2.15f, 3.35f),0);
            timer = 0;
            Destroy(newPipe, 5f);
        }
        
    }
}
