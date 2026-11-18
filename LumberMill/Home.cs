using System.Data;

namespace LumberMill;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();
        this.Load += Home_Load!;
    }

    private void Home_Load(object sender, EventArgs e)
    {
        show_client();
    }

    private void show_client()
    {
        try
        {
            DataTable dt = DB.Query("select * from data.v_client_details;");

            dgv_client.DataSource = dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString(), "Greška pri dohvatu klijenata");
        }
    }
}