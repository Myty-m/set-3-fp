using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace set_3_fp
{
    internal class Program
    {
        static public int[] quicksort(int[] a, int st, int dr)
        {
            if (st < dr)
            {
                int i = partition(a, st, dr);
                quicksort(a, st, i - 1);
                quicksort(a, st + 1, dr);
            }
            return a;
        }
        static public int partition(int[] a, int st, int dr)
        {
            int pivot = a[dr];
            int i = st - 1;
            for (int j = st; j < dr; j++)
            {
                if (a[j] < pivot)
                {
                    i++;
                    (a[i], a[j]) = (a[j], a[i]);
                }            }
                (a[i+1], a[dr]) = (a[dr], a[i+1]);
            return (i+1);
        }

        static void Main(string[] args)
         {
            void p()
            {
                Console.Write("alegeti numarul problemei:");
                int a = 1;
                while (a != 0)
                {
                    a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 0:
                            a = 0;
                            break;
                        case 1:
                            p1();
                            p();
                            break;
                        case 2:
                            p2();
                            p();
                            break;
                        case 3:
                            p3();
                            p();
                            break;
                        case 4:
                            p4();
                            p();
                            break;
                        case 5:
                            p5();
                            p();
                            break;
                        case 6:
                            p6();
                            p();
                            break;
                        case 7:
                            p7();
                            p();
                            break;
                        case 8:
                            p8();
                            p();
                            break;
                        case 9:
                            p9();
                            p();
                            break;
                        case 10:
                            p10();
                            p();
                            break;
                        case 11:
                            p11();
                            p();
                            break;
                        case 12:
                            p12();
                            p();
                            break;
                        case 13:
                            p13();
                            p();
                            break;
                        case 14:
                            p14();
                            p();
                            break;
                        case 15:
                            p15();
                            p();
                            break;
                        case 16:
                            p16();
                            p();
                            break;
                        case 17:
                            p17();
                            p();
                            break;
                    }
                    break;
                }
            }
            void p1()
            {
                Console.WriteLine("Cerinta:");
                int n, s = 0;
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                    s = s + a[i];
                }
                Console.WriteLine(s);
            }
            void p2()
            {
                Console.WriteLine("Cerinta:");
                int n, poz = -1, k;
                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                    if (a[i] == k)
                        Console.WriteLine($"{k} se afla in vector pe pozitia {i}");
                }
            }
            void p3()
            {
                Console.WriteLine("Cerinta:");
                int n, poz = -1, k;
                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                    if (a[i] == k)
                        Console.WriteLine($"{k} se afla in vector pe pozitia {i}");
                }
            }
            void p4()
            {
                Console.WriteLine("Cerinta:");
                int n, min, max, a1 = 1, a2 = 1;
                // a1 = aparitii min
                // a2 = aparitii max
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                a[0] = int.Parse(Console.ReadLine());
                min = a[0];
                max = a[0];
                for (int i = 1; i < n; i++)
                {

                    a[i] = int.Parse(Console.ReadLine());
                    if (a[i] == min)
                        a1++;
                    if (a[i] == max)
                        a2++;
                    if (a[i] < min)
                    {
                        min = a[i];
                        a1 = 1;
                    }
                    if (a[i] > max)
                    {
                        max = a[i];
                        a2 = 1;
                    }
                }
                Console.WriteLine($"minimul este {min} si apare de {a1} ori, iar maximul este {max} si apare de {a2} ori");
            }
            void p5()
            {
                Console.WriteLine("Cerinta:");
                int n, e, k, aux = 0;
                bool ok = false;
                n = int.Parse(Console.ReadLine());
                e = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                int[] a = new int[n + 1];
                for (int i = 0; i < n; i++)
                {
                    if (ok)
                    {
                        a[i] = aux;
                        aux = a[i];
                    }
                    a[i] = int.Parse(Console.ReadLine());
                    if (i == k - 1)
                    {
                        aux = a[i];
                        a[i] = e;
                        ok = true;
                    }

                }
                a[n] = aux;
                Console.WriteLine("vectorul acum este:");
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            void p6()
            {
                Console.WriteLine("Cerinta:");
                int n, k;
                bool ok = true;
                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                int[] a = new int[n];

                for (int i = 0; i < n-1; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                    if (i == k-1 && ok)
                    {
                        ok = false;
                        i--;
                    }
                }

                for (int i = 0; i < n - 1; i++)
                Console.Write(a[i] + " ");
            }
            void p7()
            {
                Console.WriteLine("Cerinta:");
                int n;
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n / 2; i++)
                {
                    (a[i], a[n - i - 1]) = (a[n - i - 1], a[i]);
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            void p8()
            {
                Console.WriteLine("Cerinta:");
                int n, aux;
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                aux = a[0];
                for (int i = 0; i < n-1; i++)
                {
                    a[i] = a[i + 1];
                }
                a[n-1] = aux;
                for (int i = 0; i < n; i++)
                    Console.Write($"{a[i]} ");

            }            
            void p9()
            {
                Console.WriteLine("Cerinta:");
                int n, aux, k;
                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j < k; j++)
                {
                    aux = a[0];
                    for (int i = 0; i < n - 1; i++)
                    {
                        a[i] = a[i + 1];
                    }
                    a[n - 1] = aux;
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            void p10()
            {
                Console.WriteLine("Cerinta:");
                int n, mij, finder = -1, k, st, dr;
                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                int[] a = new int[n]; 
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                st = 0;
                dr = n;
                while(st != dr)
                {
                    mij = st + dr;
                }
            }
            void p11()
            {
                Console.WriteLine("Cerinta:");
            }
            void p12()
            {
                Console.WriteLine("Cerinta:");
            }
            void p13()
            {
                Console.WriteLine("Cerinta:");
            }
            void p14()
            {
                Console.WriteLine("Cerinta:");
                int n, k = 1;
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n - k; i++)
                {
                    for (int j = 0; j < n; j++)
                        if (a[n - k] == 0)           
                            k++;
                    else
                           break;
                    if (n - k < i)
                        break;
                    if (a[i] == 0)
                    {
                        (a[i], a[n - k]) = (a[n - k], a[i]);

                    }

                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            void p15()
            {
                Console.WriteLine("Cerinta:");
                int n;
                bool ok = false;
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                     
                    for (int j = i + 1; j < n; j++) 
                    {
                        
                        if (a[i] == a[j])
                        {
                        for (int k = i; k < n - 1; k++)
                            a[k] = a[k + 1];
                            n--;
                            ok = true;
                        }                        
                    }
                    //il scadem pe i cu 1 pentru a verifica dupa schimbarea vectorului variabila care era  a[i+1] inainte iar acum este pe a[i]
                    //daca nu il scadem pe i, intr-un vector de 10 de 1 ne rezulta 1 1 1 in loc de 1
                    if (ok)
                        i--;
                    ok = false;
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{a[i]} ");
                }

            }
            void p16()
            {
                Console.WriteLine("Cerinta:");
                int n, d = 0;
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                int x, y;
                x = a[1];
                for (int i = 1; i < n; i++)
                {
                    y = a[i];
                    while (x != y)
                        if (x > y)
                            x = x - y;
                        else
                            y = y - x;
                    d = y;
                    x = d;
                }
                Console.WriteLine($"Cel mai mare divizor comun al elementelor din vector este {d}");

            }
            void p17()
            {
                Console.WriteLine("Cerinta:");
                
            }
            void p18()
            {
                Console.WriteLine("Cerinta:");
            }
            void p19()
            {
                Console.WriteLine("Cerinta:");
                int s, r, aparitii = 0, ok = 0;
                s = int.Parse(Console.ReadLine());
                r = int.Parse(Console.ReadLine());
                int[] a = new int[s];
                int[] b = new int[r];

                for (int i = 0; i < s; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < r; i++)
                {
                    b[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i <= s-r; i++)
                {
                    if (a[i] == b[0])
                    {
                        for (int j = 0; j < r; j++)
                            if (a[j + i] == b[j])
                                ok++;
                    }
                    if (ok == r)
                        aparitii++;
                    ok = 0;
                }
                Console.WriteLine("numarul de aparitii este " + aparitii);
            }
            void p20()
            {
                Console.WriteLine("Cerinta:");
            }
            void p21()
            {
                Console.WriteLine("Cerinta:");
            }
            void p22()
            {
                Console.WriteLine("Cerinta:");
            }
            void p23()
            {
                Console.WriteLine("Cerinta:");
            }
            void p24()
            {
                Console.WriteLine("Cerinta:");
            }
            void p25()
            {
                Console.WriteLine("Cerinta:");
                int s, r, a = 0, b = 0;
                bool ok1 = true, ok2 = true, add1, add2;
                s = int.Parse(Console.ReadLine());
                r = int.Parse(Console.ReadLine());
                int[] v1 = new int[s];
                int[] v2 = new int[r];
                int[] v3 = new int[s + r];
                for (int i = 0; i < s; i++)
                {
                    v1[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < r; i++)
                {
                    v2[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < s + r; i++)
                {
                    add1 = false;
                    add2 = false;
                    if (v1[a] < v2[b] && ok1 && ok2)
                    {
                        v3[i] = v1[a];
                        add1 = true;

                    }
                    if (v1[a] == v2[b] && ok1 && ok2)
                    { 
                            v3[i] = v1[a];
                            add1 = true;

                            if (add1)
                                i++;
                            v3[i] = v2[b];
                            add2 = true;
                        
                    }
                    
                    if (v2[b] < v1[a] && ok2 && ok1)
                    {
                        if (add1)
                            i++;
                        v3[i] = v2[b];
                        add2 = true;
                    }
                    if (ok2 == false)
                    {
                        v3[i] = v1[a];
                        add1 = true;
                    }
                    if (ok1 == false)
                    {
                        v3[i] = v2[b];
                        add2 = true;
                    }
                    if(add1)
                    a++;

                    if (a == s)
                    {
                        ok1 = false;
                        a--;
                    }
                    
                    if(add2)
                    b++;
                    
                    if (b == r)
                    {
                        ok2 = false;
                        b--;
                    }
                    
                }
                for (int i = 0; i < s+r; i++)
                {
                    Console.Write($"{v3[i]} ");
                }
                Console.ReadKey();
            }
            void p26()
            {
                Console.WriteLine("Cerinta:");

            }
            void p27()
            {
                Console.WriteLine("Cerinta:");
                int n,i;
                n = int.Parse(Console.ReadLine());
                i = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int j = 0; j < n; j++)
                {
                    a[j] = int.Parse(Console.ReadLine());
                }
                quicksort(a, 0, n - 1);
                Console.WriteLine($"pe pozitia {i} este {a[i]}");
            }
            
            void p28()
            {
                Console.WriteLine("Cerinta:");
                int n;
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                a = quicksort(a, 0, n-1);
                //quicksort(a, a[0], a[n - 1]).CopyTo(a, 0);
                for (int i = 0; i < n; i++)
                    Console.Write(a[i] + " ");

            }
            void p29()
            {
                Console.WriteLine("Cerinta:");
            }
            void p30()
            {
                Console.WriteLine("Cerinta:");
            }
            void p31()
            {
                Console.WriteLine("Cerinta:");
            }

        }   
    }
}
