namespace KevinSharedProject
{
    public interface ITestClass
    {
        bool Method1();
    }

    public class Class1 : ITestClass
    {
        public bool Method1()
        {
            return true;
        }
    }
}
