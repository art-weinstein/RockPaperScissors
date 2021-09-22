// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using RockPaperScissors.Models;
// using System.Collections.Generic;
// using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class PlayerTests
  {
    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
    {
      Player newPlayer = new Player();
      Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }
  }
}

