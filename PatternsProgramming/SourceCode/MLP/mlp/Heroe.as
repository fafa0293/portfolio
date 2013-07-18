package  mlp
{
	import org.flixel.*; 

	public class Heroe extends Personaje
	{
		
		private var	controlSalto:String;
		private var	controlBajo:String;
		private var controlDerecha:String;
		private var controlArriba:String;
		private var controlIzquierda:String;
		private var controlAccion:String;

		
		public function Heroe(pX:int,pY:int, pImg:Class, diedSong:Class,accelelX:uint, accelelY:uint, maxVelX:uint, maxVelY:uint, vida:uint, controlSalto:String, controlArriba:String,controlBajo:String, controlDerecha:String, controlIzquierda:String, controlAccion:String) 
		{			
			super(pX, pY, pImg, diedSong , accelelX, accelelY, maxVelX, maxVelY, vida);
			this.controlSalto = controlSalto;
			this.controlBajo = controlBajo;
			this.controlDerecha = controlDerecha;
			this.controlIzquierda = controlIzquierda;
			this.controlAccion = controlAccion;
		}
		
		
		
		
		override public function update():void
		{

			this.acceleration.x = 0;
			
			if (FlxG.keys.pressed(controlIzquierda)){
			this.acceleration.x -= this.drag.x;
			}
		
			if (FlxG.keys.pressed(controlDerecha)){
			this.acceleration.x += this.drag.x;
			}
			
			if (FlxG.keys.justPressed(controlSalto))
			{
				if (isTouching(FLOOR)){
				this.velocity.y = -this.acceleration.y * 0.51;
				}
			}		
			if(FlxG.keys.justPressed(controlAccion))
			{
				accion();
			}
		}
		
		override public function destroy():void
		{
			super.destroy();
		}
		
		override public function kill():void 
		{
			super.kill();
		}
		
	}


}
