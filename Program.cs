using System;

//CHARLES WILLIAN VIEIRA DA SILVA

namespace Pilha_e_Fila
{
    class Elemento
    {
        public int numero;
        public Elemento proximo;
    }

    class Pilha
    {
        public Elemento topo = null;
        public int tamanho = 0;
        public void exibir()
        {
            Elemento aux = topo;

            while (aux != null)
            {
                Console.WriteLine($"{aux.numero}");
                aux = aux.proximo;
            }
        }
        public void exibir(Elemento aux)
        {
            if (aux != null)
            {
                Console.WriteLine($"{aux.numero}");
                exibir(aux.proximo);
            }
        }
        public void empilhar (int x)
        {
            Elemento meuElemento = new Elemento();
            if (!pesquisar(x))
            {
                meuElemento.numero = x;
                meuElemento.proximo = topo;
                topo = meuElemento;
                tamanho++;
            }
            else
            {
                Console.WriteLine("Elemento já está na pilha!");
            }
        }
        public bool pesquisar (int x)
        {
            Elemento aux = topo;

            while (aux != null && aux.numero != x)
            {
                aux = aux.proximo;
            }
            if (aux != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool pesquisar (Elemento aux, int x)
        {
            if (aux == null)
            {
                return false;
            }
            else if (aux.numero == x)
            {
                return true;
            }
            else
            {
                return (pesquisar(aux.proximo, x));
            }
        }
        public void esvaziar()
        {
            topo = null;
            tamanho = 0;
        }
        public bool vazio()
        {
            return (topo == null);
        }
        public Elemento desempilhar()
        {
            Elemento aux = topo;

            if (topo == null)
            {
                return null;
            }
            else
            {
                topo = topo.proximo;
                tamanho--;
                return (aux);
            }
        }
        public int maiorTopo(Elemento topo, Elemento el, int cont)
        {
            if (el == null)
            {
                return cont;
            }
            else
            {
                if (el.numero > topo.numero)
                {
                    return (maiorTopo(topo, el.proximo, cont + 1));
                }
                else
                {
                    return (maiorTopo(topo, el.proximo, cont));
                }
            }
        }
        public int maiorTopo()
        {
            Elemento aux = topo;
            int cont = 0;
            while (aux != null)
            {
                if (aux.numero > topo.numero)
                {
                    cont++;
                }
                aux = aux.proximo;
            }
            return cont;
        }

    }


    class Fila
    {
        public Elemento inicio = null;
        public Elemento fim = null;
        public int tamanho = 0;


        public void enfileirar(int x)
        {
            if (pesquisar(x))
            {
                Console.WriteLine("Elemento já existe");
            }
            else
            {
                Elemento novo = new Elemento();
                novo.numero = x;
                novo.proximo = null;
                tamanho++;

                if (inicio == null)
                {
                    inicio = novo;
                }
                else
                {
                    fim.proximo = novo;
                }
                fim = novo;
            }
        }
        public Elemento desenfileirar()
        {
            Elemento aux = inicio;

            if (inicio != null)
            {
                inicio = inicio.proximo;
                tamanho--;

                if (inicio == null)
                {
                    fim = null;
                }
            }
            return aux;
        }
        public bool pesquisar(int x)
        {
            Elemento aux = inicio;

            while (aux != null && aux.numero != x)
            {
                aux = aux.proximo;
            }
            if (aux != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool pesquisar(int x, Elemento inicio)
        {
            if (inicio == null)
            {
                return false;
            }
            else if(x == inicio.numero)
            {
                return true;
            }
            else
            {
                return (pesquisar(x, inicio.proximo));
            }
        }
        
        public void exibir()
        {
            Elemento aux = inicio;
            while (aux != null)
            {
                Console.WriteLine(aux.numero);
                aux = aux.proximo;
            }
        }

        public void exibir(Elemento el)
        {
            if (el != null)
            {
                Console.WriteLine(el.numero);
                exibir(el.proximo);
            }
        }

        public void esvaziar()
        {
            this.inicio = null;
            this.fim = null;
            tamanho = 0;
        }

        public bool testeVazia()
        {
            return (inicio == null);
        }

        public int maiorInicio(Elemento inicio,Elemento el, int cont)
        {
            if (el == null)
            {
                return cont;
            }
            else
            {
                if (el.numero > inicio.numero)
                {
                    return (maiorInicio(inicio, el.proximo, cont+1));
                }
                else
                {
                    return (maiorInicio(inicio, el.proximo, cont));
                }
            }
        }

        public int maiorInicio()
        {
            Elemento aux = inicio.proximo;
            int cont = 0;
            while (aux != null)
            {
                if (aux.numero > inicio.numero)
                {
                    cont++;
                }
                aux = aux.proximo;
            }
            return cont;
        }
        public int maiorFim(Elemento fim, Elemento el, int cont)
        {
            if (el == null)
            {
                return cont;
            }
            else
            {
                if (el.numero > fim.numero)
                {
                    return (maiorFim(fim, el.proximo, cont + 1));
                }
                else
                {
                    return (maiorFim(fim, el.proximo, cont));
                }
            }
        }
        public int maiorFim()
        {
            Elemento aux = inicio;
            int cont = 0;
            while (aux != null)
            {
                if (aux.numero > fim.numero)
                {
                    cont++;
                }
                aux = aux.proximo;
            }
            return cont;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
