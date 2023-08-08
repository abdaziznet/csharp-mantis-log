using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantisLog
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Log.Logger = new LoggerConfiguration()
			.WriteTo.Console() // Console sink
			.WriteTo.File("./LOGS/MantisLog_.txt", rollingInterval: RollingInterval.Day) // File sink
			.CreateLogger();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.Run(new FrmInquiryLog());

			Log.CloseAndFlush();
		}
	}
}
