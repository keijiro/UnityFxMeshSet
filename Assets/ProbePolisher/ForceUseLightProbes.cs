using UnityEngine;
using System.Collections;

public class ForceUseLightProbes : MonoBehaviour
{
    void Start ()
    {
        renderer.useLightProbes = true;
    }
}
