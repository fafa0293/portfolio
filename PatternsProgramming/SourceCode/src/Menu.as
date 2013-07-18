package  
{
	import org.flixel.*;
	import mlp.*;
	public class Menu extends FlxState
	{
		[Embed(source="meta/spawner_gibs.png")] public var ImgGibs:Class;
		[Embed(source = "meta/cursor.png")] public var ImgCursor:Class;
		[Embed(source="meta/back.png")] public var ImgBg:Class;
		[Embed(source="meta/menu_hit.mp3")] public var SndHit:Class;
		[Embed(source = "meta/menu_hit_2.mp3")] public var SndHit2:Class;
		[Embed(source = "meta/menu.mp3")] public var bgMusic:Class;
		

		//Replay data for the "Attract Mode" gameplay demos
		[Embed(source="meta/attract1.fgr",mimeType="application/octet-stream")] public var Attract1:Class;
		[Embed(source="meta/attract2.fgr",mimeType="application/octet-stream")] public var Attract2:Class;

		protected var _background:FlxSprite;
		public var gibs:FlxEmitter;
		public var playButton:FlxButton;
		public var title1:FlxText;
		public var title2:FlxText;
		public var fading:Boolean;
		public var timer:Number;
		public var attractMode:Boolean;

		public var pathFollower:FlxSprite;
		public var testPath:FlxPath;

		override public function create():void
		{
			FlxG.bgColor = 0xff0099FF;
			_background = new FlxSprite(0, 0, ImgBg);
			add(_background)

			//Simple use of flixel save game object.
			//Tracks number of times the game has been played.
			var save:FlxSave = new FlxSave();
			if(save.bind("El Ataque de los Requetreques"))
			{
				if(save.data.plays == null)
					save.data.plays = 0 as Number;
				else
					save.data.plays++;
				FlxG.log("Number of plays: "+save.data.plays);
				//save.erase();
				save.close();
			}

			//All the bits that blow up when the text smooshes together
			gibs = new FlxEmitter(FlxG.width/2-50,FlxG.height/2-10);
			gibs.setSize(100,30);
			gibs.setYSpeed(-200,-20);
			gibs.setRotation(-720,720);
			gibs.gravity = 100;
			gibs.makeParticles(ImgGibs,650,32,true,0);
			add(gibs);

			//the letters "mo"
			title1 = new FlxText(FlxG.width + 16,FlxG.height/3,300 ,"El Ataque De");
			title1.size = 30;
			title1.color = 0x996600;
			title1.antialiasing = true;
			title1.velocity.x = -FlxG.width;
			add(title1);

			//the letters "de"
			title2 = new FlxText(-60,title1.y,title1.width,"Los Requetreques");
			title2.size = title1.size;
			title2.color = title1.color;
			title2.antialiasing = title1.antialiasing;
			title2.velocity.x = FlxG.width;
			add(title2);

			fading = false;
			timer = 0;
			attractMode = false;

			/*silly path following test
			pathFollower = new FlxSprite(-20,-20,ImgEnemy);
			testPath = new FlxPath();
			add(pathFollower);//*/

			FlxG.mouse.show(ImgCursor,2);
		}

		override public function destroy():void
		{
			super.destroy();
			gibs = null;
			playButton = null;
			title1 = null;
			title2 = null;

			/*silly path following test
			testPath.destroy();//*/
		}

		override public function update():void
		{
			/*silly path following test code
			if(FlxG.mouse.justPressed() && FlxG.keys.SPACE)
			{
				timer = 0;
				testPath.addPoint(FlxG.mouse);
				if(pathFollower.path == null)
					pathFollower.followPath(testPath,100,FlxObject.PATH_LOOP_FORWARD,true);
			}//*/

			super.update();

			if(title2.x > title1.x + title1.width - 4)
			{
				//Once mo and de cross each other, fix their positions
				title2.x = title1.x + title1.width - 4;
				title1.velocity.x = 0;
				title2.velocity.x = 0;

				//Then, play a cool sound, change their color, and blow up pieces everywhere
				FlxG.play(SndHit);
				FlxG.flash(0xffd8eba2,0.5);
				FlxG.shake(0.035,0.5);
				title1.color = 0x663300;
				title2.color = 0x663300;
				gibs.start(true,5);
				title1.angle = FlxG.random()*30-15;
				title2.angle = FlxG.random() * 30 - 15;
				
				

				//Then we're going to add the text and buttons and things that appear
				//If we were hip we'd use our own button animations, but we'll just recolor
				//the stock ones for now instead.
				var text:FlxText;
				text = new FlxText(FlxG.width/2-130,FlxG.height/3+200,300,"Por Fabián Vega y Ricardo Bonilla")
				text.alignment = "center";
				text.color = 0xCC6633;
				text.size = 20;
				add(text);

				var flixelButton:FlxButton = new FlxButton(700,550,"flixel.org",onFlixel);
				flixelButton.color = 0xff729954;
				flixelButton.label.color = 0xffd8eba2;
				add(flixelButton);

				text = new FlxText(FlxG.width/2-480,FlxG.height-100,1000,"Presione Espacio para comenzar...");
				text.color = 0xCC9933;
				text.alignment = "center";
				text.size = 20;
				add(text);
				FlxG.playMusic(bgMusic);
			}
			

			//X + C were pressed, fade out and change to play state.
			//OR, if we sat on the menu too long, launch the attract mode instead!
			timer += FlxG.elapsed;
			if(timer >= 100) //go into demo mode if no buttons are pressed for 10 seconds
				attractMode = true;
			if(!fading && ((FlxG.keys.SPACE) || attractMode)) 
			{
				fading = true;
				FlxG.play(SndHit2);
				FlxG.flash(0xffd8eba2,0.5);
				FlxG.fade(0xff131c1b,1,onFade);
			}
		}

		//These are all "event handlers", or "callbacks".
		//These first three are just called when the
		//corresponding buttons are pressed with the mouse.
		protected function onFlixel():void
		{
			FlxU.openURL("http://flixel.org");
		}

		protected function onPlay():void
		{
			fading = true;
				FlxG.play(SndHit2);
				FlxG.flash(0xffd8eba2,0.5);
				FlxG.fade(0xff131c1b,1,onFade);
		}

		//This function is passed to FlxG.fade() when we are ready to go to the next game state.
		//When FlxG.fade() finishes, it will call this, which in turn will either load
		//up a game demo/replay, or let the player start playing, depending on user input.
		protected function onFade():void
		{
			if(attractMode)
				FlxG.loadReplay((FlxG.random()<0.5)?(new Attract1()):(new Attract2()),new Mundo(),["ANY"],22,onDemoComplete);
			else
				FlxG.music.stop();
				FlxG.switchState(new Mundo());
		}

		//This function is called by FlxG.loadReplay() when the replay finishes.
		//Here, we initiate another fade effect.
		protected function onDemoComplete():void
		{
			FlxG.fade(0xff131c1b,1,onDemoFaded);
		}

		//Finally, we have another function called by FlxG.fade(), this time
		//in relation to the callback above.  It stops the replay, and resets the game
		//once the gameplay demo has faded out.
		protected function onDemoFaded():void
		{
			FlxG.stopReplay();
			FlxG.resetGame();
		}
	}
}