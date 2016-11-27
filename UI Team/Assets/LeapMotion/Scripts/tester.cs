using UnityEngine;
using System.Collections;
using Leap.Unity;

public class tester : MonoBehaviour
{
    GameObject indexBone1;
    Vector3 thePos;

    // Update is called once per frame
    void Update()
    {
        indexBone1 = GameObject.FindGameObjectWithTag("indexBone1");
        // Debug.Log(test);
        if (indexBone1 != null)
        {
            Debug.Log(indexBone1);
            thePos = indexBone1.GetComponent<Transform>().position;
            this.gameObject.GetComponent<Transform>().position = new Vector3(thePos.x*50, thePos.y*50, -0.5f);
        }

    }

    public void printSomthing()
    {
        Debug.Log("Yes");
    }

    public void printSomthing2()
    {
        Debug.Log("No");
    }
}
