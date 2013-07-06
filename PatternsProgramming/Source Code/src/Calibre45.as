package  
{
	import mlp.Bala;
	/**
	 * ...
	 * @author Ricardo
	 */
	public class Calibre45 extends Bala
	{
		[Embed(source="../MLP/mlp/meta/bala.png")] private var ImgBullet:Class;

		public function Calibre45() 
		{
			
			loadGraphic(ImgBullet, true);
			speed = 360;
		}
		
	}

}