
namespace MyFirstXamarinApp
{
    public class Common
    {
        public Common()
        {
        }

        public static int addCounts(int count)
        {
            return count++;
        }

        internal static void goToWebsite() {
            //on lance le navigateur ou on ouvre une webview?
            //Process myProcess = new Process();
            //myProcess.Start("http://munabees.com");
            //Device.OpenUri(new Uri("http://munabees.com"));
        }
    }
}
