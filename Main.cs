public static void Main() {
    int c = Console.ReadInt();
    switch(c){
        case 0:
        Application.exit;
        break;

        case 1:
        Contato c = new Contato();
        agenda.adicionar(c)
        break;

        case 2:
        Contato c = new Contato();
        pesquisar(c);
        break;
        
        case 3:
        Contato c;
        String nc;
        alterar(c, nc);
        break;

        case 4:
        Contato c;
        remover(c);
        break;

        case 5:
        foreach(var contato in agenda){
            return this.contato;
        }
        break;
    }
}
