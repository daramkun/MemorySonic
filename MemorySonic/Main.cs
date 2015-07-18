using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MemorySonic
{
	public partial class Main : Form
	{
		[DllImport ( "psapi" )]
		public static extern int EmptyWorkingSet ( IntPtr handle );

		void SetFree ()
		{
			Process [] process = Process.GetProcesses ();
			long mem = 0;
			foreach ( Process p in process ) mem += p.WorkingSet64;
			PrintLog ( String.Format ( "비우기 전 실제 사용 메모리 용량 : {0:0}MB", mem / 1000.0f / 1000.0f ) );
			mem = 0;

			foreach ( Process p in process ) try { EmptyWorkingSet ( p.Handle ); } catch { }

			process = Process.GetProcesses ();
			foreach ( Process p in process ) mem += p.WorkingSet64;
			PrintLog ( String.Format ( "비운 후 실제 사용 메모리 용량 : {0:0}MB", mem / 1000.0f / 1000.0f ) );
		}

		void PrintLog ( string log )
		{
			log = "[" + DateTime.Now.ToString("MM-dd hh:mm:ss") + "]" + log;
			lstLog.Items.Add ( log );
			lstLog.SelectedIndex = lstLog.Items.Count - 1;
		}

		public Main ()
		{
			InitializeComponent ();

			PrintLog ( "다람 메모리 클리너가 시작되었습니다." );
		}

		private void chkFree_CheckedChanged ( object sender, EventArgs e )
		{
			tmrFree.Enabled = chkFree.Checked;
		}

		private void btnFree_Click ( object sender, EventArgs e )
		{
			SetFree ();
		}

		private void tmrFree_Tick ( object sender, EventArgs e )
		{
			SetFree ();
		}
	}
}
