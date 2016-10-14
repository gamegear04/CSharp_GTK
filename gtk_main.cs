using Gtk;
using System;

/// <summery>
/// Mit GTK laesst sich Windows Forms auf Linux umsetzen
/// </summery>

// Info: Programm kompilieren wie folgt:
// mcs -pkg:gtk-sharp-2.0 meins.cs

class programm : Window{

        public programm() : base ("Hello GTK")
        {
                DeleteEvent += delegate {
                        Application.Quit();
                };
                this.Show();
        }

        public static void Main()
        {
                Application.Init();
                new programm();
                Application.Run();
        }
}
