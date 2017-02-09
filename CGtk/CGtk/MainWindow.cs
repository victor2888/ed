using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		Console.WriteLine("27/10 = "+ 27/10 + "resto = " + 27%10) 


		labelSaludo.Text = "Hola. Pon tu nombre y pulsa Adelante";

		//Table table = new Table (9, 10, true);
		//for (uint vez = 0; index< 90; index++) {
			//Button button = new Button ();
			//button.Label = " " + (index +1);
			//button.Visible = true;
			//uint row = index/10;
			//uint column = index % 10;
			//table.Attach (button, column,column + 1, 0, 1);
			//button.Clicked += OnButtonGoForwardClicked;

		Table table = new Table (9, 10, true);
		for (uint row = 0; row< 90; row++) {
			for(uint column = 0; column < 10; column)
				uint  indexer = row *10 +Column;
				Button button = new Button ();
				button.Label = " " + (index +1);
				button.Visible = true;
				uint row = index/10;
				uint column = index % 10;
				table.Attach (button, column,column + row, row +1);
				button.Clicked += OnButtonGoForwardClicked;

		}
		table.Visible = true;
		vBoxMain.Add (table);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Console.WriteLine ("OnDeleteEvent");
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void OnButtonGoForwardClicked (object sender, EventArgs e)
	{
		Button button = (Button)sender;
		labelSaludo.Text = "Hola " + entryNombre.Text + "pulsado " + button.Label;
	}
}
