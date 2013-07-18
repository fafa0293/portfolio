package  
{
	import org.flixel.*;
	import mlp.*;
	public class Victoria extends FlxState
	{
				[Embed(source="meta/spawner_gibs.png")] public var ImgGibs:Class;
		[Embed(source = "meta/cursor.png")] public var ImgCursor:Class;
		[Embed(source="meta/back.png")] public var ImgBg:Class;
		[Embed(source="meta/menu_hit.mp3")] public var SndHit:Class;
		[Embed(source = "meta/menu_hit_2.mp3")] public var SndHit2:Class;
		[Embed(source = "meta/ganar.mp3")] public var bgMusic:Class;
		
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

		override public function create():void
		{
			FlxG.bgColor = 0xff0099FF;
			_background = new FlxSprite(0, 0, ImgBg);
			add(_background)
			
			Oso.setOso(null);

			var save:FlxSave = new FlxSave();
			if(save.bind("Super Ted Bear"))
			{
				if(save.data.plays == null)
					save.data.plays = 0 as Number;
				else
					save.data.plays++;
				FlxG.log("Number of plays: "+save.data.plays);
				save.close();
			}

			gibs = new FlxEmitter(FlxG.width/2-50,FlxG.height/2-10);
			gibs.setSize(100,30);
			gibs.setYSpeed(-200,-20);
			gibs.setRotation(-720,720);
			gibs.gravity = 100;
			gibs.makeParticles(ImgGibs,650,32,true,0);
			add(gibs);

			title1 = new FlxText(FlxG.width + 16,FlxG.height/3,175 ,"Has");
			title1.size = 30;
			title1.color = 0x996600;
			title1.antialiasing = true;
			title1.velocity.x = -FlxG.width;
			add(title1);

			title2 = new FlxText(-60,title1.y,title1.width,"Ganado!!!");
			title2.size = title1.size;
			title2.color = title1.color;
			title2.antialiasing = title1.antialiasing;
			title2.velocity.x = FlxG.width;
			add(title2);

			fading = false;
			timer = 0;
			attractMode = false;

			FlxG.mouse.show(ImgCursor,2);
		}

		override public function destroy():void
		{
			super.destroy();
			gibs = null;
			playButton = null;
			title1 = null;
			title2 = null;
		}

		override public function update():void
		{
			super.update();

			if(title2.x > title1.x + title1.width - 4)
			{
				title2.x = title1.x + title1.width - 4;
				title1.velocity.x = 0;
				title2.velocity.x = 0;


				FlxG.play(SndHit);
				FlxG.flash(0xffd8eba2,0.5);
				FlxG.shake(0.035,0.5);
				title1.color = 0x663300;
				title2.color = 0x663300;
				gibs.start(true,5);
				title1.angle = FlxG.random()*30-15;
				title2.angle = FlxG.random() * 30 - 15;
				
				

				var text:FlxText;
				text = new FlxText(FlxG.width/2-130,FlxG.height/3+200,300,"El Ataque de los Requetreques: Por Fabián Vega y Ricardo Bonilla")
				text.alignment = "center";
				text.color = 0xCC6633;
				text.size = 20;
				add(text);

				var flixelButton:FlxButton = new FlxButton(700,550,"flixel.org",onFlixel);
				flixelButton.color = 0xff729954;
				flixelButton.label.color = 0xffd8eba2;
				add(flixelButton);

				text = new FlxText(FlxG.width/2-480,FlxG.height-100,1000,"Presione Espacio para volver a jugar...");
				text.color = 0xCC9933;
				text.alignment = "center";
				text.size = 20;
				add(text);
				FlxG.playMusic(bgMusic);
			}
			


			if(FlxG.keys.SPACE) 
			{
				FlxG.music.stop();
				FlxG.switchState(new Mundo());
			}
		}
		protected function onFlixel():void
		{
			FlxU.openURL("http://flixel.org");
		}
		
	}

}