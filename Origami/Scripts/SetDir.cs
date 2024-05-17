using Godot;
using System;
using System.IO;

public class SetDir : LineEdit
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
public string Game_dir = "";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }



private void _on_LineEdit_text_entered(String PL_dir)
{
	// Replace with function body.
	GD.Print(PL_dir);
	string path = @PL_dir;
	string[] files = System.IO.Directory.GetFiles(path);
	GD.Print(files);
}

private void _on_Button_pressed()
{
	
}


}


private void _on_FileDialog_dir_selected(String dir)
{
	// Replace with function body.
}
