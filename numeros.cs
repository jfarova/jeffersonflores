class numeros{
    private int n1{get;set;}
    private int n2{get;set;}
    private int n3{get;set;}
    public numeros (int n1,int n2,int n3){
        this.n1=n1;
        this.n2=n2;
        this.n3=n3;
        
    }
    public void imprimir(){
        Console.WriteLine("el numeros ingresados son ; " + n1 + "," + n2 + "," + n3 );
    }
}