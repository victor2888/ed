using System;
using Gtk;
using System.Collections.Generic;
using System.Diagnostics;

using CBingo;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Bombo bombo = new Bombo ();
		Panel panel = new Panel ();



	
		vBoxMain.Add(panel.Table);


		buttonGoForward.Clicked += delegate {

			int bola = bombo.SacarBola();
			panel.MarcarNumero(bola);
			Process.Start("espeak","-v es "+ EspeakHelper.ToEspeak(bola));
			buttonGoForward.Sensitive = bombo.QuedanBolas();

			
//		for (int vez = 0; int.MaxValue; i++) {
//			int numeroAleatorio = random.Next (1000);
//			if(numeroAleatorio < 5 || numeroAleatorio >= 995)
//			Console.WriteLine ("vez= " +vez + " numeroAleatorio" + numeroAleatorio);
		};

		
	}


	protected void OnDeleteEvent (object sender, DeleteEventArgs a){
	
		Application.Quit ();
		a.RetVal = true;
	}
}
