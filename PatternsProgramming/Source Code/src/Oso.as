package  
{

	import mlp.*;
	import org.flixel.*;
	public class Oso extends Heroe
	{
		private static var oso:Oso;
		private var balas:FlxGroup;
		private var punteria:uint;
		private var fabricaConcreta:FabricaConcreta;
		private var bala:Bala
		
		[Embed(source = "meta/Estallido.mp3")]private var muerte:Class;
		[Embed(source="meta/tedTiled.png")] private var grafico:Class;
		public function Oso() 
		{
			super(500, 400, grafico, muerte,140, 840, 140, 400, 10, "Z", "UP", "DOWN", "RIGHT", "LEFT", "X");
			setOso(null);
		}
		
		public static function getOso(pBalas:FlxGroup):Oso
		{
			if (oso==null) {
				crearOso(pBalas);
			}
			return oso;
			
		}
		
		public static function setOso(h:Oso):void 
		{
			oso = h;
		}
		
		override public	function update():void
		{
			if (oso.velocity.y < 0 || oso.velocity.y > 0) {
					play("jump");
				}else if (isTouching(FLOOR)) {
				
				if (oso.velocity.x == 0) 
				{
					play("idle");
				}
				else if (velocity.x > 0 )
				{
					play("walk");
				}else if (velocity.x < 0)
				{
					play("walk_back");
				}
				
			}
			
			if(FlxG.keys.UP)
				this.punteria = UP;
			else if(FlxG.keys.DOWN && this.velocity.y)
				this.punteria = DOWN;
			else if (FlxG.keys.RIGHT)
				this.punteria = RIGHT;
			else if (FlxG.keys.LEFT)
				this.punteria = LEFT;
			
			super.update();
			
		}
		
		override public function accion():void
		{
			if(!flickering)
			{
				getMidpoint(_point);
				fabricaConcreta = new FabricaConcreta();
				if(bala==null){
				bala = fabricaConcreta.crearBala("Calibre 45");
				
				balas.add(bala);
				}
				(this.balas.recycle(Bala) as Bala).shoot(_point, this.punteria);
				if(this.punteria == DOWN)
					this.velocity.y -= 36;
			}
		}
		
		public static function crearOso(pbalas:FlxGroup):void
		{
			oso = new Oso();
			
			
			
			oso.addAnimation("idle",[0],0,false);
			oso.addAnimation("walk",[1,2,3],10,true);
			oso.addAnimation("walk_back",[5,6,7],10,true);
			oso.addAnimation("flail",[4],18,true);
			oso.addAnimation("jump", [4], 0, false);
			
			oso.punteria = RIGHT;
			oso.balas = pbalas;
		}
		
		override public	function destroy():void
		{
			super.destroy();
		}
		
		override public	function kill():void
		{
			super.kill();
			oso = null;
			balas = null;
		}
		
		
	}

}