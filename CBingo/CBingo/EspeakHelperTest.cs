using NUnit.Framework;
using System;

namespace CBingo
{
	[TestFixture()]
	public class EspeakHelperTest
	{
		[Test()]
		public void ToSpeak ()
		{
			Assert.AreEqual ("'1'",EspeakHelper.ToEspeak(1));
			Assert.AreEqual ("'5'",EspeakHelper.ToEspeak(5));
			Assert.AreEqual ("'9'",EspeakHelper.ToEspeak (9));
			Assert.AreEqual ("'10 1 0'", EspeakHelper.ToEspeak(10));
			Assert.AreEqual ("'15 1 5'", EspeakHelper.ToEspeak (15));
			Assert.AreEqual ("'90 9 0'", EspeakHelper.ToEspeak (90));
		}
	}
}

