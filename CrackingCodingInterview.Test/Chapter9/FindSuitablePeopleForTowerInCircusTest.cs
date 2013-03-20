using System;
using System.Collections;
using CrackingCodingInterview.Chapter9;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter9
{
    [TestFixture]
    public class FindSuitablePeopleForTowerInCircusTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {

                Tuple<int, int>[] input = new Tuple<int, int>[] 
                                            {
                                                Tuple.Create(65, 100), 
                                                Tuple.Create(70, 150), 
                                                Tuple.Create(56, 90), 
                                                Tuple.Create(75, 190), 
                                                Tuple.Create(60, 95), 
                                                Tuple.Create(68, 110)
                                            };
                
                Tuple<int, int>[] output = new Tuple<int, int>[] 
                                            {
                                                Tuple.Create(56, 90), 
                                                Tuple.Create(60,95), 
                                                Tuple.Create(65,100), 
                                                Tuple.Create(68,110), 
                                                Tuple.Create(70,150), 
                                                Tuple.Create(75,190)
                                            };


                yield return
                    new TestCaseData((object)input)
                        .Returns(output);
            }
        }


        [TestCaseSource("TestCases")]
        [Test]
        public Tuple<int, int>[] Test(Tuple<int, int>[] arg)
        {
            Tuple<int, int>[] result = RunTest(arg, new FindSuitablePeopleForTowerInCircus());
            return result;
        }
    }
}
