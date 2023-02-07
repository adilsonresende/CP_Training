using System;
using System.Text;

namespace CP_Training.Business
{
    public class CamelCase
    {
        public string Solution(string line)
        {
            //string line = string.Empty;
            //while (Console.ReadLine() != null)
            //{
            string[] separateValues = line.Split(';');
            string operationType = separateValues[0];
            string textModifier = separateValues[1];
            string imput = separateValues[2].Trim();
            string result = string.Empty;

            if (operationType == "S")
            {
                result = Split(imput, textModifier);
            }
            else if (operationType == "C")
            {
                result = Combine(imput, textModifier);
            }

            return result;

            //Console.WriteLine(result);
            //}
        }

        static string Split(string imput, string operation)
        {
            StringBuilder result = new StringBuilder();
            if (operation == "M")
            {
                for (int i = 0; i < imput.Length; i++)
                {
                    if (char.IsUpper(imput[i]))
                    {
                        result.Append(" ");
                        result.Append(char.ToLower(imput[i]));
                        continue;
                    }

                    if (imput[i] == '(' || imput[i] == ')')
                    {
                        continue;
                    }

                    result.Append(imput[i]);
                }
            }
            else if (operation == "V")
            {
                for (int i = 0; i < imput.Length; i++)
                {
                    if (char.IsUpper(imput[i]))
                    {
                        result.Append(" ");
                        result.Append(char.ToLower(imput[i]));
                        continue;
                    }

                    result.Append(imput[i]);
                }
            }
            else if (operation == "C")
            {
                for (int i = 0; i < imput.Length; i++)
                {
                    if (char.IsUpper(imput[i]))
                    {
                        if (i > 0)
                        {
                            result.Append(" ");
                        }

                        result.Append(char.ToLower(imput[i]));
                        continue;
                    }

                    result.Append(imput[i]);
                }
            }
            return result.ToString();
        }

        static string Combine(string imput, string operation)
        {
            StringBuilder result = new StringBuilder();
            bool skipNextChar = false;
            bool nextCharShouldBeUpperCase = false;

            if (operation == "M")
            {
                for (int i = 0; i < imput.Length; i++)
                {
                    if (char.IsWhiteSpace(imput[i]))
                    {
                        nextCharShouldBeUpperCase = true;
                        continue;
                    }

                    if (nextCharShouldBeUpperCase)
                    {
                        result.Append(char.ToUpper(imput[i]));
                        nextCharShouldBeUpperCase = false;
                        continue;
                    }

                    result.Append(imput[i]);
                }

                result.Append("()");
            }
            else if (operation == "V")
            {
                for (int i = 0; i < imput.Length; i++)
                {
                    if (char.IsWhiteSpace(imput[i]) && !skipNextChar)
                    {
                        nextCharShouldBeUpperCase = true;
                        continue;
                    }

                    if (nextCharShouldBeUpperCase)
                    {
                        result.Append(char.ToUpper(imput[i]));
                        nextCharShouldBeUpperCase = false;
                        continue;
                    }

                    result.Append(imput[i]);
                }
            }
            else if (operation == "C")
            {
                for (int i = 0; i < imput.Length; i++)
                {
                    if(i == 0)
                    {
                        result.Append(char.ToUpper(imput[i]));
                        continue;
                    }

                    if (char.IsWhiteSpace(imput[i]) && !skipNextChar)
                    {
                        nextCharShouldBeUpperCase = true;
                        continue;
                    }

                    if (nextCharShouldBeUpperCase)
                    {
                        result.Append(char.ToUpper(imput[i]));
                        nextCharShouldBeUpperCase = false;
                        continue;
                    }

                    result.Append(imput[i]);
                }
            }

            return result.ToString();
        }
    }
}