using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace RoadBook.CshrpBasic.Chapter13
{
    class program
    {
        static ILog log = LogManager.GetLogger("Program");

        static void Main(string[] args)
        {
            log.Debug("디버그 메시지");
            log.Info("정보 메시지");
            log.Warn("경고 메시지");
            log.Error("에러 메시지");
            log.Fatal("치명적인 에러 메시지");
        }
    }
}