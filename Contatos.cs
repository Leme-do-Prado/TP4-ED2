public class Contatos{
    private List<Contato> agenda;

    public bool adicionar(Contato c){
        agenda.Add(c);
    }

    public Contato pesquisar(Contato c){
        foreach(var contato in agenda){
            if(c.equals(this.contato)){
                return this.contato;
            }
        }
    }

        public bool alterar(Contato c, String nc){
            int i = agenda.IndexOf(c);
            agenda[i] = nc;
        }

        public bool remover(Contato c){
            agenda.Remove(pesquisar(c));
         }



}
