namespace App360_Activity;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        SetFormSizeToDisplay();
    }


    private void SetFormSizeToDisplay()
    {
        Screen primaryScreen = Screen.PrimaryScreen;

        this.Width = primaryScreen.Bounds.Width;
        this.Height = primaryScreen.Bounds.Height;

        this.StartPosition = FormStartPosition.CenterScreen;

        headerPanel.Width = primaryScreen.Bounds.Width;

    }
}
