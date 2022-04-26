using ListaIndirizzi;

List<Indirizzi> listaDiIndirizzi = new List<Indirizzi>();

string path = "C:\\Utenti\\Ersi\\Desktop\\esercitazioni-NET\\addresses.csv";
StreamReader file = File.OpenText(path);
while (!file.EndOfStream)
{
    string riga = file.ReadLine();
    string[] arrayDiInformazioni = riga.Split(",");
    string nome = arrayDiInformazioni[0];
    string cognome = arrayDiInformazioni[1];
    string via = arrayDiInformazioni[2];
    string città = arrayDiInformazioni[3];
    string provincia = arrayDiInformazioni[4];
    int codicePostale = int.Parse(arrayDiInformazioni[5]);

}