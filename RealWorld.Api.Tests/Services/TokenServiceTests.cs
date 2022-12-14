using System.Text;
using FluentAssertions;
using RealWorld.Api.Models;
using RealWorld.Api.Services;

namespace RealWorld.Api.Tests.Services;

public class TokenServiceTests
{
    private readonly TokenService _tokenService;

    public TokenServiceTests()
    {
        var options = new AuthOptions { JwtKey = "MWRmOGMyZTctNGJhNy00OTlkLTk4YzAtMjIwNjE5MDI0NTRhNjJkOGNiZGUtM2EzYS00YWZkLWEzOTEtNTY2MjViMjg0MDU2" };
        _tokenService = new TokenService(options);
    }

    [Fact]
    public void GenerateToken_ShouldReturnAJwtToken_WhenModelIsValid()
    {
        var userModel = PopulateUserModel();

        var token = _tokenService.GenerateToken(userModel);

        token.Should().NotBeNull();
        
        var tokenSplitted = token.Split('.');
        tokenSplitted.Length.Should().Be(3);
    }

    private UserModel PopulateUserModel() => new UserModel
    {
        Id = 1,
        Image = "/some/image.png",
        PasswordHash = "HaShPaSsWoRd",
        Username = "some username",
        Bio = "Some bio",
        Email = "fake@fake.com",
        Articles = new List<ArticleModel>(),
        Comments = new List<CommentModel>(),
        Favorites = new List<ArticleModel>(),
        Followers = new List<UserModel>(),
        Following = new List<UserModel>(),
    };
}