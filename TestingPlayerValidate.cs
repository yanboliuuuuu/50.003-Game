using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestingPlayerValidate {

	SpriteBehaviour subject;

	[SetUp]
	public void SetUp(){
		subject = new SpriteBehaviour ();

	}

//	INTIAL PLAYER STATUS
	[Test]
	public void XSpeedTest() {
		Assert.IsTrue (subject.XSpeed >= 0);
	}

//	[Test]
//	public void YSpeedTest() {
//		Assert.IsTrue (subject.YSpeed >= 0);
//	}

	[Test]
	public void DashStatusTest() {
		Assert.IsTrue (subject.dashStatus == 0);
	}

	[Test]
	public void DirectionStatusTest() {
		Assert.IsTrue (subject.dashStatus == 0);
	}


//	MOVE LEFT
	[Test]
	public void MoveLeftXSpeedTest() {
		subject.MoveLeft ();
		Assert.IsTrue (subject.XSpeed == -5);
	}

	[Test]
	public void MoveLeftDirectionStatusTest() {
		subject.MoveLeft ();
		Assert.IsTrue (subject.directionStatus == -1);
	}


//	MOVE RIGHT
	[Test]
	public void MoveRightXSpeedTest() {
		subject.MoveRight ();
		Assert.IsTrue (subject.XSpeed == 5);
	}

	[Test]
	public void MoveRightDirectionStatusTest() {
		subject.MoveRight ();
		Assert.IsTrue (subject.directionStatus == 1);
	}


//	NO MOVEMENT
	[Test]
	public void SetVelocityZeroTest() {
		subject.SetVelocityZero ();
		Assert.IsTrue (subject.XSpeed == 0);
	}


//	DASH LEFT
	[Test]
	public void DashLeftXSpeedTest() {
		subject.MoveLeft ();
		subject.Dash ();
		Assert.IsTrue (subject.XSpeed == -30);
	}

	[Test]
	public void DashLeftDirectionStatusTest() {
		subject.MoveLeft ();
		subject.Dash ();
		Assert.IsTrue (subject.directionStatus == 0);
	}

	[Test]
	public void DashLeftDashStatusTest() {
		subject.MoveLeft ();
		subject.Dash ();
		Assert.IsTrue (subject.dashStatus == 1);
	}

	[Test]
	public void DashLeftDashDurationTest() {
		subject.MoveLeft ();
		subject.Dash ();
		Assert.IsTrue (subject.dashDuration <= 0.07);
	}



//	DASH RIGHT
	[Test]
	public void DashRightXSpeedTest() {
		subject.MoveRight ();
		subject.Dash ();
		Assert.IsTrue (subject.XSpeed == 30);
	}

	[Test]
	public void DashRightDirectionStatusTest() {
		subject.MoveRight ();
		subject.Dash ();
		Assert.IsTrue (subject.directionStatus == 0);
	}

	[Test]
	public void DashRightDashStatusTest() {
		subject.MoveRight ();
		subject.Dash ();
		Assert.IsTrue (subject.dashStatus == 1);
	}

	[Test]
	public void DashRightDashDurationTest() {
		subject.MoveLeft ();
		subject.Dash ();
		Assert.IsTrue (subject.dashDuration <= 0.07);
	}


	[UnityTest]
	public IEnumerator WhileDashLeftDashStatusTest(){
		subject.MoveLeft ();
		subject.Dash ();
		yield return new WaitForSeconds (0.01f);
		subject.Dash ();
		Assert.IsTrue (subject.dashStatus == 0);
	}

	[UnityTest]
	public IEnumerator WhileDashRightDashStatusTest(){
		subject.MoveRight ();
		subject.Dash ();
		yield return new WaitForSeconds (0.01f);
		subject.Dash ();
		Assert.IsTrue (subject.dashStatus == 0);
	}

//	JUMP
	[Test]
	public void JumpVerticallyYSpeedTest(){
		subject.setVelocity ();
		subject.getVelocity ();
		subject.Jump ();
		Assert.IsTrue (subject.dashStatus == 0);
	}

	[Test]
	public void JumpRightYSpeedTest(){
		subject.MoveRight();
		subject.Jump ();
		Assert.IsTrue (subject.XSpeed == 5);
	}
}
