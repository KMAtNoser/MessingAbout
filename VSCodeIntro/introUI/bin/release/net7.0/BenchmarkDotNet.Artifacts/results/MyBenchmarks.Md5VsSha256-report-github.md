``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2251)
12th Gen Intel Core i7-1270P, 1 CPU, 16 logical and 12 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
| Method |      Mean |     Error |    StdDev |
|------- |----------:|----------:|----------:|
| Sha256 |  4.506 μs | 0.0862 μs | 0.0922 μs |
|    Md5 | 14.652 μs | 0.1573 μs | 0.1395 μs |
