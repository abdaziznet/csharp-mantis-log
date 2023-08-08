namespace MantisLog
{
	public class LogFiles
	{
        public string LogName { get; set; }
        public string Date { get; set; }
		public string Time { get; set; }
		public string GuidThreadId { get; set; }
		public string AppName { get; set; }
		public string AppVersion { get; set; }
		public string Info { get; set; }
		public string Message { get; set; }

		public LogFiles()
		{
			this.LogName = LogName;
			this.Date = Date;
			this.Time = Time;
			this.GuidThreadId = GuidThreadId;
			this.AppName = AppName;
			this.AppVersion = AppVersion;
			this.Info = Info;
			this.Message = Message;
			
		}
	}
}
