using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;


public class LightboxFactoryTest
{

    [Test]
    public void LightboxGetInstance_Test()
    {
        Debug.Log(GameState.instance);
        // Setup
        LightboxFactory lb = new LightboxFactory(new GameObject("Lightbox"));
        GameObject instance = lb.GenerateInstance(new Vector3(1, 1, 1), new Quaternion(10, 10, 10, 10));

        // Test that the projectile is detached from the parent after configure
        Assert.IsNull(instance.transform.parent);
    }
}
