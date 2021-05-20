using System; 

class minhaClasse {

    static void Main(string[] args) { 
            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2,sheldon, raj;
            for (int i=1;  i<=qtdTeste;  i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
           
                if (( v1=="tesoura" && v2=="papel") || ( v1=="papel" && v2=="pedra")
                
                    || (v1=="pedra" && v2=="lagarto" ) || (v1=="lagarto" && v2=="Spok" )
                    
                    
                    || (v1=="Spok" && v2=="tesoura") || (v1=="tesoura" && v2=="lagarto")
                    
                    
                    || (v1=="lagarto" && v2=="papel" ) || (v1=="papel" && v2=="Spok")
                      
                    
                    || (v1=="Spok" && v2=="pedra") || ( v1=="pedra" && v2=="tesoura" ))
                    Console.WriteLine("Caso #{0}: Bazinga!", i); 
                  
                    else if (( v2=="tesoura" && v1=="tesoura") || ( v2=="papel" && v1=="papel")
                
                    || (v2=="pedra" && v1=="pedra" ) || (v2=="lagarto" && v1=="lagarto" )
                    
                    
                    || (v2=="Spok" && v1=="Spok"))
                     Console.WriteLine("Caso #{0}: De novo!", i);
                    
                      else 
                        Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
                        
                      

                   
                  

            

    }

}}