using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex2
{
    internal class pokedex
    {
        public pokedex()
        {
            this.Inicia();
        }
		private List<pokemon> pokemons;

		public List<pokemon> Pokemons
		{
			get { return pokemons; }//os usuarios apenas poderao ler/pegar os dados (adues set)
			
		}
		private void Inicia()
		{
			//instanciar lista
			this.pokemons = new List<pokemon>();
			pokemon p = new pokemon("bulbasauro", "sua descrçao");//sobrecarga + 1? ignifica que vc possui uma com e outra sem parametro      
            this.pokemons.Add(p);
            p = new pokemon("1", "fudido");
            this.pokemons.Add(p);  
			p = new pokemon("2", "cuzudo");
            this.pokemons.Add(p);
            p = new pokemon("3", "leitoso");
            this.pokemons.Add(p);
            p = new pokemon("4", "azarado");
            this.pokemons.Add(p);
            p = new pokemon("5", "lascado");
            this.pokemons.Add(p);
            p = new pokemon("6", "pirocudo");
            this.pokemons.Add(p);
            p = new pokemon("7", "arrombado");
            this.pokemons.Add(p);
            p = new pokemon("8", "zZz");
            this.pokemons.Add(p);
            p = new pokemon("9", "to sem criatividade");
            this.pokemons.Add(p);
            p = new pokemon("10", "fumante");
            this.pokemons.Add(p);
        }

        public void ListarPokemons()
        {
            for(int i = 0; i < this.pokemons.Count; i++)//o valor de "0" fara com que o for percorra a lista inteira
            {   
                this.pokemons[i].exibir();
            //   pokemon p = this.pokemons[i];
              //  p.exibir();
            }

        }
	}
}
