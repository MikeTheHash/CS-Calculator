using System;

class Calculator{
	public int a(int n1, int n2){
		return n1 + n2;
	}
	public int s(int n1, int n2){
		return n1 - n2;
	}
	public int d(int n1, int n2){
		return n1 / n2;
	}
	public int m(int n1, int n2){
		return n1 * n2;
	}
}

class CalcProgram{
	static void print(string text){
		Console.WriteLine(text); 
	}
    static void Main(){
		Calculator calc = new Calculator();
		while(true){
			print("---C# Calculator---");
			print("Code lines: 101");
			print("Language: C#");
			print("Author: MikeTheHash");
			print("---------------------------------------");
			print("By MikeTheHash : github.com/MikeTheHash");
			print("---------------------------------------");
			print("[~]  selects the number corresponding to the operation:");
			print("\n[1] Addition \n[2] Substraction \n[3] Division \n[4] Multiplication");
			print("---------------------------------------");
			string choice = Console.ReadLine();
			if(choice == "1"){
				print("[+] Setted Addition");
				print("-----------------------------------");
				print("[~] Insert the first number: ");
				string n = Console.ReadLine();
				int n1 = Convert.ToInt32(n);
				print($"[+] First number setted: {n1} ");
				print("-----------------------------------");
				print("[~] Insert the second number");
				string n2s = Console.ReadLine();
				int n2 = Convert.ToInt32(n2s);
				print($"[+] Second number setted: {n2} ");
				int r = calc.a(n1, n2);
				print($"[+] Result: {r}");
			}
			else if(choice == "2"){
				print("[+] Setted Substraction");
				print("-----------------------------------");
				print("[~] Insert the first number: ");
				string n = Console.ReadLine();
				int n1 = Convert.ToInt32(n);
				print($"[+] First number setted: {n1} ");
				print("-----------------------------------");
				print("[~] Insert the second number");
				string n2s = Console.ReadLine();
				int n2 = Convert.ToInt32(n2s);
				print($"[+] Second number setted: {n2} ");
				int r = calc.s(n1, n2);
				print($"[+] Result: {r}");
			}
			else if(choice == "3"){
				print("[+] Setted Division");
				print("-----------------------------------");
				print("[~] Insert the first number: ");
				string n = Console.ReadLine();
				int n1 = Convert.ToInt32(n);
				print($"[+] First number setted: {n1} ");
				print("-----------------------------------");
				print("[~] Insert the second number");
				string n2s = Console.ReadLine();
				int n2 = Convert.ToInt32(n2s);
				print($"[+] Second number setted: {n2} ");
				int r = calc.d(n1, n2);
				print($"[+] Result: {r}");
			}
			else if(choice == "4"){
				print("[+] Setted Moltiplication");
				print("-----------------------------------");
				print("[~] Insert the first number: ");
				string n = Console.ReadLine();
				int n1 = Convert.ToInt32(n);
				print($"[+] First number setted: {n1} ");
				print("-----------------------------------");
				print("[~] Insert the second number");
				string n2s = Console.ReadLine();
				int n2 = Convert.ToInt32(n2s);
				print($"[+] Second number setted: {n2} ");
				int r = calc.m(n1, n2);
				print($"[+] Result: {r}");
			}
			else{
				throw new ArithmeticException("Operation NOT FOUND (404)");
			}
    	}
	}
}
