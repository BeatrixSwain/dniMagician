using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dniMagician.controller
{
    public class cifClass
    {
        public cifClass() { }



        private String getProvince(int code)
        {
            try
            {
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
                    case 15: case 70: return "La Coruña";
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
                        return "Code: " + code;
                }

            }
            catch (Exception ex)
            {
                return "Hubo un error al obtener la provincia: " + ex.Message;

            }
        }

        private string typeSociety(string code)
        {
            try
            {
                switch (code) {
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
                        return String.Empty;
                }
            }
            catch (Exception ex)
            {
                return "Hubo un error al obtener la tipologia de sociedad: " + ex.Message;

            }
        }
    }//
}
