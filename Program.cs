using DEPENDENCY_INJECTION;

public class Program
{
    static void Main(string[] args)
    {
        Home home = new Home();

        STUDENT stu=new STUDENT(home);
        

    }
}
