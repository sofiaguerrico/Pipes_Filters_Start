using System;
using System.Drawing;
using CognitiveCoreUCU;
namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna su negativo.
    /// </remarks>
    public class FilterConditional : IFilter
    {
        /// Un filtro que retorna el negativo de la imagen recibida.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida pero en negativo.</returns>
        
        public IPicture Filter(IPicture image){
            IPicture result = image.Clone();
            CognitiveFace cog = new CognitiveFace(false);
            cog.Recognize(@"result");
            FoundFace(cog);
            
            return result;
        }

        static void FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
            }
            else
                Console.WriteLine("No Face Found");
        }
    }
}
