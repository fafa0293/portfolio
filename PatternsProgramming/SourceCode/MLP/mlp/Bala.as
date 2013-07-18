package  mlp
{

		import org.flixel.*;
	public class Bala extends Arma
	{
		
		[Embed(source="meta/bala.png")] private var ImgBullet:Class;

		

		public function Bala()
		{
			
			
			super();
			loadGraphic(ImgBullet,true);
			
			speed = 360;
		}

		public function shoot(Location:FlxPoint, Aim:uint):void
		{
			FlxG.play(SndShoot);
			super.reset(Location.x-width/2,Location.y-height/2);
			solid = true;
			switch(Aim)
			{
				case UP:
					play("up");
					velocity.y = -speed;
					break;
				case DOWN:
					play("down");
					velocity.y = speed;
					break;
				case LEFT:
					play("left");
					velocity.x = -speed;
					break;
				case RIGHT:
					play("right");
					velocity.x = speed;
					break;
				default:
					break;
			}
		}
	}

}