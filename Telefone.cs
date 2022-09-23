public class Telefone{
    private String tipo;
    private String numero;
    private bool principal;

    public Telefone(String t, String n, bool p){
        this.tipo = t;
        this.numero = n;
        this.principal = p;
    }

    public Telefone(){
        int a, b, c = Console.ReadInt();
        Telefone(a, b, c);
    }

    public void setTipo(String t){
        this.tipo = t;
    }

    public void setNumero(String n){
        this.numero = n;
    }

    public void setPrincipal(bool p){
        this.principal = p;
    }

    public String getTipo(){
        return this.tipo;
    }

    public String getNumero(){
        return this.numero;
    }

    public bool getPrincipal(){
        return this.principal;
    }
}
