using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TargetFactoryTest {

    [Test]
    public void TargetFactory_GetInstance_Test()
    {
        // Setup
        TargetFactory tf = new TargetFactory();
        GameObject instance = tf.GetInstance(new GameObject("Target"));

        // Confirm the instance was return
        Debug.Log(instance.name);
        Assert.AreEqual("Target(Clone)", instance.name);
    }

    [Test]
    public void TargetFactory_CalculateInstanceLocation_Test()
    {
        // Setup
        TargetFactory tf = new TargetFactory();

        // Confirm that CalculateInstanceLocation returns a random set bween bounds
        Vector3 center = new Vector3(50, 50, 50);
        Vector3 dimensions = new Vector3(50, 50, 50);
        Vector3 randomPos = tf.CalculateInstanceLocation(center, dimensions);

        Assert.Greater(randomPos.x, 0);
        Assert.Greater(randomPos.y, 0);
        Assert.Greater(randomPos.z, 0);
        Assert.Less(randomPos.x, 100);
        Assert.Less(randomPos.y, 100);
        Assert.Less(randomPos.z, 100);
    }
}
