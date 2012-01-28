<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Security.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Deployment.dll</Reference>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

void Main()
{
	string[] names = { "Fred", "Barney", "Betty", "Wilma" };
			using (Form form = new Form())
			{
				foreach (string name in names)
				{
					Button btn = new Button();
					btn.Text = name;
					btn.Click += delegate
					{
						MessageBox.Show(form, name);
					};
					btn.Dock = DockStyle.Top;
					form.Controls.Add(btn);
				}
				Application.Run(form);
			}
	
}

// Define other methods and classes here
