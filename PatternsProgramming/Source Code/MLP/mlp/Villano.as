package  mlp 
{

	import org.flixel.*;
	import mlp.*;
	 
	public class Villano extends Personaje
	{
		
		
		protected var enemigo:Heroe;
		private static var image:Class;
		
		public function Villano( pX:int, pY:int, accelelX:int, grp:Class, diedSong:Class, accelelY:uint, maxVelX:uint, maxVelY:uint, vida:uint)
		{
			super(pX, pY, grp,diedSong , accelelX, accelelY, maxVelX, maxVelY, vida);			
			image = grp
			
			crear();
		}
		
		
		
		public function create(pheroe:Heroe):Villano
		{
			enemigo = pheroe;
			this.loadGraphic(image, true,true,29, 14);
			
			
			
			return this;
		}
		
		override public function update():void
		{				
			
			if (enemigo.x > this.x)
			{
				this.acceleration.x = accelelX;
			}
			if (enemigo.x < this.x)
			{
				this.acceleration.x = -accelelX;
			}
			if (enemigo.y > this.y)
			{
				this.acceleration.y = accelelX;
			}
			if (enemigo.y < this.y)
			{
				this.acceleration.y = -accelelX;
			}
				
				
		}

		
		override public function kill():void
		{
			super.kill();
			velocity.y = 0;
			alive = false;
			solid = false;	
		}
		
	}
}