public class CpfService
{
    public CpfService(int seed)
    {
        this.rand = new Random(seed);
    }
    Random rand;

    public bool Validate(string cpf)
    {
        throw new NotImplementedException();
    }

    public string Generate()
    {
        throw new NotImplementedException();
    }

    // detalhes em: https://www.calculadorafacil.com.br/computacao/validar-cpf
    public string getValidationDigits(string cpf9digits)
    {
        int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        string cpf;
        string digito;
        int soma;
        int resto;

        cpf = cpf9digits.Substring(0, 9);
        cpf9digits = cpf9digits.Replace(".", "").Replace("-", "");

        if(cpf9digits.Length != 11)
        {
            return false;
        }
        cpf9digits = cpf9digits.Trim();
        soma = 0;

        for(int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf.ToString())*multiplicador1[i];
            resto = soma % 11 ;
            
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto ;
            }
                digito = resto.ToString();
                cpf = cpf + digito;
                soma = 0;
        }
        for(int i = 0; i < 10;i++)
        {
            soma += int.Parse(cpf.ToString())*multiplicador2[i];
            resto = soma % 11;
            if(resto > 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto ;
            }      
        }
        digito = digito + resto.ToString();

        return cpf.EndsWith(digito);    
    }
}