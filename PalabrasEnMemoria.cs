namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly Dictionary<string, List<string>> _palabrasPorCategoria = new()
        {
            { "Arquitectura", new List<string>
                {
                    "arquitectura", "componente", "descomposicion",
                    "dependencia", "acoplamiento"
                }
            },
            { "POO", new List<string>
                {
                    "polimorfismo", "encapsulamiento", "herencia",
                    "abstraccion", "clase"
                }
            },
            { ".NET", new List<string>
                {
                    "ensamblado", "namespace", "interfaz",
                    "delegado", "middleware"
                }
            }
        };

        private string _categoriaSeleccionada;

        public void EstablecerCategoria(string categoria)
        {
            if (_palabrasPorCategoria.ContainsKey(categoria))
            {
                _categoriaSeleccionada = categoria;
            }
        }

        public string ObtenerPalabraAleatoria()
        {
            if (string.IsNullOrEmpty(_categoriaSeleccionada))
            {
                _categoriaSeleccionada = "POO"; // Categoría por defecto
            }

            var palabras = _palabrasPorCategoria[_categoriaSeleccionada];
            var random = new Random();
            return palabras[random.Next(palabras.Count)];
        }

        public List<string> ObtenerCategorias()
        {
            return new List<string>(_palabrasPorCategoria.Keys);
        }
    }
}