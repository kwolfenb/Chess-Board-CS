using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongClassTest
  {
    [TestMethod]
    public void PingPongWorks_NormalCount_True()
    {
        PingPongClass testPingPong = new PingPongClass();
        Assert.AreEqual("7", PingPongClass.PingPongWorks(7));
    }

    [TestMethod]
    public void PingPongWorks_NumberDivisibleByThree_Ping()
    {
        PingPongClass testPingPong = new PingPongClass();
        Assert.AreEqual("ping", PingPongClass.PingPongWorks(6));
    }

    [TestMethod]
    public void PingPongWorks_NumberDivisibleByFive_Pong()
    {
        PingPongClass testPingPong = new PingPongClass();
        Assert.AreEqual("pong", PingPongClass.PingPongWorks(10));
    }
  }
}