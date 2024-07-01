using Rock_Paper_Scissors;

namespace RPSGameTests;

public class UnitTest1
{
    [Fact]
    public void DetermineWinner_PlayerWins()
    {
        // Arrange
        var player = new Player("Player");
        var ai = new Player("AI");
        var game = new RPSGame(player, ai);

        // Act
        string result = game.DetermineWinner("rock", "scissors");

        // Assert
        Assert.Equal($"{player.Name} wins this round!", result);
    }

    [Fact]
    public void DetermineWinner_AIWins()
    {
        // Arrange
        var player = new Player("Player");
        var ai = new Player("AI");
        var game = new RPSGame(player, ai);

        // Act
        string result = game.DetermineWinner("rock", "paper");

        // Assert
        Assert.Equal($"{ai.Name} wins this round!", result);
    }

    [Fact]
    public void DetermineWinner_Tie()
    {
        // Arrange
        var player = new Player("Player");
        var ai = new Player("AI");
        var game = new RPSGame(player, ai);

        // Act
        string result = game.DetermineWinner("rock", "rock");

        // Assert
        Assert.Equal("It's a tie!", result);
    }

    [Fact]
    public void UpdateScores_PlayerWins()
    {
        // Arrange
        var player = new Player("Player");
        var ai = new Player("AI");
        var game = new RPSGame(player, ai);

        // Act
        game.DetermineWinner("rock", "scissors");

        // Assert
        Assert.Equal(1, player.Score);
        Assert.Equal(0, ai.Score);
    }

    [Fact]
    public void UpdateScores_AIWins()
    {
        // Arrange
        var player = new Player("Player");
        var ai = new Player("AI");
        var game = new RPSGame(player, ai);

        // Act
        game.DetermineWinner("rock", "paper");

        // Assert
        Assert.Equal(0, player.Score);
        Assert.Equal(1, ai.Score);
    }

    [Fact]
    public void UpdateScores_Tie()
    {
        // Arrange
        var player = new Player("Player");
        var ai = new Player("AI");
        var game = new RPSGame(player, ai);

        // Act
        game.DetermineWinner("rock", "rock");

        // Assert
        Assert.Equal(0, player.Score);
        Assert.Equal(0, ai.Score);
    }
}
