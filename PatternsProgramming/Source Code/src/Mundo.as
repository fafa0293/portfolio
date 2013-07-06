package  
{
	import flash.display.BlendMode;
	import flash.net.GroupSpecifier;
	import org.flixel.*;
	import mlp.*;
	public class Mundo extends FlxState
	{
		
		[Embed(source = "meta/auto_tiles.png")]private static var auto_floortiles:Class;
		[Embed(source = "meta/level1.txt", mimeType = 'application/octet-stream')]private static var level1:Class;
		[Embed(source = "meta/juego.mp3")] public var bgMusic:Class;
		[Embed(source = "meta/trofeo.png")]private static var trofeo:Class;
		
		private const tlwidth:uint = 16;
		private const tlheight:uint = 16;
		
		private var box:FlxObject;
		
		public var i:Number;
		private var level:FlxTilemap;
		private var oso:Oso;
		public var reques:FlxGroup;
		private var balas:FlxGroup;
		public var timer:Number;
		private var ganar:Personaje;
		private var muertes:int;

		
		override public function create():void
		{
			FlxG.mouse.hide();
			FlxG.playMusic(bgMusic);
			FlxG.framerate = 60;
			FlxG.flashFramerate = 60;
			
			muertes = 0;
			
			level = new FlxTilemap();
			
			level.loadMap(new level1(), auto_floortiles, tlwidth, tlheight, FlxTilemap.AUTO);
			add(level);
			
			timer = 0;
			
			ganar = new Personaje(750,520,trofeo,null,0,0,0,0,0);
			ganar.exists = false;
			add(ganar);
			
			
			FlxG.bgColor = 0xffa4d0de;
			
			box = new FlxObject(0, 0, tlwidth, tlheight);
			
			balas = new FlxGroup();
			
			crearOso();
			
			reques = new FlxGroup();
			add(reques);
			
			
			for (i = 0; i < 10; i++ ) {
				crearReque();
			}
			
		}
		
		override public function destroy():void
		{
			super.destroy();

			balas = null;
			oso = null;
			reques = null;

		}
		
		override  public function update():void {
			
			
			wrap(oso);
			wrap(ganar);

			FlxG.overlap(balas);
			FlxG.collide(oso, level);
			wrap(oso);
			if(oso.exists){
				oso.update();	
			}
			super.update();
			FlxG.collide();
			
			FlxG.overlap(balas, reques, colicionRe);
			FlxG.overlap(oso, reques, colicion);
			FlxG.overlap(oso,ganar,victoria);
			FlxG.collide(reques);
			if (!oso.exists) {
				
				FlxG.resetState();
			}
			
			for each (var reque:Requetreque in reques) 
			{
				reque.update();
			}
			
			
			if (muertes == i){
				ganar.exists = true;
				
			}
		}
		
		protected function colicion(Object1:FlxObject,Object2:FlxObject):void
		{
			Object1.kill();
			Object2.kill();
		}
		
		protected function colicionRe(Object1:FlxObject,Object2:FlxObject):void
		{
			Object1.kill();
			Object2.kill();
			muertes = muertes + 1;
		}
		
		private function crearOso():void
		{
			oso = Oso.getOso(balas);
			
			add(oso);
			 
			add(balas);
			
		}
		
		private function crearReque():void
		{
			var reque:Requetreque = reques.recycle(Requetreque) as Requetreque;
			reque.create(oso);
		
		}
		
		private function wrap(obj:FlxObject):void
		{
			obj.x = (obj.x + obj.width / 2 + FlxG.width) % FlxG.width - obj.width / 2;
			obj.y = (obj.y + obj.height / 2) % FlxG.height - obj.height / 2;
		}
		
		public function victoria(Exit:Personaje,Player:Personaje):void
		{
			FlxG.music.stop();
			FlxG.switchState(new Victoria());
		}
	}
}