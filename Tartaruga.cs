Console.WriteLine($@"(FGV/TCE-SE) Duas tartarugas estavam juntas e começaram a caminhar em linha reta em direção a um lago distante. A primeira tartaruga percorreu 30 metros por dia e demorou 16 dias para chegar ao lago. A segunda tartaruga só conseguiu percorrer 20 metros por dia e, portanto, chegou ao lago alguns dias depois da primeira. Quando a primeira tartaruga chegou ao lago, o número de dias que ela teve que esperar para a segunda tartaruga chegar foi:");
int Tartaruga1 = 30 * 16; // Distância percorrida pela primeira tartaruga
int Tartaruga2 = 20 * 16; // Distância percorrida pela segunda tartaruga
int Espera = (Tartaruga1 - Tartaruga2) / 20; // Número de dias que a primeira tartaruga teve que esperar
Console.WriteLine("");
Console.WriteLine("Resposta:");
Console.WriteLine($"A primeira tartaruga teve que esperar {Espera} dias para a segunda tartaruga chegar ao lago.");