using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;


public class ProjectileEmitterTest {

    [Test]
    public void ProjectileEmitter_Fire_Test()
    {
        // Setup
        LogAssert.ignoreFailingMessages = true;
        ProjectileEmitter_FireLightProjectile emitter = new ProjectileEmitter_FireLightProjectile();
        GameObject projectileMock = ProjectileMockup();
        emitter.setPrefab(projectileMock);

        Vector3 position = new Vector3(0, 0, 0);
        Quaternion rotation = new Quaternion();
        emitter.fire(position, rotation);
        GameObject firedProjectile = GameObject.Find("Projectile(Clone)");

        Assert.IsNotNull(firedProjectile);
        Assert.AreNotEqual(firedProjectile.GetComponent<Rigidbody>().velocity, new Vector3(0,0,0));
    }

    private GameObject ProjectileMockup()
    {
        GameObject mock = new GameObject("Projectile");
        mock.AddComponent<Rigidbody>();
        return mock;
    }
}
