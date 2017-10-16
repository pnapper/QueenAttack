using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using QueenAttack.Models;
using System;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void GetValue_ReturnResult1_True()
    {
      QueenAttackGenerator newValue = new QueenAttackGenerator();

      var result = newValue.CanAttack(1,2,1,7);

      Assert.AreEqual(true,result);
    }

    [TestMethod]
    public void GetValue_ReturnResult2_True()
    {
      QueenAttackGenerator newValue = new QueenAttackGenerator();

      var result = newValue.CanAttack(1,7,3,7);

      Assert.AreEqual(true,result);
    }
    [TestMethod]
    public void GetValue_ReturnResult3_True()
    {
      QueenAttackGenerator newValue = new QueenAttackGenerator();

      var result = newValue.CanAttack(6,3,8,5);

      Assert.AreEqual(true,result);
    }

    [TestMethod]
    public void GetValue_ReturnResult4_True()
    {
      QueenAttackGenerator newValue = new QueenAttackGenerator();

      var result = newValue.CanAttack(8,5,6,3);

      Assert.AreEqual(true,result);
    }

    [TestMethod]
    public void GetValue_ReturnResult5_True()
    {
      QueenAttackGenerator newValue = new QueenAttackGenerator();

      var result = newValue.CanAttack(6,3,3,6);

      Assert.AreEqual(true,result);
    }

    [TestMethod]
    public void GetValue_ReturnResult6_True()
    {
      QueenAttackGenerator newValue = new QueenAttackGenerator();

      var result = newValue.CanAttack(6,7,2,3);

      Assert.AreEqual(true,result);
    }
  }

}
