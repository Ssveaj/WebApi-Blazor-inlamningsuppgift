# WebApi-Blazor-inlamningsuppgift


Du ska i denna inlämningsuppgift bygga ett enkelt ärendehanteringssystem. Om du är osäker på vad ett ärendehanteringssystem är ber vi dig kolla in https://www.youtube.com/results?search_query=%C3%A4rendehanteringssystem för där visas en rad olika exempel på ärendehanteringssystem.

 

För godkänt krävs det att du gör följande:

Du ska bygga ett grafiskt gränssnitt med Blazor/MVC där du kan skapa ett ärende som tar emot följande information: Kundens namn, Tidpunkt för ärendet, Titel på ärendet, En beskrivning av ärendet, En status (Ej påbörjad, Påbörjad, Avslutad).
Du ska skapa ett grafiskt gränssnitt med Blazor/MVC där du kan lista upp alla ärenden och se all information om ett ärende.
Du ska bygga ett grafiskt gränssnitt med Blazor/MVC där du kan skapa en kund och lista upp alla kunder i en lista.
Du måste minst ha 2 controllers i ditt WebAPI en för kunder och en för ärenden (CustomerController, CaseController)
Du måste ha CRUD för minst 2 controllers (dvs. CustomerController och CaseController)
Du måste kunna spara informationen i en databas med hjälp av Entity Framework

För väl godkänt krävs det att du även har följande:

Inloggning mot WebApi med JWT-tokens för handläggaren
Ett grafiskt gränssnitt i Blazor/MVC för registring och inloggning av en handläggare kopplat på WebApiet en kund ska alltså inte logga in utan det är bara en handläggare som ska logga in. (använd gärna LocalStorage för Blazor).
VG delen ska göras självständigt, vilket innebär att du själv ska klara av att göra detta med minimal handledning av utbildaren. 
Denna inlämningsuppgift ska senast vara inlämnad den 29:e mars. Du ska skicka in din uppgift här på pingpong i zippat format. Om det är så att du inte kan skicka in din uppgift då filstorleken är för stor. Ska du  lägga upp ditt arbete på GitHub och sedan skicka din länk till din github repository som kommentar vid inlämningen.

 

Här har du länkar som hjälper dig göra ALLT i uppgiften. Så om du kollar dessa kommer du klara både G och VG delen:

https://stackoverflow.com/questions/58485439/select-box-binding-in-blazor (för att populera en select-box)

https://wellsb.com/csharp/aspnet/blazor-write-to-localstorage/ (fför att spara tokens i en localstorage)

https://stackoverflow.com/questions/14627399/setting-authorization-header-of-httpclient (authentisera med din token för ditt webapi)
http.DefaultRequestHeaders.Add("Authorization", "Bearer " + dintokensomdufårfråndittapi);

 

https://docs.microsoft.com/en-us/aspnet/core/security/blazor/?view=aspnetcore-3.1&tabs=visual-studio

https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-3.1

https://stackoverflow.com/questions/58485439/select-box-binding-in-blazor

https://www.youtube.com/watch?v=RHqWGivRZgQ

https://www.youtube.com/watch?v=xr56fmgLl74&list=PL4WEkbdagHIR0RBe_P4bai64UDqZEbQap&index=1

https://www.youtube.com/watch?v=40njRXr6eUo&list=PL4WEkbdagHIR0RBe_P4bai64UDqZEbQap&index=5

https://www.youtube.com/watch?v=PeQ2ipkdEhI&list=PL4WEkbdagHIR0RBe_P4bai64UDqZEbQap&index=6

https://www.youtube.com/watch?v=VM4i-_YnGMo&list=PL4WEkbdagHIR0RBe_P4bai64UDqZEbQap&index=8

https://www.youtube.com/watch?v=StjyKhy9e7M&list=PL4WEkbdagHIR0RBe_P4bai64UDqZEbQap&index=11

https://www.youtube.com/watch?v=BmAnSNfFGsc&list=PL4WEkbdagHIR0RBe_P4bai64UDqZEbQap&index=12

https://www.youtube.com/watch?v=PgDEpkWbsew&list=PL4WEkbdagHIR0RBe_P4bai64UDqZEbQap&index=13

https://www.youtube.com/watch?v=X6cBnOhaYhk&list=PL4WEkbdagHIR0RBe_P4bai64UDqZEbQap&index=14

https://www.youtube.com/watch?v=0pcM6teVdKk&list=PL6n9fhu94yhW7yoUOGNOfHurUE6bpOO2b

https://www.youtube.com/watch?v=GbKBcDX8DDQ&list=PL6n9fhu94yhW7yoUOGNOfHurUE6bpOO2b&index=3

https://www.youtube.com/watch?v=gkWb7yQb6ro&list=PL6n9fhu94yhW7yoUOGNOfHurUE6bpOO2b&index=20

https://www.youtube.com/watch?v=6Rrnt3AKs2g&list=PL6n9fhu94yhW7yoUOGNOfHurUE6bpOO2b&index=21

https://www.youtube.com/watch?v=pq3-3ZmaMcI&list=PL6n9fhu94yhW7yoUOGNOfHurUE6bpOO2b&index=24

https://www.youtube.com/watch?v=sdlt3-ptt9g&list=PLUOequmGnXxOgmSDWU7Tl6iQTsOtyjtwU

https://www.youtube.com/watch?v=qEmxoCOH4Uw&list=PLUOequmGnXxOgmSDWU7Tl6iQTsOtyjtwU&index=8

https://www.youtube.com/watch?v=M6AkbBaDGJE&list=PLUOequmGnXxOgmSDWU7Tl6iQTsOtyjtwU&index=10

https://www.youtube.com/watch?v=ARvsBUBioT0&list=PLUOequmGnXxOgmSDWU7Tl6iQTsOtyjtwU&index=11

https://www.youtube.com/watch?v=APLjIrZgxyo&list=PLUOequmGnXxOgmSDWU7Tl6iQTsOtyjtwU&index=12

https://www.youtube.com/watch?v=o8dwfI7X16E&list=PLUOequmGnXxOgmSDWU7Tl6iQTsOtyjtwU&index=13

https://www.youtube.com/watch?v=vEU9SDmIvVY
