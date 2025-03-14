namespace TN01_CadastroContato
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void mnu_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro form = new Cadastro();
            form.ShowDialog();
        }

        private void mnu_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnu_sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema ainda em Construção", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void mnu_listagem_Click(object sender, EventArgs e)
        {
            Listagem form = new Listagem();
            form.ShowDialog();
        }

        private void CarregarLista()
        {

            Contato.ListaContatos.Add(
                new Contato
                {
                    codigo = 1,
                    nome = "Ana",
                    sobrenome = "Silva",
                    ddd = "11",
                    telefone = "987654321",
                    tipoTelefone = ETipoTelefone.Pessoal,
                    email = "ana.silva@email.com"
                }
            );

            Contato.ListaContatos.Add(new Contato { codigo = 2, nome = "João", sobrenome = "Santos", ddd = "21", telefone = "998877665", tipoTelefone = ETipoTelefone.Pessoal, email = "joao.santos@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 3, nome = "Maria", sobrenome = "Oliveira", ddd = "31", telefone = "999123456", tipoTelefone = ETipoTelefone.Pessoal, email = "maria.oliveira@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 4, nome = "Carlos", sobrenome = "Pereira", ddd = "41", telefone = "986543210", tipoTelefone = ETipoTelefone.Pessoal, email = "carlos.pereira@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 5, nome = "Fernanda", sobrenome = "Costa", ddd = "51", telefone = "988776655", tipoTelefone = ETipoTelefone.Pessoal, email = "fernanda.costa@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 6, nome = "Pedro", sobrenome = "Almeida", ddd = "61", telefone = "991122233", tipoTelefone = ETipoTelefone.Comercial, email = "pedro.almeida@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 7, nome = "Julia", sobrenome = "Mendes", ddd = "71", telefone = "992233344", tipoTelefone = ETipoTelefone.Comercial, email = "julia.mendes@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 8, nome = "Lucas", sobrenome = "Rodrigues", ddd = "81", telefone = "995544332", tipoTelefone = ETipoTelefone.Comercial, email = "lucas.rodrigues@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 9, nome = "Patricia", sobrenome = "Souza", ddd = "91", telefone = "997788665", tipoTelefone = ETipoTelefone.Comercial, email = "patricia.souza@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 10, nome = "Ricardo", sobrenome = "Nascimento", ddd = "11", telefone = "981234567", tipoTelefone = ETipoTelefone.Pessoal, email = "ricardo.nascimento@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 11, nome = "Gabriela", sobrenome = "Lima", ddd = "21", telefone = "996655443", tipoTelefone = ETipoTelefone.Comercial, email = "gabriela.lima@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 12, nome = "Marcos", sobrenome = "Gomes", ddd = "31", telefone = "977788991", tipoTelefone = ETipoTelefone.Pessoal, email = "marcos.gomes@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 13, nome = "Camila", sobrenome = "Silveira", ddd = "41", telefone = "999877665", tipoTelefone = ETipoTelefone.Comercial, email = "camila.silveira@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 14, nome = "Juliano", sobrenome = "Ferreira", ddd = "51", telefone = "986543321", tipoTelefone = ETipoTelefone.Pessoal, email = "juliano.ferreira@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 15, nome = "Renata", sobrenome = "Martins", ddd = "61", telefone = "993311443", tipoTelefone = ETipoTelefone.Comercial, email = "renata.martins@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 16, nome = "Eduardo", sobrenome = "Barbosa", ddd = "71", telefone = "991144557", tipoTelefone = ETipoTelefone.Pessoal, email = "eduardo.barbosa@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 17, nome = "Luana", sobrenome = "Moura", ddd = "81", telefone = "994455668", tipoTelefone = ETipoTelefone.Pessoal, email = "luana.moura@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 18, nome = "Thiago", sobrenome = "Costa", ddd = "91", telefone = "999022233", tipoTelefone = ETipoTelefone.Comercial, email = "thiago.costa@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 19, nome = "Adriana", sobrenome = "Dias", ddd = "11", telefone = "987123456", tipoTelefone = ETipoTelefone.Pessoal, email = "adriana.dias@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 20, nome = "Gustavo", sobrenome = "Vasquez", ddd = "21", telefone = "988334455", tipoTelefone = ETipoTelefone.Comercial, email = "gustavo.vasquez@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 21, nome = "Isabela", sobrenome = "Martins", ddd = "31", telefone = "988887766", tipoTelefone = ETipoTelefone.Pessoal, email = "isabela.martins@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 22, nome = "Fábio", sobrenome = "Azevedo", ddd = "41", telefone = "994422778", tipoTelefone = ETipoTelefone.Comercial, email = "fabio.azevedo@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 23, nome = "Simone", sobrenome = "Macedo", ddd = "51", telefone = "983344556", tipoTelefone = ETipoTelefone.Recado, email = "simone.macedo@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 24, nome = "Rodrigo", sobrenome = "Martins", ddd = "61", telefone = "992211334", tipoTelefone = ETipoTelefone.Recado, email = "rodrigo.martins@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 25, nome = "Priscila", sobrenome = "Nunes", ddd = "71", telefone = "991122334", tipoTelefone = ETipoTelefone.Recado, email = "priscila.nunes@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 26, nome = "Felipe", sobrenome = "Gonçalves", ddd = "81", telefone = "996633442", tipoTelefone = ETipoTelefone.Recado, email = "felipe.goncalves@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 27, nome = "Renato", sobrenome = "Soares", ddd = "91", telefone = "998877664", tipoTelefone = ETipoTelefone.Recado, email = "renato.soares@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 28, nome = "Tatiane", sobrenome = "Ribeiro", ddd = "11", telefone = "987654321", tipoTelefone = ETipoTelefone.Recado, email = "tatiane.ribeiro@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 29, nome = "Alberto", sobrenome = "Pinto", ddd = "21", telefone = "993311225", tipoTelefone = ETipoTelefone.Pessoal, email = "alberto.pinto@email.com" });
            Contato.ListaContatos.Add(new Contato { codigo = 30, nome = "Claudia", sobrenome = "Cavalcante", ddd = "31", telefone = "988991122", tipoTelefone = ETipoTelefone.Comercial, email = "claudia.cavalcante@email.com" });

        }
    }
}
