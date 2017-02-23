using System;
using Gtk;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
//		IList<int> list = new List<int> ();
//		list.Add (16);
//		list.Add (15);
//		list.Add (17);
//		list.Add (5);
//		list.Add (4);

//		foreach (int item in list)
//			Console.WriteLine ("item= "+ item)

		IList<int> bolas = new List<int> ();
		for (int numero = 1; numero<=90; numero++)
			bolas.Add (numero);

		Random random = new Random ();
		buttonGoForward.Clicked += delegate {
			int randomIndex = random.Next (bolas.Count) + 1;
			int bola = bolas[randomIndex]
			Console.WriteLine("bola =  " + bola);
			bolas.Remove(bola);
			buttonGoForward.Sensitive = false;

			Proccess.Start("espeak", bola.ToString());
//		for (int vez = 0; int.MaxValue; i++) {
//			int numeroAleatorio = random.Next (1000);
//			if(numeroAleatorio < 5 || numeroAleatorio >= 995)
//			Console.WriteLine ("vez= " +vez + " numeroAleatorio" + numeroAleatorio);
		};
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
