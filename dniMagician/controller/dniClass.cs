using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//http://www.interior.gob.es/web/servicios-al-ciudadano/dni/calculo-del-digito-de-control-del-nif-nie
namespace dniMagician.controller
{
    public class dniClass
    {
        private const int MAGICNUMBER = 23;
        public dniClass() { }

        public int processDNI(String input, out String result)
        {
            try
            {
                if (input.Trim().Length != 8) {
                    result = "El número de valores insertado es incorrecto";
                    return -1;
                }
                String auxResult = foreignDNI(input);
                result = auxResult;

                if (auxResult.Trim().Length > 0)
                {
                    int auxParse = 0;

                    if (Int32.TryParse(auxResult, out auxParse))
                    {
                        int remainder = auxParse % MAGICNUMBER;
                        result = remainder + auxResult;
                        String letter = getLetter(remainder);
                        if (letter.Trim().Length > 0)
                        {
                            result = input + letter;
                            return 0;
                        }
                        else
                        {
                            result = "Error al obtener la letra de " + input + ", r=" + remainder;
                            return -2;
                        }
                    }
                    else
                    {
                        result = "El número insertado no es válido";
                        return -3;
                    }
                }
                else
                {
                    result = "El número insertado no es válido";
                    return -4;
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return -5;

            }
        }

        private String foreignDNI(String dni)
        {
            try
            {
                int r = 0;
                if (Int32.TryParse(dni, out r))
                {
                    return dni;
                }
                else
                {
                    String firstValue = dni.Substring(0, 1);
                    int valorNuevo = -1;
                    switch (firstValue)
                    {
                        case "X":
                            valorNuevo = 0;
                            break;
                        case "Y":
                            valorNuevo = 1;
                            break;
                        case "Z":
                            valorNuevo = 2;
                            break;
                        default:
                            return String.Empty;
                    }

                    return valorNuevo + dni.Substring(1);
                }


            }
            catch (Exception ex)
            {
                return String.Empty;

            }
        }

        private String getLetter(int remainder)
        {
            try
            {
                switch (remainder)
                {
                    case 0:
                        return "T";
                    case 1:
                        return "R";
                    case 2:
                        return "W";
                    case 3:
                        return "A";
                    case 4:
                        return "G";
                    case 5:
                        return "M";
                    case 6:
                        return "Y";
                    case 7:
                        return "F";
                    case 8:
                        return "P";
                    case 9:
                        return "D";
                    case 10:
                        return "X";
                    case 11:
                        return "B";
                    case 12:
                        return "N";
                    case 13:
                        return "J";
                    case 14:
                        return "Z";
                    case 15:
                        return "S";
                    case 16:
                        return "Q";
                    case 17:
                        return "V";
                    case 18:
                        return "H";
                    case 19:
                        return "L";
                    case 20:
                        return "C";
                    case 21:
                        return "K";
                    case 22:
                        return "E";
                    default:
                        return "";
                }

            }
            catch (Exception ex)
            {
                return String.Empty;

            }
        }
    }//
}
