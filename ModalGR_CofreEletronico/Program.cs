﻿using ModalGR_CofreEletronico.ModalGR;

//Criação do objeto da classe CofreEletronico
var Cofre = new CofreEletronico(); 
//Declaração de variáveis
string senhaCriptografada1; 
string senhaCriptografada2; 
string senhaCriptografada3;         
string senhaTextoPuro1; 
string senhaTextoPuro2; 
string senhaTextoPuro3;

//Exibe o titulo escrito na classe "CofreEletronico"
Cofre.ExibeTitulo();   

//Pede pro usuário inserir a senha
Console.Write("Digite a primeira senha: ");
//Registra a senha que o usuário colocou
senhaTextoPuro1 = Console.ReadLine();
//Declara a senha criptografada como primeira criptografia feita pela método "PrimeiraCriptografia"
senhaCriptografada1 = Cofre.PrimeiraCriptografia(senhaTextoPuro1);
//Mostra ao usuario a o retorno da senha criptografada
Console.WriteLine("Senha criptografada: " + senhaCriptografada1);   
Console.WriteLine();

Console.Write("Digite a segunda senha: ");
senhaTextoPuro2 = Console.ReadLine();
senhaCriptografada2 = Cofre.SegundaCriptografia(senhaTextoPuro2);
Console.WriteLine("Senha criptografada: " + senhaCriptografada2);
Console.WriteLine();

Console.Write("Digite a terceira senha: ");
senhaTextoPuro3 = Console.ReadLine();
senhaCriptografada3 = Cofre.TerceiraCriptografia(senhaTextoPuro3);
Console.WriteLine("Senha criptografada: " + senhaCriptografada3);




