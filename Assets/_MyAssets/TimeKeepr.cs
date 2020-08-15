using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeepr : MonoBehaviour
{

    [Header("この字幕が出る時間")]
    [SerializeField]
    float startTime;

    [Header("この字幕が消える時間")]
    [SerializeField]
    float endTime;

    Vector3 defaultV;


    // Start is called before the first frame update
    void Start()
    {
        defaultV = this.transform.localScale;
        this.transform.localScale = Vector3.one * 0.01f;

        StartCoroutine(Jimaku());

    }

    IEnumerator Jimaku()
    {
        yield return new WaitForSeconds(startTime);

        this.transform.localScale = defaultV;
        yield return new WaitForSeconds(endTime - startTime);
        this.transform.localScale = Vector3.one * 0.01f;

    }

}
