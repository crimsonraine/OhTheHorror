using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Presentation
{
    // A Test behaves as an ordinary method
    [Test]
    public void UpdateBalloonCounterTest()
    {
        // Use the Assert class to test conditions

    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PresentationWithEnumeratorPasses()
    {

        // testing the function UpdateBalloonCounter
        var gameObject = new GameObject();

        public GameManager gameManager;
        public DetectCollision detectCollision;

        gameManager.balloonsCounter = 0;


        detectCollision.UpdateBalloonCounter();

        Assert.AreEqual(1, gameManager.balloonsCounter);
        Assert.AreEqual("Balloons Found: 2/5", detectCollision.UpdateBalloonCounter(););


        yield return null;
    }
}
