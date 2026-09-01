/* TimeFutebol time = new TimeFutebol(
    "Sociedade Esportiva Palmeiras",
    "Palmeiras",
    "Porco"
);

Console.WriteLine(time.NomeOficial);
Console.WriteLine(time.NomeConhecido);
Console.WriteLine(time.ApelidoDaTorcida); */

Seriado serie1 = new Seriado(
    "F.R.I.E.N.D.S",
    10,
    12,
    "Sitcom"
);

Console.WriteLine($"Nome: {serie1.Nome}");
Console.WriteLine($"{serie1.Temporadas} temporadas");
Console.WriteLine($"Faixa etária: +{serie1.FaixaEtaria} anos");
Console.WriteLine($"Genero: {serie1.Genero}");

Seriado serie2 = new Seriado(
    "Dexter",
    8,
    16,
    "Crime"
);

Console.WriteLine();

Console.WriteLine($"Nome: {serie2.Nome}");
Console.WriteLine($"{serie2.Temporadas} temporadas");
Console.WriteLine($"Faixa etária: +{serie2.FaixaEtaria} anos");
Console.WriteLine($"Genero: {serie2.Genero}");

Console.WriteLine();

Seriado serie3 = new Seriado(
    "You",
    4,
    18,
    "Suspense"
);

Console.WriteLine($"Nome: {serie3.Nome}");
Console.WriteLine($"{serie3.Temporadas} temporadas");
Console.WriteLine($"Faixa etária: +{serie3.FaixaEtaria} anos");
Console.WriteLine($"Genero: {serie3.Genero}");

Console.WriteLine();

Seriado serie4 = new Seriado(
    "Stanger Things",
    5,
    16,
    "Suspense"
);

Console.WriteLine($"Nome: {serie4.Nome}");
Console.WriteLine($"{serie4.Temporadas} temporadas");
Console.WriteLine($"Faixa etária: +{serie4.FaixaEtaria} anos");
Console.WriteLine($"Genero: {serie4.Genero}");