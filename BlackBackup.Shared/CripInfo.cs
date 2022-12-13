namespace BlackBackup.Shared
{
    public static class CripInfo
    {
        public static string Criptografar(string texto)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            string crip = "";
            try
            {
                int ln = default;
                for (int i = 0; i != texto.Length; i++)
                {
                    ln = Convert.ToInt32(Microsoft.VisualBasic.Strings.Asc(texto.Substring(i, 1))) + 23;
                    crip += Microsoft.VisualBasic.Strings.Chr(ln);
                }
                return $"$#{crip}";
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message} - {ex.Source}");
            }
        }

        public static string Descriptografar(string texto)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            string crip = "";
            if (texto.Substring(0, 2).Equals("$#"))
            {
                texto = texto[2..];
                try
                {
                    int ln = default;
                    for (int i = 0; i != texto.Length; i++)
                    {
                        ln = Convert.ToInt32(Microsoft.VisualBasic.Strings.Asc(texto.Substring(i, 1))) - 23;
                        crip += Microsoft.VisualBasic.Strings.Chr(ln);
                    }
                    return crip;
                }
                catch (Exception ex)
                {
                    throw new Exception($"{ex.Message} - {ex.Source}");
                }
            }
            else
                return crip;
        }
    }
}
