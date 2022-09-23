public class Contato{
    private String email;
    private String nome;
    private Data dtNascimento;
    private List<Telefone> telefones;

    public Contato(String e, String n, Data dtn){
        this.email = e;
        this.nome = n;

    }

    public Contato(){
        String a, b = Console.ReadString();
        Data c = Data();
        Contato(a, b, c);
    }

    public void setEmail(String e){
        this.e = email;
    }


    public int getIdate(){
        return this.dtNascimento;
    }

    public void adicionarTelefone(Telefone t){
        telefones.Add(t);
    }

    public String getTelefonePrincipal(){
        foreach (var i in telefones){
            if(this.principal == true){
                return this.Telefone;
            }
        }
    }

    public override String toString(){
        String perfil = this.nome + ", " + this.email + ", " + ToString(dtNascimento) + ", " + getTelefonePrincipal();
        return perfil;
    }

    public override bool Equals(object obj){
        return this.Contato.Equals(((Contato)obj));
    }
}
