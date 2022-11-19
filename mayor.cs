class mayor:numeros{
     private int n1{get;set;}
    private int n2{get;set;}
    private int n3{get;set;}
    public mayor (int n1,int n2,int n3):base(n1,n2,n3){
        this.n1=n1;
        this.n2=n2;
        this.n3=n3;
        if(n1>n2 && n1>n3)  
        {
            Console.WriteLine(" el numero mayor es ;" +n1);
        }
            else if (n2>n1 && n2>n3){
                Console.WriteLine(" el numero mayor es ;" +n2);

            }
            else if (n3>n1 && n3>n2){
                Console.WriteLine(" el numero mayor es ;" +n3);

            }

        }
}
