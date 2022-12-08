``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2251)
12th Gen Intel Core i7-1270P, 1 CPU, 16 logical and 12 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
| Method |     Mean |    Error |   StdDev |   Median |
|------- |---------:|---------:|---------:|---------:|
| Sha512 | 29.54 μs | 0.742 μs | 2.116 μs | 28.86 μs |
|    Md5 | 21.48 μs | 0.415 μs | 0.368 μs | 21.42 μs |
