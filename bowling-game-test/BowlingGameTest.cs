using bowling_game;

namespace bowling_game_test
{
    public class BowlingGameTest
    {
        [Fact]
        public void AllZeroScores()
        {
            var game = new BowlingGame();
            RollManyOpen(ref game, 10, 0 , 0);
            Assert.Equal(0, game.Score());
        }

        
        [Fact]
        public void AllOneScores()
        {
            var game = new BowlingGame();
            RollManyOpen(ref game, 10, 1, 1);
            Assert.Equal(20, game.Score());
        }

        [Fact]
        public void Spare()
        {
            var game = new BowlingGame();
            game.Spare(5, 5);
            game.Open(3,5);
            RollManyOpen(ref game, 8, 0, 0);
            Assert.Equal(21, game.Score());
        }

        [Fact]
        public void Strike()
        {
            var game = new BowlingGame();
            game.Strike();
            game.Open(3, 5);
            RollManyOpen(ref game, 8, 0, 0);
            Assert.Equal(26, game.Score());
        }

        [Fact]
        public void SpareInLastFrame()
        {
            var game = new BowlingGame();
            RollManyOpen(ref game, 9, 0, 0);
            game.Spare(6,4);
            game.Bonus(5);
            Assert.Equal(15, game.Score());
        }

        [Fact]
        public void StrikeInLastFrame()
        {
            var game = new BowlingGame();
            RollManyOpen(ref game, 9, 0, 0);
            game.Strike();
            game.Bonus(5);
            game.Bonus(3);
            Assert.Equal(18, game.Score());
        }

        [Fact]
        public void PerfectGame()
        {
            var game = new BowlingGame();
            for (int i = 0; i < 10; i++)
                game.Strike();
            game.Bonus(10);
            game.Bonus(10);
            Assert.Equal(300, game.Score());
        }

        [Fact]
        public void ScoreAfterTwoFrame()
        {
            var game = new BowlingGame();
            game.Open(2, 4);
            game.Open(2, 4);
            game.Bonus(10);
            game.Spare(5,5);
            game.Open(2, 4);
            Assert.Equal(40, game.Score());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="game"> Passing the game object as referrence</param>
        /// <param name="count">Frame count</param>
        /// <param name="firstThrow">First Throw</param>
        /// <param name="secondThrow">Second Throw</param>
        private static void RollManyOpen(ref BowlingGame game,int count, int firstThrow, int secondThrow)
        {
            for (int frameNumber = 0; frameNumber < count; frameNumber++)
            {
                game.Open(firstThrow, secondThrow);
            }
        }


    }
}