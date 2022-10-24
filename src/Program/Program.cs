using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using TwitterUCU;
using CognitiveCoreUCU;
namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            //Parte 1
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");
            var twitter = new TwitterImage();
            PipeNull pipenull=new PipeNull();
            FilterNegative filtroNeg = new FilterNegative();
            PipeSerial pipe= new PipeSerial(filtroNeg, pipenull);
            provider.SavePicture(pipe.Send(picture), @"beerNeg.jpg");
            Console.WriteLine(twitter.PublishToTwitter($"hola", @"beerNeg.jpg"));
            FilterGreyscale filtroGris =new FilterGreyscale();
            PipeSerial pipe2= new PipeSerial(filtroGris, pipe);
            provider.SavePicture(pipe2.Send(picture), @"beerGray.jpg");
*/
/*
            //PARTE 2
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");

            PipeNull pipenull=new PipeNull();
            FilterNegative filtroNeg = new FilterNegative();
            SaveFilter guardar=new SaveFilter();
            
            PipeSerial pipe= new PipeSerial(guardar, pipenull);
            PipeSerial pipe2= new PipeSerial(filtroNeg, pipe);

            FilterGreyscale filtroGris =new FilterGreyscale();
            PipeSerial pipe3= new PipeSerial(guardar, pipe2);
            PipeSerial pipe4= new PipeSerial(filtroGris, pipe3);
            pipe4.Send(picture);

            */
            /*
            //PARTE 3
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
            var twitter = new TwitterImage();
            
            FilterNegative filtroNeg = new FilterNegative();
            FilterGreyscale filtroGris =new FilterGreyscale();
            SaveFilter guardar=new SaveFilter("hola");
            SaveFilter guardar2=new SaveFilter("chau");
            PublishTw tw= new PublishTw("nueva img");
            PublishTw tw2= new PublishTw("hola img");

            PipeNull pipenull=new PipeNull();
            PipeSerial pipe= new PipeSerial(tw, pipenull);
           // Console.WriteLine(twitter.PublishToTwitter($"hola", @"luke.jpg"));
            PipeSerial pipe2= new PipeSerial(guardar, pipe);
            PipeSerial pipe3= new PipeSerial(filtroNeg, pipe2);
            pipe3.Send(picture);

            PipeSerial pipe4= new PipeSerial(tw2, pipe3);
            PipeSerial pipe5= new PipeSerial(guardar2, pipe4);
            PipeSerial pipe6= new PipeSerial(filtroGris, pipe5);

            pipe6.Send(picture);
            //provider.SavePicture(pipe2.Send(picture), @"beerGray.jpg");*/


            //Parte 4
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");
            var twitter = new TwitterImage();
            
            FilterNegative filtroNeg = new FilterNegative();
            FilterGreyscale filtroGris =new FilterGreyscale();
            SaveFilter guardar=new SaveFilter("hola");
            SaveFilter guardar2=new SaveFilter("chau");
            PublishTw tw= new PublishTw("nueva img");
            PublishTw tw2= new PublishTw("hola img");
            FilterConditional condicional=new FilterConditional();

            PipeNull pipenull=new PipeNull();
            PipeSerial pipe= new PipeSerial(tw, pipenull);
            PipeSerial pipeCARA= new PipeSerial(condicional, pipe);
            PipeSerial pipe2= new PipeSerial(guardar, pipeCARA);
            PipeSerial pipe3= new PipeSerial(filtroNeg, pipe2);
            pipe3.Send(picture);

            PipeSerial pipe4= new PipeSerial(tw2, pipe3);
            PipeSerial pipe5= new PipeSerial(guardar2, pipe4);
            PipeSerial pipe6= new PipeSerial(filtroGris, pipe5);

            pipe6.Send(picture);
            //provider.SavePicture(pipe2.Send(picture), @"beerGray.jpg");
        }
    }
}
