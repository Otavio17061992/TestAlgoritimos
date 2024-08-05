using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        /*
        // Criando duas listas encadeadas
        ListNode list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);

        ListNode list2 = new ListNode(1);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(5);

        // Mesclando as listas
        ListNode mergedList = MergeTwoLists(list1, list2);
        */

        //Console.WriteLine(Alfabet(3));

        SomandoInteiros();
    }


    private static int ConvertInteger(string s)
    {
        int resp = 0, num =0;

        for(int i = s.Length-1; i >= 0; i--)
        {
            switch(s[i])
            {
                case 'I': num = 1; break;
                case 'V': num = 5; break;
                case 'X': num = 10; break;
                case 'L': num = 50; break;
                case 'C': num = 100; break;
                case 'D': num = 500; break;
                case 'M': num = 1000; break;
            }
        }

        if(4*resp < num)
        {
            resp -= num;
        }
        else{
            resp += num;
        }

        return resp;
    }

     private static ListNode MergeTwoLists(ListNode list1, ListNode list2) 
     {
        ListNode dummy = new ListNode(); // Nó fictício para facilitar a construção da lista resultante
        ListNode current = dummy; // Ponteiro para o nó atual na lista resultante

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        // Se uma das listas ainda tiver elementos, adicionamos o restante à lista resultante
        if (list1 != null)
            current.next = list1;
        else
            current.next = list2;

        return dummy.next; // O próximo nó após o nó fictício é o início da lista resultante
    }

    private static string Alfabet(int num)
    {
        List<string> alfabet = new List<string> {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P" ,"Q", "R", "S", "T", "U","V","X","W","Y","Z"};
        string Letters = "";

        // Verica se está no range da string
        if(num >0 && num <= 26)
        {
            int i = 1;

            foreach(string letter in alfabet)
            {
                if(i <= num)
                {
                    Letters +=letter+ ' ';
                }

                i++;
            }
        }

        return Letters;
    }

    private  static void SomandoInteiros() { 

            int A, N;
            do
            {
               
                A = int.Parse(Console.ReadLine());

               
                N = int.Parse(Console.ReadLine());


            } while (N <= 0);

            int soma = 0;
            for (int i = 0; i < N; i++)
            {
                soma += A + i;
            }

            Console.WriteLine(soma);
        }
}

public class ListNode
{
     public int val;
     public ListNode next;
      public ListNode(int val=0, ListNode next=null) 
      {
          this.val = val;
          this.next = next;
      }
}

