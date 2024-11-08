
using System.Globalization;
using System.Text;

namespace Application.Utilities
{
    public class RetiraAcento
    {
         public static string RetirarAcentuacao(string fullName)
        {
            StringBuilder sbReturn = new StringBuilder();   

            var arrayText = fullName.Normalize(NormalizationForm.FormD).ToCharArray();

           foreach (char letter in arrayText)
           {   
               if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
               sbReturn.Append(letter);   
           }   
            return sbReturn.ToString(); 
        }
    }
}