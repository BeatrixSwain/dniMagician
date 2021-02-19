using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dniMagician.controller
{
    public class dniClass
    {
        public dniClass() { }

        public int getLetter(String input, out String result)
        {
            try
            {
                String auxResult = dniExtranjero(input);
                result = auxResult;

                if (auxResult.Trim().Length > 0)
                {

                    return 0;
                }
                else {
                    result = "El número insertado no es válido";
                    return -2;
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return -1;

            }
        }

        private String dniExtranjero(String dni)
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


    }//
}
