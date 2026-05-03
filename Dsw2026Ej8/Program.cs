using Dsw2026Ej8.Problema1;
using Dsw2026Ej8.Problema2;
using Dsw2026Ej8.Problema3;
using Dsw2026Ej8.Problema4;
using Dsw2026Ej8.Problema5;
using Dsw2026Ej8.Problema6;

// Problema 1
var helper = new ProductHelper();
Console.WriteLine(helper.ObtenerEtiquetaProducto(123, "Coca Cola", 1500.50m));

// Problema 2
var p2 = new Problema2();
Console.WriteLine(p2.CrearResumenVenta(1, "Mesa", 3, 200m));

// Problema 3
var producto = new Product("Original");
var p3 = new Problema3();
Console.WriteLine(p3.CompararCopias(5, producto));

// Problema 4
var p4 = new Problema4();
Console.WriteLine(p4.CalcularPromedio(8, null, 6));

// Problema 5
var p5 = new Problema5();

Console.WriteLine(p5.ObtenerImporteFinal(new RetailSale(1000m)));
Console.WriteLine(p5.ObtenerImporteFinal(new WholesaleSale(1000m)));

Console.WriteLine($"{p5.ObtenerImporteFinal(new RetailSale(1000m))} - {p5.ObtenerImporteFinal(new WholesaleSale(1000m))}");


// Problema 6
var p6 = new Problema6();
Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x "));
