namespace WinFormsContainersApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Button btn1 = new Button();
            btn1.Text = "Click me";
            btn1.Size = new(200, 36);
            btn1.Location = new Point(50, 200);

            grpControls.Controls.Add(btn1);

            int row = 0;
            for(int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Dock = DockStyle.Fill;
                btn.Location = new Point(0, 0);
                table.Controls.Add(btn, i % 3, row);
                if (i < 3)
                    row = 0;
                if (i > 2 && i < 6)
                    row = 1;
                if(i > 5)
                    row = 2;
            }

        }
    }
}
