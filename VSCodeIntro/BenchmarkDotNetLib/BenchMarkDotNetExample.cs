using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    public interface IRandomDataBuff
    {
        byte[] Data {get;}
    }

    public class RandomDataBuff:
        IRandomDataBuff
    {
        private const int N = 10000;
        public byte[] Data {get; private set;}
        
        public RandomDataBuff()
        {
            Data = new byte[N];
            new Random(42).NextBytes(Data);
        }
    }

    public class HasherBenchMarker<T>
        where T: HashAlgorithm
    {
        private readonly T _hashAlgorithm;
        private readonly IRandomDataBuff _randomDataBuff;

        public HasherBenchMarker(
            T hashAlgorithm,
            IRandomDataBuff randomDataBuff)
        {
            _hashAlgorithm = hashAlgorithm;
            _randomDataBuff = _randomDataBuff; 
        }

        [Benchmark]
        public byte[] ComputeHash() => _hashAlgorithm.ComputeHash(_randomDataBuff.Data);
    }
}