package  mlp
{
	import org.flixel.*; 

	public class Arma extends FlxSprite
	{
		[Embed(source="meta/jump.mp3")] public var SndHit:Class;
		[Embed(source = "meta/shoot.mp3")] public var SndShoot:Class;
		
		public var speed:Number;
		public function Arma() 
		{
			width = 50;
			height = 50;
			offset.x = 1;
			offset.y = 1;

			addAnimation("up",[0]);
			addAnimation("down",[1]);
			addAnimation("left",[2]);
			addAnimation("right",[3]);
			addAnimation("poof",[4, 5, 6, 7], 50, false);

			
		}
		
		override public function update():void
		{
			if(!alive)
			{
				if(finished)
					exists = false;
			}
			else if(touching)
				kill();
		}
		
		override public function kill():void
		{
			if(!alive)
				return;
			velocity.x = 0;
			velocity.y = 0;
			if(onScreen())
				FlxG.play(SndHit);
			alive = false;
			solid = false;
			play("poof");
		}
		
	}
	

}