package  mlp
{
	import mlp.*;
	/**
	 * ...
	 * @author Ricardo
	 */
	public class FabricaConcreta implements FabricaBala
	{		
		public function crearBala(tipo:String):Bala
		{
			var bala:Bala;
			
			if (tipo == "Calibre 45")
			{
				bala = new Calibre45();
			}
			
			return bala;
		}
	}

}