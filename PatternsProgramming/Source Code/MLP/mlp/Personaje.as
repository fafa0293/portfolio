package  mlp
{
	import flash.display.GraphicsPath;
	import org.flixel.*; 
	import flash.display.BlendMode;
	public class Personaje extends FlxSprite
	{
		
		
		private var image:Class;
		private var died:Class;
		public var accelelX:uint;
		public var accelelY:uint;
		public var	maxVelX:uint;
		public var	maxVelY:uint;
		private var vida:uint;
		
		public function Personaje(x:Number, y:Number, pImg:Class, diedSong:Class,accelelX:uint, accelelY:uint, maxVelX:uint, maxVelY:uint, vida:uint) 
		{
			
			super(x, y);
			this.image = pImg;
			this.died = diedSong;
			this.accelelX = accelelX;
			this.accelelY = accelelY;
			this.maxVelX = maxVelX;
			this.maxVelY = maxVelY;
			this.vida = vida;
			
			crear();
			
		}
		
		public function crear():void
		{
			loadGraphic(image, true);
			
			drag.x = accelelX*16;
			acceleration.y = accelelY;
			maxVelocity.x = maxVelX;
			maxVelocity.y = maxVelY;
			health = vida;
						
		}
		
		override public function destroy():void
		{
			
			super.destroy();
			
		}
		
		public function accion():void {
			
		}
		
		override public function hurt(Damage:Number):void
		{
			Damage = 0;
			if(flickering)
				return;
			
			flicker(1.3);
			if(FlxG.score > 1000) FlxG.score -= 1000;
			if(velocity.x > 0)
				velocity.x = -maxVelocity.x;
			else
				velocity.x = maxVelocity.x;
			super.hurt(Damage);
		}

		override public function kill():void
		{
			if(!alive)
				return;
			FlxG.play(died);
			super.kill();
			FlxG.camera.shake(0.005,0.35);
			FlxG.camera.flash(0xffd8eba2, 0.35);
		}
		
	}

}