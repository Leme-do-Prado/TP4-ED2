public class Contato{
    private String email;
    private String nome;
    private Data dtNascimento;
    private List<Telefone> telefones;

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
        
    }
}
