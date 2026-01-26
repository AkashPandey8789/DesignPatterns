public interface ICourse
{
    public void GetCourseDetails();
}

public interface ISource
{
    public void GetCourseSource();
}

public class BackendCourse : ICourse
{
    public void GetCourseDetails()
    {
        Console.WriteLine("Backend course");
    }
}

public class FrontEndCourse : ICourse
{
    public void GetCourseDetails()
    {
        Console.WriteLine("Frontend course");
    }
}

public class YoutubeCourse : ISource
{
    public void GetCourseSource()
    {
        Console.WriteLine("Online Course - platform Youtube");
    }
}

public class OfflineCoachingCourse : ISource
{
    public void GetCourseSource()
    {
        Console.WriteLine("In-person classes");
    }
}

public interface ICourseSourceFactory
{
    ICourse GetCourse();
    ISource GetSource();
}

public class BackendOnlineFactory : ICourseSourceFactory
{
    public ICourse GetCourse()
    {
        return new BackendCourse();
    }

    public ISource GetSource()
    {
        return new YoutubeCourse();
    }
}

public class FrontendOfflineFactory : ICourseSourceFactory
{
    public ICourse GetCourse()
    {
        return new FrontEndCourse();
    }

    public ISource GetSource()
    {
        return new OfflineCoachingCourse();
    }
}