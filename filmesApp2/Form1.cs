using filmesApp2.Models;

namespace filmesApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Contexto db;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            this.db.Database.EnsureCreated();
            /*
                        Ator ator = new Ator();
                        ator.Nome = "Robert Downey Jr.";
                        ator.Idade = 50;

                        this.db.Ator.Add(ator);
                        this.db.SaveChanges();

                        Filme f = new Filme();
                        f.Nome = "Homem de Ferro 1";
                        f.AnoLancamento = 2008;
                        f.Atores.Add(ator);

                        this.db.Filme.Add(f);
                        this.db.SaveChanges();*/

            Ator a = this.db.Ator.Where(a => a.Id == 1).ToList()[0];
            a.Nome = "Tom Holland";
            this.db.Ator.Update(a);
            this.db.SaveChanges();

            List<Ator> atores = this.db.Ator.ToList();
            dgvAtores.DataSource = atores;
        }
    }
}
