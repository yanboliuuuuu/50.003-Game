using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEditor;

public class TestingSpawner {
	[UnityTest]
	public IEnumerator TestingSpawnerWithEnumeratorPasses() {
		var starPrefab = Resources.Load ("Tests/star");
		var starSpawner = new GameObject ().AddComponent<StarPointScript> ();
		starSpawner.Construct (starPrefab);
		yield return null;

		var spawnedStar = GameObject.FindWithTag ("Star");
		var prefabOfTheSpawnedStar = PrefabUtility.GetPrefabParent (spawnedStar);

		Assert.AreEqual (starPrefab, prefabOfTheSpawnedStar);



	}
}
