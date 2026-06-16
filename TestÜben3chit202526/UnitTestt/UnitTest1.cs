using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using BasicMath;

/*
public class Tests
{
    private Rechner r;
    
    [SetUp]
    public void Setup()
    {
        var r = new Rechner();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
        Assert.Equals(5, r.Add(2, 3));
        Assert.Equals(8, r.Add(5, 3));
    }
}

*/


/*
using NUnit.Framework;

namespace UnitTest;

public class Tests
{
    private Rechner r;

    [SetUp]
    public void Setup()
    {
        r = new Rechner();
    }

    [Test]
    public void Add_ShouldReturn5_When2Plus3()
    {
        // bevorzugt: Assert.AreEqual
        Assert.That(r.Add(2,3), Is.EqualTo(5));
        
        
        // Alternative moderne Syntax:
        Assert.That(r.Add(2,3), Is.EqualTo(5));
    }
}
*/
































namespace UnitTest;

public class UnitTest
{
    private Rechner r;

    [SetUp]
    public void SetUp()
    {
        r = new Rechner();
    }

    [Test]
    public void Test()
    {
        Assert.That(r.Add(2, 3), Is.EqualTo(5));
    }
}