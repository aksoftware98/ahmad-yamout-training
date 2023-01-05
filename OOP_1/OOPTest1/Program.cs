// See https://aka.ms/new-console-template for more information
// Build an a game where players can challenge each other in a football with the following requirement: 
/* 1- User can a select a team 
 * 2- User can subsititue the players with a team 
 * 3- Each team has 20 players (11 main + 9 subs)
 * 4- Each player has a name, age, position, and rating
 * 5- User can build a game by choose two teams and stadium 
 * 6- Player can shoot the ball or pass it to another player
 * 7- Player can get subsituted
 */
// In-Memory datasource  
var number = 1; // Int => 32bit 
var number2 = 0;

var number3 = number2;
number2 = 5;
Console.WriteLine(number3); // 0

Team teamOne = new Team();
teamOne.Country = "UK";  // Object rererence not set to an instance of an object

Team teamTwo = teamOne;
teamTwo.Country = "France";


Team teamThree = teamTwo;
teamThree.Country = "Germany";

Team teamFour = new Team(); 

Console.WriteLine(teamOne.Country); // France
Console.WriteLine(teamTwo.Country); // France

#region Data 
// Build the Teams 
Team spain = new Team()
{
	Coach = "Someone",
	Country = "Spain",
	Flag = "https://spain.flag.jpg",
	Id = 4545,
	Players = new Player[20]
	{
		new Player { Id = 5454, Name = "Ramos", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ftesd", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "EFfsdfsd", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Hebwe", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos3", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos54", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos34", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos33", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos243", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos123", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos12321", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos4334", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos12321", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos32423", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos653", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos5454", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos542", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos2134", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos1231", Age = 34, Rating = 8 },
		new Player { Id = 5454, Name = "Ramos2132", Age = 34, Rating = 8 },
	}
};

Team france = new Team()
{
	Coach = "Someone3",
	Country = "France",
	Flag = "https://france.flag.jpg",
	Id = 878987,
	Players = new Player[20]
	{
		new Player { Id = 5454, Name = "fdfa", Age = 34, Rating = 8 },
		new Player { Id = 54454, Name = "sdafsd", Age = 34, Rating = 8 },
		new Player { Id = 54254, Name = "asdfsd", Age = 34, Rating = 8 },
		new Player { Id = 54154, Name = "sdafsd", Age = 34, Rating = 8 },
		new Player { Id = 54354, Name = "dsfasdf", Age = 34, Rating = 8 },
		new Player { Id = 546654, Name = "dsfasd", Age = 34, Rating = 8 },
		new Player { Id = 547454, Name = "Ramos34", Age = 34, Rating = 8 },
		new Player { Id = 542354, Name = "Ramretgertfgbhhrteos33", Age = 34, Rating = 8 },
		new Player { Id = 542354, Name = "reterter", Age = 34, Rating = 8 },
		new Player { Id = 5423454, Name = "erterr", Age = 34, Rating = 8 },
		new Player { Id = 5434354, Name = "ntrrthgt", Age = 34, Rating = 8 },
		new Player { Id = 54546554, Name = "erterert", Age = 34, Rating = 8 },
		new Player { Id = 5343454, Name = "ewrte", Age = 34, Rating = 8 },
		new Player { Id = 5234454, Name = "asdf", Age = 34, Rating = 8 },
		new Player { Id = 5434354, Name = "sdfasd", Age = 34, Rating = 8 },
		new Player { Id = 54213154, Name = "asdfasd", Age = 34, Rating = 8 },
		new Player { Id = 54123254, Name = "asdfer", Age = 34, Rating = 8 },
		new Player { Id = 512344454, Name = "asertfr", Age = 34, Rating = 8 },
		new Player { Id = 5434354, Name = "sdafsd", Age = 34, Rating = 8 },
		new Player { Id = 51232454, Name = "asdfsd", Age = 34, Rating = 8 },
	}
};

var wembly = new Stadium
{
	Country = "England",
	Id = 123,
	Name = "Wembly",
};

var rome = new Stadium
{
	Country = "Italy",
	Id = 123,
	Name = "Rome",
};
#endregion 

var allTeams = new[] { spain, france }; // 1000 
var allStadiums = new[] { wembly, rome };

var games = new List<Game>();

var user = new User()
{
	Id = 3567,
	Usrename = "ahmadmozaffar"
};
user.SetPhone("8189993333"); 


while (true)
{
	Console.WriteLine("******* Start a new game:********");
	Console.WriteLine("Select the first team:");
	var firstTeamName = Console.ReadLine();
	var firstTeam = allTeams.FirstOrDefault(t => t.Country == firstTeamName);

	if (firstTeam == null)
	{
		Console.WriteLine("Team not found, please try again");
		continue;
	}
	
	Console.WriteLine("Select the second team:");
	var secondTeamName = Console.ReadLine();
	var secondTeam = allTeams.FirstOrDefault(t => t.Country == secondTeamName);

	if (secondTeam == null)
	{
		Console.WriteLine("Team not found, please try again");
		continue;
	}

	Console.WriteLine("Select the stadium:");
	var stadiumName = Console.ReadLine();
	var stadium = allStadiums.FirstOrDefault(t => t.Name == stadiumName);
	if (stadium == null)
	{
		Console.WriteLine("Stadium not found, please try again");
		continue;
	}

	// Create the game 
	var game = user.CreateGame(firstTeam, secondTeam, stadium);
	games.Add(game);

	game.Start();
	Thread.Sleep(3000);

	var player = firstTeam.Players[2];
	var shootResult = player.Shoot();
	if (shootResult)
		game.Score(player);

	var player2 = firstTeam.Players[7];
	var shootResult2 = player2.Shoot();
	if (shootResult2)
		game.Score(player2);

	var player3 = secondTeam.Players[3];
	var shootResult3 = player3.Shoot();
	if (shootResult3)
		game.Score(player3);

	var player4 = secondTeam.Players[3];
	var shootResult4 = player4.Shoot();
	if (shootResult4)
		game.Score(player4);

	game.End(); 
}


public class User
{
	// Attributes (Data)
	// Encapsulation 


	//private int id;
	
	//// Read-Only property 
	//public int Id
	//{
	//	get { return id; }
	//	private set 
	//	{
	//		// Add your logic 
	//		id = value;  
	//	}
	//}
	
	private string phone = "123456789";
	
	public string GetPhone()
	{
		return phone.Substring(4); 
	}

	public void SetPhone(string phone)
	{
		if (!phone.StartsWith("+961"))
			phone = "+961" + phone;
		this.phone = phone; 
	}
	public int Id { get; set; } // Auto-Property 
	
	public string? Usrename { get; set; }

	// Behaviors (Methods)
	public Game CreateGame(Team firstTeam, Team secondTeam, Stadium stadium)
	{
		// Validation logic 
		if (firstTeam.Id == secondTeam.Id)
			throw new Exception("You can't play against yourself");
		
		return new Game
		{
			FirstTeam = firstTeam,
			SecondTeam = secondTeam,
			FirstTeamScore = 0,
			SecondTeamScore = 0,
			Stadium = stadium
		};
	}
}

public class Player
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public int Age { get; set; }
	public int Rating { get; set; }
	public bool IsMain { get; set; }
	/// <summary>
	/// When players shoots the ball to the target, it returns true if he scores or false if not 
	/// </summary>
	/// <returns></returns>
	/// 
	static Random random = new Random(); 
	public bool Shoot()
	{
		Console.WriteLine($"And {Name} has shoot to the target!!!");
		Thread.Sleep(2500);
		// Physics 
		var randomNumber = random.Next(0, 2);
		if (randomNumber == 0)
			return false;
		else
			return true;
	}

	/// <summary>
	/// When the player passes the ball to the the target, it returns true if he succeded or false if not
	/// </summary>
	/// <param name="targetPlayer"></param>
	/// <returns></returns>
	public bool Pass(Player targetPlayer)
	{
		var randomNumber = random.Next(0, 1);
		if (randomNumber == 0)
			return false;
		else
			return true;
	}
}

public class Game
{
	public Team? FirstTeam { get; set; }

	public Team? SecondTeam { get; set; }

	public Stadium? Stadium { get; set; }
	
	public int FirstTeamScore { get; set; }
	public int SecondTeamScore { get; set; }

	public void Start()
	{
		// Turn on the timer for 90mins 
		// Game logic
		Console.WriteLine($"Game has just started: {FirstTeam.Country} vs {SecondTeam.Country} at {DateTime.Now}"); 
	}

	public void End()
	{
		// Announce the winner
		Console.WriteLine($"Game has finished: {FirstTeam.Country} ({FirstTeamScore}) vs {SecondTeam.Country} ({SecondTeamScore}) at {DateTime.Now}");
	}
	
	public void Score(Player player)
	{
		Player? firstTeamPlayer = CheckIfPlayerFromFirstTeam(player);
		if (firstTeamPlayer == null)
		{
			// Second team scored 
			SecondTeamScore++;
			Console.WriteLine($"{SecondTeam.Country} HAAS SCORED!!!!!");
		}
		else
		{
			// First team scored 
			FirstTeamScore++;
			Console.WriteLine($"{FirstTeam.Country} HAAS SCORED!!!!!");
		}
	}

	private Player? CheckIfPlayerFromFirstTeam(Player player)
	{
		// Check if the player in the first team 
		return FirstTeam.Players.FirstOrDefault(p => p.Id == player.Id);
	}



	// Number of passes
	// people who scores 
	// people who get substituted
	// people who get yellow card
}

public class Team
{
    public Team()
    {
		Players = new Player[20]; 
    }

    public int Id { get; set; }
	public string? Flag { get; set; }
	public string? Country { get; set; }
	public string? Coach { get; set; }
	public Player[]? Players { get; set; }
}

public class Stadium
{
	public int Id { get; set; }
	public string? Country { get; set; }
	public string? Name { get; set; }
}

// Homework 
// Static, Interface, Abstract, Encapsulation, Polymorphism
