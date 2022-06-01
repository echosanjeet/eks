using System.Globalization;

namespace kubernetes
{
    public class RunTimeEnv
    {
        public string? Date { get; set; }

        public string? Version { get; set; }

        public string? WebApiType { get; set; }

        public string? DbVersion { get; set; }

        public string? MachineName { get; set; }

        public string? MachineOS { get; set; }

        public string? User { get; set; }

        

        public RunTimeEnv()
        {
            Date = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture);
            Version = "Dev 1.0";
            WebApiType = "Public";
            DbVersion = "1.0";
            MachineName = Environment.MachineName;
            MachineOS = Environment.OSVersion.Platform.ToString();
            User = Environment.UserName;
        }
    }
}