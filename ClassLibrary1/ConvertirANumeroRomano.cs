using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class ConvertirANumeroRomano
    {
        private enum SimboloRomano
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500, 
            M = 1000
        }
        public string PasarANumueroRomano(int numero)
        {
            String retornar = "";
            if (numero < 1 || numero > 3999)
            {
                throw new IndexOutOfRangeException("El numero tiene debe estar entre [1;3000]");
            }
            else
            {
                if (Enum.IsDefined(typeof(SimboloRomano), numero))
                {
                    retornar = ((SimboloRomano)numero).ToString();
                }
                else
                {

                    while (numero != 0)
                    {
                        if (numero - (int)SimboloRomano.M >= 0)
                        {
                            numero -= (int)SimboloRomano.M;
                            retornar += ((SimboloRomano)(int)SimboloRomano.M).ToString();
                        } 
                        else if (numero - (int)SimboloRomano.D >= 0)
                        {
                            if (numero >= 900)
                            {
                                numero += 100;
                                retornar += "C";
                            }
                            else
                            {
                                numero -= (int)SimboloRomano.D;
                                retornar += ((SimboloRomano)(int)SimboloRomano.D).ToString();
                            }
                        }
                        else if (numero - (int)SimboloRomano.C >= 0)
                        {
                            if (numero >= 400)
                            {
                                numero += 100;
                                retornar += "C";
                            }
                            else
                            {
                                numero -= (int)SimboloRomano.C;
                                retornar += ((SimboloRomano)(int)SimboloRomano.C).ToString();
                            }
                        }
                        else if (numero - (int)SimboloRomano.L >= 0)
                        {
                            if (numero >= 90)
                            {
                                numero += 10;
                                retornar += "X";
                            }
                            else
                            {
                                numero -= (int)SimboloRomano.L;
                                retornar += ((SimboloRomano)(int)SimboloRomano.L).ToString();
                            }
                        }
                        else if (numero - (int)SimboloRomano.X >= 0)
                        {
                            if (numero >= 40)
                            {
                                numero += 10;
                                retornar += "X";
                            }
                            else
                            {
                                numero -= (int)SimboloRomano.X;
                                retornar += ((SimboloRomano)(int)SimboloRomano.X).ToString();                 
                            }
                        }
                        else if (numero - (int)SimboloRomano.V >= 0)
                        {
                            if (numero >= 9)
                            {
                                numero += 1;
                                retornar += "I";
                            }
                            else
                            {
                                numero -= (int)SimboloRomano.V;
                                retornar += ((SimboloRomano)(int)SimboloRomano.V).ToString();
                            }
                            
                        }
                        else if (numero - (int)SimboloRomano.I >= 0)
                        {
                            if (numero >= 4)
                            {
                                numero += 1;
                                retornar += "I";
                            }
                            else
                            {
                                numero -= (int)SimboloRomano.I;
                                retornar += ((SimboloRomano)(int)SimboloRomano.I).ToString();
                            }
                        }
                    }
                    

                              
                }
                
            }

            return retornar;
        }
    }
}
