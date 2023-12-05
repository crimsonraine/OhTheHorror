// using System.Collections;
// using System.Collections.Generic;
// using NUnit.Framework;
// using UnityEngine;
// using UnityEngine.TestTools;

// public class Presentation
// {
//     // A Test behaves as an ordinary method
//     // [Test]
//     // public void TestOpenCloseAngle()
//     // {
//     //     // Use the Assert class to test conditions
//     // }

//     // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
//     // `yield return null;` to skip a frame.

//     [UnityTest]
//     public IEnumerator RotationTester()
//     {

//         var gameObject = new GameObject("DoorObject");
//         var doorLikeObj = gameObject.AddComponent<Door>();
//         float baseRotation = doorLikeObj.transform.rotation.eulerAngles.y;

//         doorLikeObj.GetComponent<Door>.Open();

//         yield return new WaitForSeconds(1f);

//         Assert.AreEqual(baseRotation + 90, doorLikeObj.transform.rotation.eulerAngles.y);
//         yield return null;
//     }

//     [UnityTest]
//     public IEnumerator UpdateBalloonCounterTest()
//     {
//         // testing the function UpdateBalloonCounter
//         var gameObject = new GameObject();

//         public GameManager gameManager;
//         public DetectCollision detectCollision;

//         gameManager.balloonsCounter = 0;


//         detectCollision.UpdateBalloonCounter();

//         Assert.AreEqual(1, gameManager.balloonsCounter);
//         Assert.AreEqual("Balloons Found: 2/5", detectCollision.UpdateBalloonCounter(););
//     }
// }
