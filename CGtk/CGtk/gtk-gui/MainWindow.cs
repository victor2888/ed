
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vBoxMain;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Label label1;
	private global::Gtk.Entry entryNombre;
	private global::Gtk.Button buttonGoForward;
	private global::Gtk.Label labelSaludo;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vBoxMain = new global::Gtk.VBox ();
		this.vBoxMain.Name = "vBoxMain";
		this.vBoxMain.Spacing = 6;
		// Container child vBoxMain.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Introduce tu nombre");
		this.hbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entryNombre = new global::Gtk.Entry ();
		this.entryNombre.CanFocus = true;
		this.entryNombre.Name = "entryNombre";
		this.entryNombre.IsEditable = true;
		this.entryNombre.InvisibleChar = '•';
		this.hbox1.Add (this.entryNombre);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryNombre]));
		w2.Position = 1;
		this.vBoxMain.Add (this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vBoxMain [this.hbox1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vBoxMain.Gtk.Box+BoxChild
		this.buttonGoForward = new global::Gtk.Button ();
		this.buttonGoForward.CanFocus = true;
		this.buttonGoForward.Name = "buttonGoForward";
		this.buttonGoForward.UseStock = true;
		this.buttonGoForward.UseUnderline = true;
		this.buttonGoForward.Label = "gtk-go-forward";
		this.vBoxMain.Add (this.buttonGoForward);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vBoxMain [this.buttonGoForward]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vBoxMain.Gtk.Box+BoxChild
		this.labelSaludo = new global::Gtk.Label ();
		this.labelSaludo.Name = "labelSaludo";
		this.labelSaludo.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
		this.vBoxMain.Add (this.labelSaludo);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vBoxMain [this.labelSaludo]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vBoxMain);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonGoForward.Clicked += new global::System.EventHandler (this.OnButtonGoForwardClicked);
	}
}
