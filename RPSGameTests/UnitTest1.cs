using Rock_Paper_Scissors;

namespace RPSGameTests;

public class UnitTest1
{
    [Fact]
    public void DetermineWinner_PlayerWins()
    {
        // Arrange
        var player = new Player { Name = "TestPlayer", Score = 0 };
        var game = new RPSGame();

        // Act
        game.DetermineWinner("Rock", "Scissors", player);

        // Assert
        Assert.Equal(1, player.Score);
    }

    [Fact]
    public void DetermineWinner_AIWins()
    {
        // Arrange
        var player = new Player { Name = "TestPlayer", Score = 0 };
        var game = new RPSGame();

        // Act
        game.DetermineWinner("Rock", "Paper", player);

        // Assert
        Assert.Equal(0, player.Score);
    }

    [Fact]
    public void DetermineWinner_Tie()
    {
        // Arrange
        var player = new Player { Name = "TestPlayer", Score = 0 };
        var game = new RPSGame();

        // Act
        game.DetermineWinner("Rock", "Rock", player);

        // Assert
        Assert.Equal(0, player.Score);
    }

    [Fact]
    public void PlayRound_AIScoreUpdatesCorrectly()
    {
        // Arrange
        var player = new Player { Name = "TestPlayer", Score = 0 };
        var game = new RPSGame();

        // Act
        game.DetermineWinner("Rock", "Paper", player);

        // Assert
        Assert.Equal(0, player.Score);
    }

    [Fact]
    public void PlayUntilScoreThree_PlayerWins()
    {
        // Arrange
        var player = new Player { Name = "TestPlayer", Score = 0 };
        var game = new RPSGame();

        // Simulate player winning 3 rounds
        game.DetermineWinner("Rock", "Scissors", player);
        game.DetermineWinner("Paper", "Rock", player);
        game.DetermineWinner("Scissors", "Paper", player);

        // Act
        game.PlayUntilScoreThree(player, 0);

        // Assert
        Assert.Equal(3, player.Score);
    }
}