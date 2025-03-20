using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{ 
[Header("Tags")]
    [SerializeField] private string createTag;

private void Awake()
{
    GameObject obj = GameObject.FindWithTag(this.createTag);
    if (obj != null)
    {
        Destroy(this.gameObject);
    }
    else
    {
        this.gameObject.tag = this.createTag;
        DontDestroyOnLoad(this.gameObject);
    }
}
}
