using NUnit.Framework;
using System;
using Test;

namespace NunitTest
{
	[TestFixture ()]
	public class Test
	{
		[Test]
		public void TestCase ()
		{
			Student s1 = new Student ("Shreehanesh", 123, 99, 98);
			Assert.AreEqual (11, s1.funLength());		// Testing function funLength
		}

		[Test]
		public void TestCase2()
		{
			Student s2 = new Student("Shreehanesh", 123, 99, 98);
			Assert.AreEqual (197, s2.Total_score ());	// Testing function Total_score
		}
			
	}
}

