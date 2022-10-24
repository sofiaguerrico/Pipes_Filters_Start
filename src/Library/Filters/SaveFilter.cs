using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna su negativo.
    /// </remarks>
    public class SaveFilter : IFilter
    {
        /// Un filtro que retorna el negativo de la imagen recibida.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida pero en negativo.</returns>
        public string etiqueta{set;get;}
        public SaveFilter(string nom){
            this.etiqueta=nom;
        }
        public IPicture Filter(IPicture image){
            IPicture result = image.Clone();
            PictureProvider provider = new PictureProvider();
            provider.SavePicture(result, $@"{this.etiqueta}.jpg");
            return result;
        }
    }
}
