using FrostFire.Engine;

namespace FrostFire.Adventure;

public partial class GameInterface : Form
{
    private Player _player;
        
    public GameInterface()
    {
        InitializeComponent();

        _player = new Player();

        _player.CurrentHitPoints = 10;
        _player.MaxHitPoints = 10;
        _player.Golds = 10;
        _player.ExperiencePoints = 0;
        _player.Level = 1;

        lblHitPoints.Text = _player.CurrentHitPoints.ToString();
        lblGold.Text = _player.Golds.ToString();
        lblExperience.Text = _player.ExperiencePoints.ToString();
        lblLevel.Text = _player.Level.ToString();
    }

 
}
