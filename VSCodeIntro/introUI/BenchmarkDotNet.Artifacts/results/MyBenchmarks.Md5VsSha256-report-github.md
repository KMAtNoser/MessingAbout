``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2251)
12th Gen Intel Core i7-1270P, 1 CPU, 16 logical and 12 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
| Method |      Mean |     Error |    StdDev |
|------- |----------:|----------:|----------:|
| Sha256 |  4.491 μs | 0.0789 μs | 0.0738 μs |
|    Md5 | 14.637 μs | 0.2619 μs | 0.2450 μs |
