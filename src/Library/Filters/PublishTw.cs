using System;
using System.Drawing;
using TwitterUCU;
namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna su negativo.
    /// </remarks>
    public class PublishTw : IFilter
    {
        /// Un filtro que retorna el negativo de la imagen recibida.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida pero en negativo.</returns>
        public string descripcion {set;get;}
        public PublishTw(string nom){
            this.descripcion=nom;
        }
        public IPicture Filter(IPicture image){
            var twitter = new TwitterImage();
            IPicture result = image.Clone();
            Console.WriteLine(twitter.PublishToTwitter($"{this.descripcion}", @"result"));
            return result;
        }
    }
}
