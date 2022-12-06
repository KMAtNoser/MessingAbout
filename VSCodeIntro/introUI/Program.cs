using System;
using System.Diagnostics;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Autofac;

using introLibrary;
using MyBenchmarks;

namespace introUI
{
    class Program
    {
        public void Run()
        {
            var container = initContainer();

            var person = container.Resolve<IPerson>();
            Console.WriteLine($"{person.FirstName} - {person.Surname} - {person.BirthDate}");

            doBenchMarks(container); // Only runs in DEBUG
        }

        private IContainer initContainer()
        {
            var builder = new ContainerBuilder();

            // Register individual components
            builder.RegisterInstance(new Person(
                firstName: "Kevin",
                surname: "Melvin",
                birthDate: new DateTime(year: 1963, month: 6, day: 9)
            ))
                   .As<IPerson>();

            initContainerWithBenchMarkObjects(
                builder: builder);

            return builder.Build();
        }

        [Conditional("RELEASE")]
        private void initContainerWithBenchMarkObjects(
            ContainerBuilder builder)
        {
            builder.RegisterInstance(new RandomDataBuff())
                .As<IRandomDataBuff>();

            // Register individual components
            builder.RegisterType<HasherBenchMarker<MD5>>()
                .As<HasherBenchMarker<MD5>>()
                .WithParameter("hashAlgorithm", MD5.Create());

            builder.RegisterType<HasherBenchMarker<SHA256>>()
                .As<HasherBenchMarker<SHA256>>()
                .WithParameter("hashAlgorithm", SHA256.Create());
        }

        [Conditional("RELEASE")]
        private void doBenchMarks(
            IContainer container)
        {
            var summary = BenchmarkRunner.Run<HasherBenchMarker<SHA256>>();
        }
    }
}
