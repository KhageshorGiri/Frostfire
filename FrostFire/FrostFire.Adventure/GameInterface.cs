namespace FrostFire.Adventure;

public partial class GameInterface : Form
{
    public GameInterface()
    {
        InitializeComponent();
    }

    private void TestBtnClikcEvent(object sender, EventArgs e)
    {
        lblGold.Text = "Gold Here";
    }
}
