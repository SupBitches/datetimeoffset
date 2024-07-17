DateTimeOffset dto;
DateTime dt;

dto = new DateTimeOffset(2024,1,1,12,00,00,00, TimeSpan.FromHours(5)) ;
dt = dto.UtcDateTime;
dto = (DateTimeOffset)dt;


Console.WriteLine($"DateTimeOffset: {dto}");
Console.WriteLine($"DateTime: {dt}");

Console.ReadLine();
