using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RealWorld.Api;
using RealWorld.Api.Data;
using RealWorld.Api.Middlewares;
using RealWorld.Api.Repositories;
using RealWorld.Api.Services;
using RealWorld.Api.Services.Abstraction;

var builder = WebApplication.CreateBuilder(args);

var authOptions = new AuthOptions();
builder.Configuration.GetSection(AuthOptions.Auth).Bind(authOptions);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(authOptions.JwtKey)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});


builder.Services.AddControllers().ConfigureApiBehaviorOptions(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddDbContext<RealWorldDataContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("RealWorld"))
);
builder.Services.AddSingleton<AuthOptions>(authOptions);
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IArticleRepository, ArticleRepository>();
builder.Services.AddTransient<ICommentRepository, CommentRepository>();
builder.Services.AddTransient<ITagRepository, TagRepository>();
builder.Services.AddTransient<IArticleService, ArticleService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<TokenService>();

var app = builder.Build();
app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();
app.Run();
