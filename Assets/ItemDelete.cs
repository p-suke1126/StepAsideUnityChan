using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour {

    private GameObject unitychan;

	// Use this for initialization
	void Start () {
        //Unityちゃんのオブジェクトを取得
        unitychan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z < unitychan.transform.position.z-7)
        {
            Destroy(gameObject);
        }
	}
}
