public class Data{
    private int dia;
    private int mes;
    private int ano;

    public Data(int d, int  m, int a){
        this.dia = d;
        this.mes = m;
        this.ano = a;
    }

    public Data(){
        int a, b, c = Console.ReadInt();
        Data(a, b, c);
    }

    public void setDia(int d){
        this.dia = d;
    }

    public void setMes(int m){
        this.mes = d;
    }

    public void setAno(int a){
        this.ano = a;
    }

    public int getDia(){
        return this.dia;
    }

    public int getMes(){
        return this.mes;
    }

    public int getAno(){
        return this.ano;
    }

    public override String ToString(){
        String stringdata = dia + "/" + mes + "/" ano;
        return stringdata;
    }
}
