﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TradeSharp.Contract.Entity;
using TradeSharp.Util;

namespace TradeSharp.Test.Entity
{
    [TestFixture]
    public class NuDalSpot
    {
        private LotByGroupDictionary lotDictionary;

        [TestFixtureSetUp]
        public void Setup()
        {
            lotDictionary = new LotByGroupDictionary
                {
                    dictionary = new Dictionary<string, Dictionary<string, VolumeStep>>
                        {
                            {
                                "Demo", new Dictionary<string, VolumeStep>
                                    {
                                        {"EURUSD", new VolumeStep(10000, 10000)},
                                        {"GBPUSD", new VolumeStep(10000, 5000)}
                                    }
                            },
                            {
                                "Nano", new Dictionary<string, VolumeStep>
                                    {
                                        {"EURUSD", new VolumeStep(100, 100)},
                                        {"GBPUSD", new VolumeStep(100, 100)},
                                        {"USDJPY", new VolumeStep(100, 100)}
                                    }
                            }
                        }
                };
        }

        [Test]
        public void LotByGroupDictionarySaveLoad()
        {
            var path = ExecutablePath.ExecPath + "\\lotdic.txt";
            lotDictionary.SaveInFile(path);
            var dic2 = LotByGroupDictionary.LoadFromFile(path);

            Assert.Greater(dic2.dictionary.Count, 0, "dic is loaded and not empty");
            Assert.AreNotEqual(0, dic2.GetHashCodeForDic(), "loaded dic has not 0 hash");
            Assert.AreEqual(lotDictionary.GetHashCodeForDic(), dic2.GetHashCodeForDic(), "same dics has same hashes");

            var firstKey = dic2.dictionary.Keys.First();
            var firstPair = dic2.dictionary[firstKey].Keys.First();
            dic2.dictionary[firstKey][firstPair] = new VolumeStep(5000, 1000);
            Assert.AreNotEqual(0, dic2.GetHashCodeForDic(), "loaded&modified dic has not 0 hash");
            Assert.AreNotEqual(lotDictionary.GetHashCodeForDic(), dic2.GetHashCodeForDic(), "modified dics has different hashes");
        }
    }
}
