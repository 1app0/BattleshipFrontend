#pragma checksum "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6681bb353f076bdbe821190538da9746412615e9"
// <auto-generated/>
#pragma warning disable 1591
namespace BattleShipFrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using BattleShipFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using BattleShipFrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\_Imports.razor"
using BlazorStyled;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
using BattleShipFrontEnd.Data.BattleshipData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
using BattleShipFrontEnd.Data.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
using BattleShipFrontEnd.Data.LoginData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
using BattleShipFrontEnd.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Game")]
    public partial class BattleshipGame : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
 if (gameTilesPlayer == null || gameTilesEnemy == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\t");
            __builder.AddMarkupContent(1, "<div class=\"heading3\">\r\n\t\t<span>L</span>\r\n\t\t<span>O</span>\r\n\t\t<span>A</span>\r\n\t\t<span>D</span>\r\n\t\t<span>I</span>\r\n\t\t<span>N</span>\r\n\t\t<span>G</span>\r\n\t\t<span>.</span>\r\n\t\t<span>.</span>\r\n\t\t<span>.</span>\r\n\t</div>\r\n");
#nullable restore
#line 24 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
}
else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\t");
            __builder.AddMarkupContent(3, @"<div id=""heading2"">
		<span>B</span>
		<span>a</span>
		<span>t</span>
		<span>t</span>
		<span>l</span>
		<span>e</span>
		<span>s</span>
		<span>h</span>
		<span>i</span>
		<span>p</span>
		<span></span>
		<span>P</span>
		<span>r</span>
		<span>o</span>
	</div>
");
            __builder.AddMarkupContent(4, "\t");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "allBoards");
            __builder.AddMarkupContent(7, "\r\n\t\t");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "id", "board");
            __builder.AddMarkupContent(10, "\r\n\t\t\t");
            __builder.OpenElement(11, "table");
            __builder.AddMarkupContent(12, "\r\n\t\t\t\t");
            __builder.AddMarkupContent(13, @"<tr>
					<th class=""numbers""></th>
					<th class=""numbers"">0</th>
					<th class=""numbers"">1</th>
					<th class=""numbers"">2</th>
					<th class=""numbers"">3</th>
					<th class=""numbers"">4</th>
					<th class=""numbers"">5</th>
					<th class=""numbers"">6</th>
					<th class=""numbers"">7</th>
					<th class=""numbers"">8</th>
					<th class=""numbers"">9</th>
				</tr>
");
#nullable restore
#line 61 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                 for (int yy = 0; yy < rows; yy++) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\t\t\t\t\t");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(17, "th");
            __builder.AddAttribute(18, "class", "letters");
            __builder.AddContent(19, 
#nullable restore
#line 63 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                             lettersArray[yy]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 64 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                         for (int xx = 0; xx < columns; xx++) {
							GameTile gameTile = gameTilesPlayer[yy * columns + xx];

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "\t\t\t\t\t\t\t");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenComponent<BattleShipFrontEnd.Shared.GameTileCSS>(24);
            __builder.AddAttribute(25, "x", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 67 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                gameTile.X

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "y", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                gameTile.Y

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "enemyBoard", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 69 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                         gameTile.EnemyBoard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "OnClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Double>(this, 
#nullable restore
#line 70 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                        HandleClickPlayerBoard

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(29, "colorBlue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 71 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                        gameTile.ColorBlue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "colorRed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                       gameTile.ColorRed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "colorGrey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 73 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                        gameTile.ColorGrey

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 74 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
						}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 76 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n\t\t");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "id", "boardRight");
            __builder.AddMarkupContent(40, "\r\n\t\t\t");
            __builder.OpenElement(41, "table");
            __builder.AddMarkupContent(42, "\r\n\t\t\t\t");
            __builder.AddMarkupContent(43, @"<tr>
					<th class=""numbers""></th>
					<th class=""numbers"">0</th>
					<th class=""numbers"">1</th>
					<th class=""numbers"">2</th>
					<th class=""numbers"">3</th>
					<th class=""numbers"">4</th>
					<th class=""numbers"">5</th>
					<th class=""numbers"">6</th>
					<th class=""numbers"">7</th>
					<th class=""numbers"">8</th>
					<th class=""numbers"">9</th>
				</tr>

");
#nullable restore
#line 96 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                 for (int yy = 0; yy < rows; yy++) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\t\t\t\t\t");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(47, "th");
            __builder.AddAttribute(48, "class", "letters");
            __builder.AddContent(49, 
#nullable restore
#line 98 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                             lettersArray[yy]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 99 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                         for (int xx = 0; xx < columns; xx++) {
							GameTile gameTile = gameTilesEnemy[yy * columns + xx];

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\t\t\t\t\t\t\t");
            __builder.OpenElement(52, "td");
            __builder.AddMarkupContent(53, "\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenComponent<BattleShipFrontEnd.Shared.GameTileCSS>(54);
            __builder.AddAttribute(55, "x", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 102 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                gameTile.X

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "y", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 103 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                gameTile.Y

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "enemyBoard", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 104 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                         gameTile.EnemyBoard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "OnClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Double>(this, 
#nullable restore
#line 105 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                        HandleClickEnemyBoard

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(59, "colorBlue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 106 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                        gameTile.ColorBlue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "colorRed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 107 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                       gameTile.ColorRed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "colorGrey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 108 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                        gameTile.ColorGrey

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 109 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
						}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 111 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(65, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\t\t");
            __builder.OpenElement(68, "p");
            __builder.AddAttribute(69, "class", "boardInstructions");
            __builder.AddContent(70, 
#nullable restore
#line 114 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                      shipPlacementInstruction

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\t\t");
            __builder.OpenElement(72, "p");
            __builder.AddAttribute(73, "class", "boardInstructions");
            __builder.AddContent(74, 
#nullable restore
#line 115 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                      shootingInstruction

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n\t\t");
            __builder.OpenElement(76, "p");
            __builder.AddAttribute(77, "class", "boardInstructions");
            __builder.AddContent(78, 
#nullable restore
#line 116 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                      saveGameMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\t\t");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "btn btn-primary");
            __builder.AddAttribute(82, "id", "buttonSaveGame");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
                                                                      SaveGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Save and Logout");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 119 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\vasil\Repos\Battleships\BattleshipFrontend\BattleShipFrontEnd\Pages\BattleshipGame.razor"
       
	private List<Char> lettersArray { get; set; } = new List<char>{'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};
	private const int rows = 10;
	private const int columns = 10;
	private int shipTypePlayer = 5;
	private bool canPlaceShip = true;
	private bool canStartShooting = false;
	private bool playerWin = false;
	private string shipPlacementInstruction;
	private string shootingInstruction;
	private string saveGameMessage;
	private GameTile[] gameTilesPlayer;
	private GameTile[] gameTilesEnemy;
	[CascadingParameter]
	private Task<AuthenticationState> authenticationStateTask { get; set; }

	protected override async Task OnInitializedAsync() {
		var authState = await authenticationStateTask;
		var user = authState.User;
		string username = user.Identity.Name;
		bool gameSaved = await BattleShipAccess.CheckForSavedGame(username);
		if (gameSaved) {
			gameTilesPlayer = await GameTileService.GetGameTilesAsync();
			gameTilesEnemy = await GameTileService.GetGameTilesAsync();
			GameConfig gameConfig = await BattleShipAccess.LoadGame(username);
			shipTypePlayer = 0;
			canStartShooting = true;
			int[] tileConfigPlayer = gameConfig.PlayerConfig;
			int[] tileConfigEnemy = gameConfig.BotConfig;
			for (int yy = 0; yy < rows; yy++) {
				for (int xx = 0; xx < columns; xx++) {
					int index = yy * columns + xx;
					GameTile gameTile = gameTilesPlayer[index];
					switch (tileConfigPlayer[index]) {
						case 0:
							break;
						case 1:
							gameTile.ColorGrey = true;
							break;
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
							gameTile.ColorBlue = true;
							break;
						case 7:
						case 8:
						case 9:
						case 10:
						case 11:
							gameTile.ColorRed = true;
							break;
					}
				}
			}
			for (int yy = 0; yy < rows; yy++) {
				for (int xx = 0; xx < columns; xx++) {
					int index = yy * columns + xx;
					GameTile gameTile = gameTilesEnemy[index];
					switch (tileConfigEnemy[index]) {
						case 0:
							break;
						case 1:
							gameTile.ColorGrey = true;
							break;
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
							break;
						case 7:
						case 8:
						case 9:
						case 10:
						case 11:
							gameTile.ColorRed = true;
							break;
					}
				}
			}
			await BattleShipAccess.DeleteSave(username);
			shootingInstruction = "Game successfully loaded, you can resume playing!";
		} else {
			gameTilesPlayer = await GameTileService.GetGameTilesAsync();
			gameTilesEnemy = await GameTileService.GetGameTilesAsync();
			await BattleShipAccess.InitializeGameAsync();			
		}
	}

	private async Task HandleClickPlayerBoard(double fakeCoord) {
		if (shipTypePlayer > 0) {
			int coord = (int) Math.Truncate(fakeCoord);
			bool isVertical = !(coord < fakeCoord);
			canPlaceShip = await CanPlayerPlaceShip(coord, shipTypePlayer, isVertical);
			if (canPlaceShip) {
				if (isVertical) {
					for (int i = 0; i < shipTypePlayer; i++) {
						gameTilesPlayer[coord].ColorBlue = true;
						coord += columns;
					}
				}
				else {
					for (int i = 0; i < shipTypePlayer; i++) {
						gameTilesPlayer[coord].ColorBlue = true;
						coord++;
					}
				}
				shipTypePlayer--;
			}
			shipPlacementInstruction = canPlaceShip ? "Ship placed!" : "You can't place your ship there!";
			if (shipTypePlayer == 0) {
				shipPlacementInstruction = "";
				shootingInstruction = "The game begins";
				canStartShooting = true;
			}
		}
	}

	private async Task HandleClickEnemyBoard(double coord) {
		if (canStartShooting) {
			int rCoord = (int) coord;
			int x = rCoord % columns;
			int y = rCoord / columns;
			if (gameTilesEnemy[rCoord].ColorGrey || gameTilesEnemy[rCoord].ColorRed) {
				shootingInstruction = "You already shot that tile!";
				return;
			}
			ApiShootGameTileResults results = await BattleShipAccess.ShootTile(x, y);
			List<Coordinate> tilesHitByBot = results.Coordinates;
			bool shipHit = results.WasHit;
			if (shipHit) {
				gameTilesEnemy[rCoord].ColorRed = true;
				shootingInstruction = "You hit an enemy ship!";
			}
			if (!shipHit) {
				gameTilesEnemy[rCoord].ColorGrey = true;
				shootingInstruction = "You missed...";
			}
			foreach (var coordinate in tilesHitByBot) {
				int xx = coordinate.X;
				int yy = coordinate.Y;
				int bCoor = yy * columns + xx;
				bool wasPlayerShipHit = coordinate.WasHit;
				bool botWin = coordinate.BotWin;
				playerWin = coordinate.PlayerWin;
				if (playerWin) {
					NavigationManager.NavigateTo("/WinScreen");
				}
				if (botWin) {
					NavigationManager.NavigateTo("/LoseScreen");
				}
				if (wasPlayerShipHit) {
					gameTilesPlayer[bCoor].ColorBlue = false;
					gameTilesPlayer[bCoor].ColorRed = true;
				}
				if (!wasPlayerShipHit) {
					gameTilesPlayer[bCoor].ColorBlue = false;
					gameTilesPlayer[bCoor].ColorGrey = true;
				}
			}
		}
	}

	private async Task<bool> CanPlayerPlaceShip(int coord, int typeOfShip, bool isVertical) {
		int x = coord % columns;
		int y = coord / columns;
		return await BattleShipAccess.CanPlayerPlaceShipAsync(typeOfShip, x, y, isVertical);
	}

	private async Task SaveGame() {
		if (shipTypePlayer  == 0) {
			var authState = await authenticationStateTask;
			var user = authState.User;
			string username = user.Identity.Name;
			string response = await BattleShipAccess.SaveGame(username);
			saveGameMessage = response;
			((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
		}
		else {
			shootingInstruction = "You can't save while placing ships!";
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudBattleShipAccess BattleShipAccess { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameTileService GameTileService { get; set; }
    }
}
#pragma warning restore 1591
