//var builder = WebApplication.CreateBuilder(args);
var builder = WebApplication.CreateBuilder(args).Inject();

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers().AddInjectWithUnifyResult();

var app = builder.Build();

// Configure the HTTP request pipeline.
//
app.UseHttpsRedirection();

app.UseAuthorization();

app.UseInject(string.Empty);

app.MapControllers();

app.Run();
