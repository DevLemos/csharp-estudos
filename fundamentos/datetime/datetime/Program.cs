using System.Globalization;

//Trabalhando com DateOnly
DateOnly dia = new DateOnly(2025,10,25);

string dataTexto01 = dia.ToShortDateString(); //Converte para cadeia de caracteres de data abreviada 
string dataTexto02 = dia.ToLongDateString(); //Converte para cadeia de caracteres de data completa
string dataTexto03 = dia.ToString("dd/MMMM/yyyy",new CultureInfo("en-US")); //Converte para cadeia de caracteres usando as convenções de formatação da cultura atual
DateOnly dateHojeOnly = DateOnly.FromDateTime(DateTime.Now); //	Retorna uma DateOnly a partir de um DateTime

Console.WriteLine(dia);
Console.WriteLine(dataTexto01);
Console.WriteLine(dataTexto02);
Console.WriteLine(dataTexto03);
Console.WriteLine(dateHojeOnly);

//Acessando propriedades
Console.WriteLine(dateHojeOnly.Year); //ano
Console.WriteLine(dateHojeOnly.Month); //mês
Console.WriteLine(dateHojeOnly.Day); //dia
Console.WriteLine(dateHojeOnly.DayOfWeek); //dia da semana

//Operações com datas
Console.WriteLine(dateHojeOnly.AddDays(1));
Console.WriteLine(dateHojeOnly.AddMonths(1));
Console.WriteLine(dateHojeOnly.AddYears(-1));

DateTime horaComMinutos = dateHojeOnly.ToDateTime(TimeOnly.MinValue); //Convertendo DateOnly para DateTime
Console.WriteLine(horaComMinutos);


//Trabalhando com DateTime
DateTime dia2 = new DateTime(2025,10,25); //Data com horas, minutos e segundos (25/10/2025 00:00:00)
DateTime dia3 = new DateTime(2025, 10, 25, 20, 16, 03); //Data com horas, minutos e segundos (25/10/2025 20:16:03)
DateTime hoje = DateTime.Now; //Data de hoje e horário atual
DateTime dia4 = DateTime.Today; //Apenas Data de hoje e horário default sem precisar instanciar new DateTime( )
DateTime diaUTC = DateTime.UtcNow; //Data de hoje e horário atual

Console.WriteLine(dia2);
Console.WriteLine(dia3);
Console.WriteLine(hoje);
Console.WriteLine(dia4);
Console.WriteLine(diaUTC);

//Trabalhando com TimeOnly
TimeOnly timeOnly = new TimeOnly(20,34); //Usado para representar apenas horários
Console.WriteLine(timeOnly);