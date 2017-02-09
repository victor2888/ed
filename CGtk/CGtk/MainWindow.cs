using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		labelSaludo.Text = "Hola. Pon tu nombre y pulsa Adelante";


		Table table = new Table (9, 10, true);
		table.Visible = true;
		vBox1Main.Add (Table);

		for (uint vez = 0; vez< 5; vez++) {
			Button button = new Button ();
			button.Label = " " + vez;
			button.Visible = true;
			table.Attach (button, vez, vez + 1, 0, 1);
			vBox1Main.Add (button);
			button.Clicked += OnButtonGoForwardClicked;
			

		}

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
