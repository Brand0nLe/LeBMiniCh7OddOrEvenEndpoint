//Brandon Le
//10-26-22
//Mini Challenge 7 - Odd or Even Endpoint
//Web API project that will tell the user whether the number they entered via the URL is odd or even. There is an instructions page when the user starts at the localhost url /MiniCh7 and will help them to continue with the program. There is also an error message if the user enters in anything that is not a number.
//Peer Review: Jovann Contreras: Code looks great and is very understandable it runs good on postman. One thing that I liked was that it saved the url input in postman so it made it easier to be able to add in a number quick.



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
