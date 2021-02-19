using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dniMagician.controller
{
    public class cifClass
    {
        private const int VALUE_TO_DC = 10;
        public cifClass() { }

        public int checkCIF(string output, out model.Company company, out String message)
        {
            try
            {
                if (output.Trim().Length != 9)
                {
                    company = null;
                    message = "El CIF debe tener 9 carácteres";
                    return -1;
                }
                ///

                char[] auxArray = output.ToCharArray(0, output.Length);
                int auxNumProvince = 0;
                int aux = 0;
                company = new model.Company();
                company.letterType = auxArray[0].ToString();
                company.controlDigit = auxArray[auxArray.Length - 1].ToString();
                company.CIF = output;
                if (!Int32.TryParse(auxArray[1].ToString() + "" + auxArray[2].ToString(), out auxNumProvince))
                {
                    message = "Hubo un error al procesar la provincia";
                    return -2;
                }
                company.numProvince = auxNumProvince;
                company.Province = getProvince(auxNumProvince, out aux);
                if (aux == -2)
                {
                    message = "Hubo un error al obtener la Provincia.";
                    company = null;
                    return -3;
                }
                else if (aux == -1)
                {
                    message = "No se encontró el nombre de la provincia.";
                }
                else if (aux < -2)
                {
                    message = "Hubo un error al obtener la provincia.";
                    company = null;
                    return -4;
                }

                company.typeSociety = getTypeSociety(company.letterType, out aux);
                if (aux == -2)
                {
                    message = "Hubo un error al obtener el tipo.";
                    company = null;
                    return -3;
                }
                else if (aux == -1)
                {
                    message = "No se encontró el nombre de el tipo.";
                }
                else if (aux < -2)
                {
                    message = "Hubo un error al obtener el tipo.";
                    company = null;
                    return -4;
                }

                int[] central7 = getCentral7Digit(auxArray);
                if (central7 == null)
                {
                    message = "Hubo un error al procesar el CIF.";
                    company = null;
                    return -5;
                }

                if (processCentral7Digit(central7, company.letterType, company.controlDigit, company.numProvince, out message))
                {
                    company.isValid = true;
                    message = "OK";
                    return 0;
                }
                else
                {
                    company = null;
                    return -6;
                }

            }
            catch (Exception ex)
            {
                company = null;
                message = ex.Message;
                return -1;
            }
        }

        private String getProvince(int code, out int result)
        {
            try
            {
                result = 0;
                switch (code)
                {
                    case 00: return "No Residente";
                    case 01:
                        return "Álava";
                    case 02:
                        return "Albacete";
                    case 03:
                    case 53:
                    case 54:
                        return "Alicante";
                    case 04:
                        return "Almería";
                    case 05:
                        return "Ávila";
                    case 06:
                        return "Badajoz";
                    case 07:
                    case 57:
                        //   case 16  :
                        return "Islas Baleares";
                    case 08:
                    case 58:
                    case 59:
                    case 60:
                    case 61:
                    case 62:
                    case 63:
                    case 64:
                    case 65:
                    case 66:
                    case 68:
                        return "Barcelona";
                    case 09:
                        return "Burgos";
                    case 10:
                        return "Cáceres";
                    case 11:
                    case 72:
                        return " Cádiz";
                    case 12:
                        return "Castellón";
                    case 13:
                        return "Ciudad Real";
                    case 14:
                    case 56:
                        return "Córdoba";
                    case 16:
                        return "Cuenca";
                    case 17:
                    case 55:
                    case 67:
                        return "Gerona";
                    case 18:
                        //          case  19 :
                        return "Granada";
                    case 19:
                        return "Guadalajara";
                    case 20:
                    case 71:
                        return "Guipúzcoa";
                    case 21:
                        return " Huelva";
                    case 22:
                        return "Huesca";
                    case 23:
                        return "Jaén";
                    case 24:
                        return "León";
                    case 25:
                        return " Lérida";
                    case 26:
                        return " La Rioja";
                    case 27:
                        return "Lugo";
                    case 28:
                    case 78:
                    case 79:
                    case 80:
                    case 81:
                    case 82:
                    case 83:
                    case 84:
                    case 85:
                    case 86:
                    case 87:
                    case 88:
                        return "Madrid";
                    case 29:
                    case 92:
                    case 93:
                        return "Málaga";
                    case 30:
                    case 73:
                        return "Murcia";
                    case 31:
                        //   case 71:
                        return "Navarra";
                    case 32:
                        return "Orense";
                    case 33:
                    case 74:
                        return "Asturias";
                    case 34:
                        return "Palencia";
                    case 35:
                    case 75:
                        return "Las Palmas";
                    case 36:
                    //      case  37:
                    case 94:
                        return "Pontevedra";
                    case 37:
                        return "Salamanca";
                    case 38:
                    case 76:
                        return "Santa Cruz de Tenerife";
                    case 39:
                        return "Cantabria";
                    case 40:
                        return "Segovia";
                    case 41:
                    case 90:
                    case 91:
                        return "Sevilla";
                    case 42:
                        return "Soria";
                    case 43:
                    case 77:
                        return "Tarragona";
                    case 44:
                        return "Teruel";
                    case 45:
                        return "Toledo";
                    case 46:
                    case 96:
                    case 97:
                    case 98:
                        return "Valencia";
                    case 47:
                        return "Valladolid";
                    case 48:
                    case 95:
                        return "Vizcaya";
                    case 49:
                        return "Zamora";
                    case 50:
                    case 99:
                        return "Zaragoza";
                    case 51:
                        return "Ceuta";
                    case 52:
                        return "Melilla";
                    default:
                        result = -1;
                        return "Code: " + code;
                }

            }
            catch (Exception ex)
            {
                result = -2;
                return "Hubo un error al obtener la provincia: " + ex.Message;

            }
        }

        private string getTypeSociety(string code, out int result)
        {
            try
            {
                result = 0;
                switch (code)
                {
                    case "A":
                        return "Sociedad anónima";
                    case "B":
                        return "Sociedad de responsabilidad limitada";
                    case "C":
                        return "Sociedad colectiva";
                    case "D":
                        return "Sociedad comanditarias";
                    case "E":
                        return "Comunidad de bienes";
                    case "F":
                        return "Sociedad cooperativa";
                    case "G":
                        return "Asociaciones y fundaciones";
                    case "H":
                        return "Comunidad de propietarios en régimen de propiedad horizontal";
                    case "J":
                        return "Sociedad Civil";
                    case "N":
                        return "Entidad no residente";
                    case "P":
                        return "Corporación local";
                    case "Q":
                        return "Organismos autónomos, estatales o no, y asimilados, y congregaciones e instituciones religiosas";
                    case "R":
                        return "Congregaciones e instituciones religiosas(desde 2008)";
                    case "S":
                        return "Órganos de la Administración del Estado y cominidades autónomas";
                    case "U":
                        return "Uniones Temporales de Empresas";
                    case "V":
                        return "Sociedad Agraria de Transformación";
                    case "W":
                        return "Establecimiento permanentes de entidades no residente en España";
                    default:
                        result = -1;
                        return String.Empty;
                }
            }
            catch (Exception ex)
            {
                result = -2;
                return "Hubo un error al obtener la tipologia de sociedad: " + ex.Message;

            }
        }

        private int[] getCentral7Digit(char[] output)
        {
            try
            {
                if (output.Length != 9)
                {
                    return null;
                }

                int[] auxOutPut = new int[output.Length - 2];
                for (int i = 1; i < output.Length - 1; i++)
                {
                    int aux = -1;
                    if (!Int32.TryParse(output[i].ToString(), out aux)) return null;
                    auxOutPut[i - 1] = aux;
                }

                return auxOutPut;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        private Boolean processCentral7Digit(int[] central7, String type, String controlDigit, int numProvince, out String message)
        {
            try
            {
                message = "Hubo un error al procesar el CIF";
                if (central7.Length != 7) return false;
                int calculated = -1;
                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;


                for (int i = 0; i < central7.Length; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {//Digitos pares
                        a += central7[i];
                    }
                    else
                    { //Digitos impares
                        int auxOdd = getOddNumberResult(central7[i]);
                        if (auxOdd == -6) return false;
                        b += auxOdd;
                    }
                }

                //Sumar dígitos pares e impares
                c = a + b;
                String cAux = c.ToString("D2");
                char[] auxDArray = cAux.ToCharArray();
                String auxD = auxDArray[auxDArray.Length - 1].ToString();
                if (!Int32.TryParse(auxD, out d)) return false;
                if (d != 0)
                {
                    d = VALUE_TO_DC - d;
                }
                calculated = d;
                message = String.Empty;
                return checkDigitControl(controlDigit, calculated, type,  numProvince, out message);

            }
            catch (Exception ex)
            {
                message = "Hubo un error al procesar el CIF";
                return false;
            }
        }

        private Boolean checkDigitControl(String dcGiven, int dcCalculated, String type, int numProvince, out String message)
        {
            try
            {
                message = "CIF incorrecto";
                int typeDC = typeSocietyDC_SHOW(type, numProvince);
                if (typeDC == 1)
                {
                    int aux = 0;
                    if (!Int32.TryParse(dcGiven, out aux)) return false;
                    if (aux != dcCalculated) return false;
                }
                else if (typeDC == 0)
                {
                    String auxCalculated_str = letter_to_dcCalculated(dcCalculated);
                    if (auxCalculated_str != dcGiven) return false;
                }
                else if ((typeDC == 2))
                {
                    int aux = 0;
                    if (!Int32.TryParse(dcGiven, out aux))
                    {
                        String auxCalculated_str = letter_to_dcCalculated(dcCalculated);
                        if (auxCalculated_str != dcGiven) return false;
                    }
                    else
                    {
                        if (aux != dcCalculated) return false;
                    }
                }
                else
                {
                    return false;
                }
                message = String.Empty;
                return true;
            }
            catch (Exception ex)
            {
                message = "Hubo un error al procesar el CIF";
                return false;
            }
        }

        private int getOddNumberResult(int odd)
        {
            try
            {
                int aux = odd * 2;
                string auxStr = aux.ToString("D2");
                char[] auxChar = auxStr.ToCharArray();
                int result = 0;

                for (int i = 0; i < auxChar.Length; i++)
                {
                    int auxResult = -1;
                    if (!Int32.TryParse(auxChar[i].ToString(), out auxResult)) return -6;
                    result += auxResult;
                }

                return result;
            }
            catch (Exception ex)
            {
                return -6;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns>0 - Letra, 1 - Numero, 2 - Pueden ser ambas</returns>
        private int typeSocietyDC_SHOW(string type, int numProvince)
        {
            try
            {
                switch (type)
                {
                    case "P":
                    case "Q":
                    case "R":
                    case "S":
                    case "W":
                        return 0;
                    case "A":
                    case "B":
                    case "E":
                    case "H":
                        return 1;
                    default:
                        if (numProvince == 0)
                        {
                            return 0;
                        }
                        return 2;
                }
            }
            catch (Exception ex)
            {
                return -6;
            }
        }

        private String letter_to_dcCalculated(int calculated)
        {
            try
            {
                switch (calculated)
                {
                    case 0:
                        return "J";
                    case 1:
                        return "A";
                    case 2:
                        return "B";
                    case 3:
                        return "C";
                    case 4:
                        return "D";
                    case 5:
                        return "E";
                    case 6:
                        return "F";
                    case 7:
                        return "G";
                    case 8:
                        return "H";
                    case 9:
                        return "I";
                    default:
                        return String.Empty;
                }

            }
            catch (Exception ex)
            {
                return String.Empty;
            }
        }
    }//
}
