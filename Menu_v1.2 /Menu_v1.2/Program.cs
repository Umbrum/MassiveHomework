﻿using System;
using static System.Convert;
using System.Threading;

namespace Menu_v1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int c;
            Console.CursorVisible = false;
        MenuPr:
            string[] Mn1 = new String[5];
            Mn1[0] = "Elige la opcion que mas te convenga";
            Mn1[1] = "Algebra Lineal";
            Mn1[2] = "Qumica";
            Mn1[3] = "Fisica";
            Mn1[4] = "Salir";
            c = Menu(Mn1, 5);
            switch (c)
            {
                case 1://Algebra Lineal
                    {
                    MenuAlL:
                        string[] Mn2 = new string[4];
                        Mn2[0] = "Elige la opcion que mas te convenga";
                        Mn2[1] = "Incognitas";
                        Mn2[2] = "Matrices";
                        // Mn2[3] = "Matrices";
                        Mn2[3] = "Volver";
                        c = Menu(Mn2, 4);
                        switch (c)
                        {
                            case 1:
                                goto MenuAlL;                       
                            // case 2: holixd                       slow
                            //     goto MenuAlL;
                            case 2://Matrices
                                {
                                MenuMa:
                                    string[] Mm1 = new string[7];
                                    Mm1[0] = "Elige la opcion que mas te convenga";
                                    Mm1[1] = "Operaciones con matrices";
                                    Mm1[2] = "Determinantes";
                                    Mm1[3] = "Traspuesta";
                                    Mm1[4] = "Adjunta";
                                    Mm1[5] = "Inversa";
                                    Mm1[6] = "Volver";
                                    c = Menu(Mm1, 7);
                                    Console.Clear();
                                    switch (c)
                                    {
                                        case 1://Operaciones con Matrices
                                            {
                                            MenuMaOp:
                                                string[] MO = new string[6];
                                                int y1 = 1, y2 = 1, z = 1;
                                                int o = 1, cx = 1;
                                                double[,] m1 = new double[y1, z];
                                                double[,] m2 = new double[y1, z];
                                                MO[0] = "Elije la opcion que mas te convenga";
                                                MO[1] = "Suma";
                                                MO[2] = "Resta";
                                                MO[3] = "Multiplicacion";
                                                MO[4] = "Division";
                                                MO[5] = "Volver";
                                                c = Menu(MO, 6);
                                                Console.Clear();
                                                switch (c)
                                                {
                                                    case 1://Suma
                                                        {
                                                            o = 1;
                                                            Console.CursorVisible = true;
                                                            Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                              "columnas y filas pueden sumarse");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.SetCursorPosition(0, 2);
                                                            Console.Write("Cantidad de filas y de columnas: ");
                                                        asignarZ1:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(33, 2);
                                                                z = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarZ1;
                                                            }
                                                            m1 = AsignarValorMatriz(z, z, 4);
                                                            m2 = AsignarValorMatriz(z, z, 4);
                                                            cx = 2 + TamañoNumero(m1, z, z);
                                                            EscribirValorMatriz(m1, z, z, o, 4);
                                                            Console.SetCursorPosition(o + (z * cx), 4 + (z - 1));
                                                            Console.Write("+");
                                                            o = (cx * z) + 3;
                                                            cx = 2 + TamañoNumero(m2, z, z);
                                                            EscribirValorMatriz(m2, z, z, o, 4);
                                                            Console.SetCursorPosition(o + (z * cx), 4 + (z - 1));
                                                            Console.Write("=");
                                                            o += (cx * z) + 3;
                                                            for (int i = 0; i < z; i++)
                                                            {
                                                                for (int j = 0; j < z; j++)
                                                                {
                                                                    m1[j, i] += m2[j, i];
                                                                }
                                                            }
                                                            cx = 3 + TamañoNumero(m1, z, z);
                                                            EscribirValorMatriz(m1, z, z, o, 4);
                                                            Console.CursorVisible = false;
                                                            Console.ReadKey();
                                                            goto MenuMaOp;
                                                        }
                                                    case 2://Resta
                                                        {
                                                            Console.CursorVisible = true;
                                                            Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                              "columnas y filas pueden restarse");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.SetCursorPosition(0, 2);
                                                            Console.Write("Cantidad de filas y de columnas: ");
                                                        asignarZ2:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(33, 2);
                                                                z = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarZ2;
                                                            }
                                                            m1 = AsignarValorMatriz(z, z, 4);
                                                            m2 = AsignarValorMatriz(z, z, 4);
                                                            cx = 2 * TamañoNumero(m1, z, z);
                                                            EscribirValorMatriz(m1, z, z, o, 4);
                                                            Console.SetCursorPosition(o + (z * cx), 4 + (z - 1));
                                                            Console.Write("-");
                                                            o = (cx * z) + 3;
                                                            cx = 2 * TamañoNumero(m2, z, z);
                                                            EscribirValorMatriz(m2, z, z, o, 4);
                                                            Console.SetCursorPosition(o + (z * cx), 4 + (z - 1));
                                                            Console.Write("=");
                                                            o += (cx * z) + 3;
                                                            for (int i = 0; i < z; i++)
                                                            {
                                                                for (int j = 0; j < z; j++)
                                                                {
                                                                    m1[j, i] -= m2[j, i];
                                                                }
                                                            }
                                                            cx = 2 * TamañoNumero(m1, z, z);
                                                            EscribirValorMatriz(m1, z, z, o, 4);
                                                            Console.CursorVisible = false;
                                                            Console.ReadKey();
                                                            goto MenuMaOp;

                                                        }
                                                    case 3://Multiplicacion
                                                        {
                                                        MultiplicacionMatrices:
                                                            Console.Clear();
                                                            int z1 ,z2;
                                                            Console.CursorVisible = true;
                                                            Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                              "filas que columnas pueden multiplicarse");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.SetCursorPosition(0, 2);
                                                            Console.Write("Cantidad de Filas de la Primera Matriz: ");
                                                        asignarZ11:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(40, 2);
                                                                z1 = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarZ11;
                                                            }
                                                            Console.SetCursorPosition(0, 3);
                                                            Console.Write("Cantidad de Columnas de la Primera Matriz: ");
                                                        asignarY13:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(43, 3);
                                                                y1 = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarY13;
                                                            }
                                                            m1 = AsignarValorMatriz(y1, z1, 4);
                                                            Console.Clear();
                                                            Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                              "filas que columnas pueden multiplicarse");
                                                            Console.SetCursorPosition(0, 2);
                                                            Console.Write("Cantidad de Filas de la Segunda Matriz: ");
                                                        asignarZ21:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(40, 2);
                                                                z2 = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarZ21;
                                                            }
                                                            Console.SetCursorPosition(0, 3);
                                                            Console.Write("Cantidad de Columnas de la Segunda Matriz: ");
                                                        asignarY21:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(43, 3);
                                                                y2 = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarY21;
                                                            }
                                                            m2 = AsignarValorMatriz(y2, z2, 4);
                                                            if (y1 == z2)
                                                            {
                                                                double[,] R = new double[y2, z1];
                                                                cx = 2 + TamañoNumero(m1, y1, z1);
                                                                EscribirValorMatriz(m1, y1, z1, o, 5);
                                                                Console.SetCursorPosition(o + (y1 * cx), 4 + (z1 - 1));
                                                                Console.Write("X");
                                                                o = (cx * y1) + 3;
                                                                cx = 2 + TamañoNumero(m2, y2, z2);
                                                                EscribirValorMatriz(m2, y2, z2, o, 5);
                                                                Console.SetCursorPosition(o + (y2 * cx), 4 + (z2 - 1));
                                                                Console.Write("=");
                                                                o += (cx * y2) + 3;
                                                                for (int i = 0; i < z1; i++)
                                                                {
                                                                    for (int j = 0; j < y2; j++)
                                                                    {
                                                                        for (int k = 0; k < y1; k++)
                                                                        {
                                                                            R[j, i] += m1[k, i] * m2[j, k];
                                                                        }
                                                                    }
                                                                }
                                                                cx = 2 + TamañoNumero(R, y2, z1);
                                                                EscribirValorMatriz(R, y2, z1, o, 5);
                                                                Console.CursorVisible = false;
                                                                Console.ReadKey();
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("ERROR: Solo las matrice que contengan la misma cantidad de " +
                                                                              "filas que columnas pueden multiplicarse");
                                                                Console.ReadKey();
                                                                goto MultiplicacionMatrices;
                                                            }
                                                            goto MenuMaOp;
                                                        }
                                                    case 4://Division
                                                        goto MenuMaOp;
                                                    case 5:
                                                        goto MenuMa;
                                                    default:
                                                        break;
                                                }
                                            }
                                            break;
                                        case 2://Determinante
                                            {
                                            MenuMaDe:
                                                Console.CursorVisible = false;
                                                string[] DE = new string[5];
                                                //int[,] m1 = new int[2, 2];
                                                //int[,] m2 = new int[2, 2];
                                                DE[0] = "Elije la opcion que mas te convenga";
                                                DE[1] = "2x2";
                                                DE[2] = "3x3";
                                                DE[3] = "NxN";
                                                DE[4] = "Volver";
                                                c = Menu(DE, 5);
                                                Console.Clear();
                                                switch (c)
                                                {
                                                    case 1://Matriz 2x2
                                                        {
                                                            double[,] m2 = new double[2, 2];
                                                            double[,] m = new double[2, 2];
                                                            int TC = 1;
                                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                                            Console.Clear();
                                                            Console.WriteLine("Matriz 2x2 ");
                                                            Console.WriteLine("Para calcular el determinante de una matriz 2x2, tienes que " +
                                                                              "ralizar  la multiplicaciÛn y la resta. En este sentido tenemos " +
                                                                              "que multiplicar los n˙meros que se encuentran en las diagonales y " +
                                                                              "encontrar la diferencia entre ellos.");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.CursorVisible = true;
                                                            m2 = AsignarValorMatriz(2, 2, 4);
                                                            TC = 3 + TamañoNumero(m2, 2, 2);
                                                            EscribirValorMatriz(m2, 2, 2, 1, 4);
                                                            Console.CursorVisible = false;
                                                            Console.SetCursorPosition(3, 10);
                                                            Console.Write("La determinante es :" + ((m2[0, 0] * m2[1, 1]) - (m2[0, 1] * m2[1, 0])));
                                                            Console.SetCursorPosition(15, 4);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write("| " + m2[0, 0]);
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine(" " + m2[0, 1] + " |");
                                                            Console.SetCursorPosition(15, 5);
                                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                                            Console.Write("| " + m2[1, 0]);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine(" " + m2[1, 1] + " |");
                                                            Console.SetCursorPosition(30, 4);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write("( " + m2[0, 0] + " * " + m2[1, 1] + " ) ");
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            Console.Write("- ( " + m2[0, 1] + " * " + m2[1, 0] + " ) ");
                                                            Console.SetCursorPosition(30, 5);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write("( " + m2[0, 0] * m2[1, 1] + " ) ");
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.Write("- ( " + m2[0, 1] * m2[1, 0] + " ) ");
                                                            Console.SetCursorPosition(30, 7);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write("( " + Determinante(m2, 2) + " ) ");
                                                            Console.ReadKey();
                                                            goto MenuMaDe;
                                                        }
                                                    case 2://Matriz  3x3
                                                        {
                                                            double[,] m2 = new double[3, 3];
                                                            int TC = 1;
                                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                                            Console.Clear();
                                                            int[,] m = new int[3, 3];
                                                            Console.WriteLine("Matriz 3x3 ");
                                                            Console.WriteLine("Para calcular el determinante de una matriz 3x3, " +
                                                                              "tienes que ralizar  la multiplicaciÛn y la resta. " +
                                                                              "En este sentido tenemos que multiplicar los n˙meros " +
                                                                              "que se encuentran en las diagonales y encontrar la " +
                                                                              "diferencia entre ellos.");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            m2 = AsignarValorMatriz(3, 3, 4);
                                                            TC = 3 + TamañoNumero(m2, 3, 3);
                                                            EscribirValorMatriz(m2, 3, 3,1, 4);
                                                            Console.CursorVisible = false;

                                                            Console.SetCursorPosition(3, 10);
                                                            Console.Write("La determinante es :" + (m2[0, 0] * m2[1, 1] * m2[2, 2] +
                                                                         m2[0, 1] * m2[1, 2] * m2[2, 0] +
                                                                         m2[0, 2] * m2[1, 0] * m2[2, 1] -
                                                                         m2[0, 2] * m2[1, 1] * m2[2, 0] -
                                                                         m2[0, 0] * m2[1, 2] * m2[2, 1] -
                                                                                                    m2[0, 1] * m2[1, 0] * m2[2, 2]));
                                                            Console.SetCursorPosition(15, 4);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write(" ( ( " + (m2[0, 0] * m2[1, 1] * m2[2, 2]) + " )");
                                                            Console.Write(" + ( " + (m2[0, 1] * m2[1, 2] * m2[2, 0]) + " )");
                                                            Console.Write(" + ( " + (m2[0, 2] * m2[1, 0] * m2[2, 1]) + " )");
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.Write(" - ( " + (m2[0, 2] * m2[1, 1] * m2[2, 0]) + " )");
                                                            Console.Write(" - ( " + (m2[0, 0] * m2[1, 2] * m2[2, 1]) + " )");
                                                            Console.Write(" - ( " + (m2[0, 1] * m2[1, 0] * m2[2, 2]) + " ) )");
                                                            Console.SetCursorPosition(15, 5);
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.Write("( " + Determinante(m2, 3) + " ) ");
                                                            Console.ReadKey();
                                                            goto MenuMaDe;
                                                        }
                                                    case 3://Matriz NxN
                                                        {
                                                            int nFC, o;
                                                            double R = 1;
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Matriz NxN");
                                                            Console.WriteLine("Nota: Toma en cuenta que solo se puede hacer determinante de " +
                                                                              "matrices cuadradas.");
                                                            Console.Write("Numero de filas y de columnas :");
                                                            Console.CursorVisible = true;
                                                            AsignarnFC:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(31, 2);
                                                                nFC = int.Parse(Console.ReadLine());
                                                            }
                                                            catch(Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto AsignarnFC;
                                                            }//tis wea no funca bien, si quiere intenten ustedes...
                                                            //double[,] M = new double[nFC, nFC];
                                                            //double[,] x = new double[nFC, nFC];
                                                            //for (int i = 0; i < nFC; i++)
                                                            //{
                                                            //    for (int j = 0; j < nFC; j++)
                                                            //    {
                                                            //        if (i == 0)
                                                            //        {
                                                            //            x[i, j] = M[i, j];
                                                            //        }
                                                            //        else
                                                            //        {
                                                            //            x[j, i] = 0;
                                                            //        }
                                                            //    }
                                                            //}
                                                            //M = AsignarValorMatriz(nFC, nFC, 4);
                                                            //EscribirValorMatriz(M, nFC, nFC, 1, 4);
                                                            //for (int d = 0; d < nFC - 1; d++)
                                                            //{
                                                            //    for (int i = d; i < nFC; i++)
                                                            //    {
                                                            //        for (int j = d + 1; j < nFC; j++)
                                                            //        {
                                                            //            x[i, j] = Math.Round(-1 * M[d, j] * (M[i, d]));/// M[d, d]));
                                                            //            Console.Clear();
                                                            //            EscribirValorMatriz(x, nFC, nFC, 1, 4);
                                                            //            Console.ReadKey();
                                                            //        }
                                                            //    }
                                                            //    for (int i = d; i < nFC; i++)
                                                            //    {
                                                            //        for (int j = d + 1; j < nFC; j++)
                                                            //        {
                                                            //            M[i, j] += Math.Round(x[i, j]);
                                                            //            Console.Clear();
                                                            //            EscribirValorMatriz(M, nFC, nFC, 1, 4);
                                                            //            Console.ReadKey();
                                                            //        }
                                                            //    }
                                                            //}
                                                            //for (int d = 0; d < nFC; d++)
                                                            //{
                                                            //    R *= M[d, d];
                                                            //}
                                                            //for (int i = 0; i < nFC; i++)
                                                            //{
                                                            //    R *= M[i, 0];
                                                            //}
                                                            //Console.SetCursorPosition(nFC * (TamañoNumero(M, nFC, nFC) + 2), 4 + nFC - 1);
                                                            //Console.Write(">");
                                                            //o = nFC * (TamañoNumero(M, nFC, nFC) + 2) + 4;
                                                            //EscribirValorMatriz(M, nFC, nFC, o, 4);
                                                            //Console.WriteLine();
                                                            //Console.WriteLine("La determinante es :" + R);
                                                            Console.ReadKey();
                                                            goto MenuMaDe;
                                                        }
                                                    case 4:

                                                        goto MenuMa;
                                                    default:
                                                        break;
                                                }
                                            }
                                            break;
                                        case 3://Traspuesta
                                            {
                                                Console.CursorVisible = true;
                                                int ym, xm, ec, em;
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write("Cantidad de filas: ");
                                            AsignarY:
                                                try
                                                {
                                                    Console.SetCursorPosition(19, 0);
                                                    ym = int.Parse(Console.ReadLine());
                                                }
                                                catch (Exception)
                                                {
                                                    Console.SetCursorPosition(0, 12);
                                                    Console.Write("ERROR: Introduce un numero");
                                                    goto AsignarY;
                                                }
                                                Console.Write("Cantidad de Columnas: ");
                                            AsignarX:
                                                try
                                                {
                                                    Console.SetCursorPosition(23, 1);
                                                    xm = int.Parse(Console.ReadLine());
                                                }
                                                catch (Exception)
                                                {
                                                    Console.SetCursorPosition(0, 12);
                                                    Console.Write("ERROR: Introduce un numero");
                                                    goto AsignarX;
                                                }
                                                double[,] Ma1 = new double[xm, ym];
                                                double[,] MaTra = new double[ym, xm];
                                                Ma1 = AsignarValorMatriz(xm, ym, 4);
                                                Console.CursorVisible = false;
                                                for (int i = 0; i < ym; i++)
                                                {
                                                    for (int j = 0; j < xm; j++)
                                                    {
                                                        MaTra[i, j] = Ma1[j, i];
                                                    }
                                                }
                                                ec = 3 + TamañoNumero(Ma1, xm, ym);
                                                EscribirValorMatriz(Ma1, xm, ym, 1, 4);
                                                em = (ec * xm) + 3;
                                                Console.SetCursorPosition((ec * xm) + 1, ym + 3);
                                                Console.WriteLine(">");
                                                EscribirValorMatriz(MaTra, ym, xm, em, 4);
                                                Console.ReadKey();
                                                goto MenuMa;
                                            }
                                        case 4://Adjunta
                                            {
                                                int nFC, TC, EE = 1;
                                                Console.WriteLine("Solo se puede sacar la adjunta de una matriz cuadrada");
                                                Console.WriteLine("Introduce la cantidad de filas y columnas: ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.CursorVisible = true;
                                            AsignarnFC:
                                                try
                                                {
                                                    Console.SetCursorPosition(43, 1);
                                                    nFC = int.Parse(Console.ReadLine());
                                                }
                                                catch (Exception)
                                                {
                                                    Console.SetCursorPosition(0, 12);
                                                    Console.Write("ERROR: Introduce un numero");
                                                    goto AsignarnFC;
                                                }
                                                double[,] MaAd = new double[nFC, nFC];
                                                MaAd = AsignarValorMatriz(nFC, nFC, 4);
                                                TC = 3 + TamañoNumero(MaAd, nFC, nFC);
                                                EscribirValorMatriz(MaAd, nFC, nFC, EE, 4);
                                                MaAd = CofactorMatriz(MaAd, nFC);
                                                Console.SetCursorPosition(EE + (nFC * TC), 4 + (nFC - 1));
                                                Console.Write(">");
                                                EE = (TC * nFC) + 3;
                                                TC = 3 + TamañoNumero(MaAd, nFC, nFC);
                                                EscribirValorMatriz(MaAd, nFC, nFC, EE, 4);
                                                Console.ReadKey();
                                                goto MenuMa;
                                            }
                                        case 5://Inversa
                                            goto MenuMa;
                                        case 6:
                                            goto MenuAlL;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 3:
                                goto MenuPr;
                            default:
                                break;
                        }
                    }
                    break;
                case 2://Quimica
                    {
                    MenuQu:
                        string[] Mn3 = new string[5];
                        Mn3[0] = "Elige la opcion que mas te convenga";
                        Mn3[1] = "Balanceo";
                        Mn3[2] = "Configuracion Electronica";
                        Mn3[3] = "Tabla Periodica";
                        Mn3[4] = "Volver";
                        c = Menu(Mn3, 5);
                        switch (c)
                        {
                            case 1:
                                goto MenuQu;
                            case 2:
                                goto MenuQu;
                            case 3:
                                goto MenuQu;
                            case 4:
                                goto MenuPr;
                            default:
                                break;
                        }
                        break;
                    }
                case 3://Fisica
                    {
                    MenuFi:
                        string[] Mn4 = new string[4];
                        Mn4[0] = "Elige la opcion que mas te convenga";
                        Mn4[1] = "MRU";
                        Mn4[2] = "Conversor";
                        Mn4[3] = "Volver";
                        c = Menu(Mn4, 4);
                        switch (c)
                        {
                            case 1:
                                goto MenuFi;
                            case 2:
                                goto MenuFi;
                            case 3:
                                goto MenuPr;
                        }
                        break;
                    }
                case 4://Salir
                    {
                        string[] Mn5 = new string[3];
                        Mn5[0] = "¿Seguro?";
                        Mn5[1] = "Si";
                        Mn5[2] = "No";
                        c = Menu(Mn5, 3);
                        switch (c)
                        {
                            case 2:
                                goto MenuPr;
                            default:
                                break;
                        }
                        break;
                    }
                default:
                    break;
            }
            Console.Clear();
            Console.WriteLine("Adios");
        }

        static int Menu(string[] mn, int x)
        {
            Console.CursorVisible = false;
            int c = 1;
            System.ConsoleKey T = new System.ConsoleKey();
            do
            {
                Console.Clear();
                for (int i = 0; i < x; i++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(mn[i]);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (i == c)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(">" + mn[i]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" " + mn[i]);
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.Black;
                T = Console.ReadKey().Key;
                switch (T)
                {
                    case ConsoleKey.UpArrow:
                        c--;
                        if (c >= x || c == 0)
                        {
                            c = x - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        c++;
                        if (c >= x || c == 0)
                        {
                            c = 1;
                        }
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        break;
                }
            } while (T != ConsoleKey.Enter);
            Console.ForegroundColor = ConsoleColor.Gray;
            return c;
        }

        static double[,] AsignarValorMatriz(int x, int y, int IM)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int TC = 1;
            double[,] m = new double[x, y];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                MenuFu:
                    try
                    {
                        TC = 2 + TamañoNumero(m, x, y);
                        Console.CursorVisible = true;
                        Console.SetCursorPosition((TC * j) + 1, (i * 2) + IM);
                        m[j, i] = double.Parse(Console.ReadLine());
                        Console.SetCursorPosition(0, 0 + IM);
                        {
                            Console.Write("                                            " +
                                          "                                            " +
                                          "                                            " +
                                          "                                            " +
                                          "                                            " +
                                          "                                            " +
                                          "                                            " +
                                          "                                            " +
                                          "                                            " +
                                          "                                            " +
                                          "                                            " +
                                          "                                            ");
                        }
                    }
                    catch (Exception)
                    {
                        Console.SetCursorPosition((3 * j), (i * 2) + IM);
                        {
                            Console.Write("                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            ");
                        }
                        Console.SetCursorPosition(0, 12);
                        Console.Write("ERROR: Introduce un numero");
                        goto MenuFu;
                    }
                    Console.SetCursorPosition(0, (i * 2) + IM);
                    {
                        Console.Write("                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            ");
                    }
                    TC = 3 + TamañoNumero(m, x, y);
                    EscribirValorMatriz(m, x, y, 1, IM);
                }
            }
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.SetCursorPosition((TC * j), (i * 2) + IM);
                    {
                        Console.Write("                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            ");
                    }
                }
            }
            return m;
        }

        static void EscribirValorMatriz(double[,] m, int x, int y, int z, int IM)
        {
            int c = 2 + TamañoNumero(m, x, y);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j == 0)
                    {
                        Console.SetCursorPosition(((c * j) + z) - 1, (i * 2) + IM);
                        Console.Write("|");
                        if (i + 1 != y)
                        {
                            Console.SetCursorPosition(((c * j) + z) - 1, ((i * 2) + IM) + 1);
                            Console.Write("|");
                        }
                    }
                    if (j + 1 == x)
                    {
                        Console.SetCursorPosition(((c * j) + z + TamañoNumero(m, x, y)) , (i * 2) + IM);
                        Console.Write("|");
                        if (i + 1 != y)
                        {
                            Console.SetCursorPosition(((c * j) + z + TamañoNumero(m, x, y)), ((i * 2) + IM) + 1);
                            Console.Write("|");
                        }
                    }
                    Console.SetCursorPosition((c * j) + z, (i * 2) + IM);
                    if (i + 1 == y)
                    {
                        Console.WriteLine(m[j, i]);
                    }
                    else
                    {
                        Console.Write(m[j, i]);
                    }
                }
            }
        }

        static int TamañoNumero(double[,] m, int x, int y)
        {
            int c = 1;
            string mS1, mS2;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    for (int k = 0; k < y; k++)
                    {
                        for (int l = 0; l < x; l++)
                        {
                            mS1 = m[j, i].ToString();
                            mS2 = m[l, k].ToString();
                            if (mS1.Length > mS2.Length)
                            {
                                c = 1 + mS1.Length;
                            }
                        }
                    }
                }
            }
            return c;
        }

        static double[,] CofactorMatriz(double[,] m, int x1)
        {
            double[,] CoM = new double[x1, x1];
            double[,] R = new double[x1, x1];
            switch (x1)
            {
                case 2:
                    R[1, 1] = m[1, 1];
                    R[0, 0] = m[0, 0];
                    R[1, 0] = m[1, 0] * -1;
                    R[0, 1] = m[0, 1] * -1;
                    break;
                default:
                    double[,] coM = new double[x1 - 1, x1 - 1];
                    int c2 = 0, f2 = 0;
                    for (int fX = 0; fX < x1; fX++)
                    {
                        for (int cX = 0; cX < x1; cX++)
                        {
                            c2 = 0;
                            f2 = 0;
                            for (int f1 = 0; f1 < x1; f1++)
                            {
                                for (int c1 = 0; c1 < x1; c1++)
                                {
                                    if (f1 != fX && c1 != cX)
                                    {
                                        coM[c2, f2] = m[c1, f1];
                                        if (c2 < x1 - 2 && f2 <= x1 - 2)
                                        {
                                            c2++;
                                        }
                                        else
                                        {
                                            c2 = 0;
                                            if (f2 < x1 - 2)
                                            {
                                                f2++;
                                            }
                                            else
                                            {
                                                f2 = 0;
                                                c1 = x1;
                                            }
                                        }
                                    }
                                }
                            }
                            R[cX, fX] = Determinante(coM, x1 - 1);
                        }
                    }
                    break;
            }    
            for (int i = 0; i < x1; i++)
            {
                for (int j = 0; j < x1; j++)
                {
                    R[i, j] = R[j, i];
                }
            }
            return R;
        }

        static double Determinante(double[,] m, int x)
        {
            double De = 1;
            switch (x)
            {
                case 2:
                    De = (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
                    break;
                case 3:
                    De = (m[0, 0] * m[1, 1] * m[2, 2]) + (m[0, 1] * m[1, 2] * m[2, 0]) + (m[0, 2] * m[1, 0] * m[2, 1]) - (m[0, 2] * m[1, 1] * m[2, 0]) - (m[0, 0] * m[1, 2] * m[2, 1]) - (m[0, 1] * m[1, 0] * m[2, 2]);
                    break;
            }
            return De;
        }
    }
}