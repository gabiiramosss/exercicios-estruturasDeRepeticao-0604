//Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

//Do While

 string usuario;
 string senha;

 do
 {
     Console.WriteLine($"Insira seu usuário: ");
     usuario = Console.ReadLine();

     Console.WriteLine($"Insira sua senha: ");
     senha = Console.ReadLine();

     if (usuario == senha)
     {
         Console.WriteLine($"Revise seus dados e insira-os novamente!");
     }
 }  while (usuario == senha);