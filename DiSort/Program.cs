namespace DiSort;
class Program
{
    static void Main(string[] args)
    {
        //Também em outras linguagens é conhecido como Map
        Dictionary<string, string> cookies = new Dictionary<string, string>();

        //Os comentários separados são validos no geral, separei para não ficar verboso

        //dictionary[key] - Acessa o elemento pela chave informada
        cookies["user"] = "Maria";
        //Add(key, value) - Adiciona elemento[Exceto em caso de repetição]
        cookies["email"] = "mar@gmail.com";
        cookies["phone"] = "46454465465";//Vai ser sobrescrito
        cookies["phone"] = "7879898989";

        System.Console.WriteLine(cookies["phone"]);
        System.Console.WriteLine(cookies["email"]);

        //Remove um elemento pela chave
        cookies.Remove("email");

        //Verifica se a dada chave existe
        if (cookies.ContainsKey("email"))
        {
            System.Console.WriteLine(cookies["email"]);
        }
        else
        {
            System.Console.WriteLine("There is no 'email' key");
        }
        //                                 Quantidade de elementos
        System.Console.WriteLine("Size:" + cookies.Count);

        System.Console.WriteLine("All cookies");
        //var tbm funciona no lugar do KeyValuePair<string, string>
        foreach (KeyValuePair<string, string> item in cookies)
        {
            System.Console.WriteLine(item.Key + ":" + item.Value);
        }

        //Clear() esvazia a coleção
        //ContainsValue(value) verifica se o dado valor existe
    }
}
