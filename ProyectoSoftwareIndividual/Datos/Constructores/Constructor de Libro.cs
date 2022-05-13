using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Constructores
{
    public class ConstructorDeLibro
    {
        public void CreacionLibro(string _ISBN, string _Titulo, string _Autor, string _Editorial, string _Edicion, int _Stock, string _Imagen)
        {
            using (var context = new ProyectoSoftwareLibreriaContext())
            {
                var std = new Libros()
                {
                    ISBN = _ISBN,
                    Titulo = _Titulo,
                    Autor = _Autor,
                    Editorial = _Editorial,
                    Edicion = _Edicion,
                    Stock = _Stock,
                    Imagen = _Imagen
                };
                context.Libros.Add(std);

                context.SaveChanges();
            }
        }

        public void InicializacionDeLibros()
        {
            using (var context = new ProyectoSoftwareLibreriaContext())
            {
                var libro1 = new Libros()
                {
                    ISBN = "9781947783744",
                    Titulo = "Jurassic Park",
                    Autor = "Michael Crichton",
                    Editorial = "Debolsillo",
                    Edicion = "2018",
                    Stock = 20,
                    Imagen = "https://images.cdn3.buscalibre.com/fit-in/360x360/28/55/28553533d8503c62793e6519e92019d7.jpg"
                };
                context.Libros.Add(libro1);

                var libro2 = new Libros()
                {
                    ISBN = "9789877802894",
                    Titulo = "Roma soy yo",
                    Autor = "Santiago Posteguillo",
                    Editorial = "Ediciones B",
                    Edicion = "2022",
                    Stock = 0,
                    Imagen = "https://images.cdn1.buscalibre.com/fit-in/360x360/4c/a1/4ca11d981c8758968afffbf52d28e540.jpg"
                };
                context.Libros.Add(libro2);

                var libro3 = new Libros()
                {
                    ISBN = "9788420684734",
                    Titulo = "El Halcón Maltés",
                    Autor = "Dashiell Hammett",
                    Editorial = "Alianza",
                    Edicion = "2014",
                    Stock = 1,
                    Imagen = "https://images.cdn1.buscalibre.com/fit-in/360x360/7e/d1/7ed1fbef6ff94ab7eb90c7900f269610.jpg"
                };
                context.Libros.Add(libro3);

                var libro4 = new Libros()
                {
                    ISBN = "9789872143145",
                    Titulo = "1984",
                    Autor = "Orwell, George",
                    Editorial = "Arenal",
                    Edicion = "2012",
                    Stock = 5,
                    Imagen = "https://images.cdn2.buscalibre.com/fit-in/360x360/fd/44/fd44e3c32998c4d8ab38ff6c48caa1ba.jpg"
                };
                context.Libros.Add(libro4);

                var libro5 = new Libros()
                {
                    ISBN = "9789875661196",
                    Titulo = "Fahrenheit 451",
                    Autor = "Ray Bradbury",
                    Editorial = "Debolsillo",
                    Edicion = "2005",
                    Stock = 5,
                    Imagen = "https://images.cdn1.buscalibre.com/fit-in/360x360/b8/46/b8461454fb69c7ed1c89787e6a3343dd.jpg"
                };
                context.Libros.Add(libro5);

                var libro6 = new Libros()
                {
                    ISBN = "9789875730021",
                    Titulo = "Octubre, un Crimen",
                    Autor = "Huidobro Norma",
                    Editorial = "Sm",
                    Edicion = "2005",
                    Stock = 10,
                    Imagen = "https://images.cdn3.buscalibre.com/fit-in/360x360/69/eb/69ebd9fb55e07a519f8828eca41d7feb.jpg"
                };
                context.Libros.Add(libro6);

                var libro7 = new Libros()
                {
                    ISBN = "9789875040731",
                    Titulo = "El Fantasma de Canterville",
                    Autor = "Oscar Wilde",
                    Editorial = "Quipu",
                    Edicion = "2013",
                    Stock = 5,
                    Imagen = "https://images.cdn1.buscalibre.com/fit-in/360x360/4c/d6/4cd68a988e0c6b73a0cc9bbe5edf66a8.jpg"
                };
                context.Libros.Add(libro7);

                var libro8 = new Libros()
                {
                    ISBN = "9789875507784",
                    Titulo = "El Extrano Caso del dr. Jekyll y mr. Hyde",
                    Autor = "Robert Louis Stevenson",
                    Editorial = "Longseller S.A.",
                    Edicion = "2008",
                    Stock = 1,
                    Imagen = "https://images.cdn1.buscalibre.com/fit-in/360x360/b8/35/b83536af56c934e91ff88bc24c4379c2.jpg"
                };
                context.Libros.Add(libro8);

                var libro9 = new Libros()
                {
                    ISBN = "9789500515368",
                    Titulo = "La Nona",
                    Autor = "Roberto Cossa",
                    Editorial = "Corregidor",
                    Edicion = "2004",
                    Stock = 30,
                    Imagen = "https://images.cdn2.buscalibre.com/fit-in/360x360/7b/47/7b477cabccfb6f728f8c773ea2cfea62.jpg"
                };
                context.Libros.Add(libro9);

                var libro10 = new Libros()
                {
                    ISBN = "9789563162486",
                    Titulo = "El Corazon Delator",
                    Autor = "Edgar Allan Poe",
                    Editorial = "Origo Ediciones",
                    Edicion = "2016",
                    Stock = 2,
                    Imagen = "https://images.cdn2.buscalibre.com/fit-in/360x360/aa/66/aa66a5c34a918856ac3b1c9f7dc9184c.jpg"
                };
                context.Libros.Add(libro10);
                context.SaveChanges();
            }
        }
    }
}
