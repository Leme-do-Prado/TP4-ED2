public class Data{
    private int dia;
    private int mes;
    private int ano;

    public void setData(int d, int  m, int a){
        this.dia = d;
        this.mes = m;
        this.ano = a;
    }

    public override ToString(){
        String stringdata = dia + "/" + mes + "/" ano;
        return stringdata;
    }
}
