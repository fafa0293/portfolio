package  
{
	import mlp.*;
	import org.flixel.*;
	public class Requetreque extends Villano
	{
		[Embed(source = "meta/Estallido.mp3")]private var muerte:Class;
		[Embed(source = "meta/requetreque.png")] private static var reque:Class;
		public function Requetreque() 
		{
			super(FlxG.random() * 700, FlxG.random() * 500, (140*16),reque,muerte ,35,35,35,2);
		}
		
		override public function create(pOso:Heroe):Villano
		{
			super.create(pOso);
			enemigo = pOso;
			
			this.addAnimation("fly",[3,4,5],12,true);
			this.addAnimation("fly_back", [0,1,2],12, true);
			
			return this;
		}
		
		override public function update():void 
		{
			if (this.velocity.x > 0)
				play("fly");
			if (this.velocity.x < 0)
				play("fly_back");	
				
			super.update();
		}
		
		override public function kill():void 
		{
			super.kill()
		}
		
		
	}

}