using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DevicesSystemController
{
    class Archives {
        private string route;

        public Archives(string route)
        {
            this.route = route;
        }

        public void crear(string device, string contenido, bool  candado, bool operatividad, bool read)
        {
            
            int contador = verifica(device);
            string id = device + contador; /*Creo la id conel dispositivo y el contador*/
            TextWriter archivo = new StreamWriter(route+"\\"+id+".txt");
            archivo.WriteLine(id);
            if(contador!=1)
                inserta_device(id); /*Llamo para guardar en la lista de dispositivos con su id*/
            archivo.WriteLine(device);
            archivo.WriteLine(candado);
            archivo.WriteLine(operatividad);
            archivo.WriteLine(read);
            archivo.WriteLine(contenido);
            archivo.Close();
        }
        public int verifica(string device)/*Verifica la existencia de la carpeta dispositivos*/
        {
            if (File.Exists(route + "\\" + "dispositivos.txt"))
            {
                int contador  = dispositivos();
                return (contador);
            }
            else
            {
                TextWriter archivo = new StreamWriter(route + "\\" + "dispositivos.txt");
                archivo.WriteLine(device+"1");
                archivo.Close();
                int contador = 1;
                return (contador);
            }

        }
        public int dispositivos()
        {
            string contenido;
            int contador = 1;
            TextReader lectura = new StreamReader(route + "\\" + "dispositivos.txt");
            while ((contenido = lectura.ReadLine()) != null)
            {
                contador++;
            }
            lectura.Close();
            return contador;
        }
        public void inserta_device(string id)
        {
            StreamWriter archivo = File.AppendText(route + "\\" + "dispositivos.txt");
            archivo.WriteLine(id);
            archivo.Close();
        }
        public bool get_bool(string id, int pedido)
        {
            StreamReader lectura = File.OpenText(route + "\\" + id + ".txt");
            string linea = null;
            bool entrega;
            int i = 0;
            while (!lectura.EndOfStream)
            {

                linea = lectura.ReadLine();
                if (++i == pedido) { entrega = Convert.ToBoolean(linea); lectura.Close(); return (entrega); } ;
            }
            return (false);
        }

        public void set_bool(string id, int pedido, bool estatus)
        {
            /*3 = candado, 4 = operatividad, 5 = read*/
            StreamReader lectura = File.OpenText(route + "\\" + id + ".txt");
            string id_ = lectura.ReadLine();
            string device_ = lectura.ReadLine();
            bool candado_ = Convert.ToBoolean(lectura.ReadLine());
            bool operatividad_ = Convert.ToBoolean(lectura.ReadLine());
            bool read_ = Convert.ToBoolean(lectura.ReadLine());
            string contenido_ = lectura.ReadLine();
            lectura.Close();
            if (pedido == 3) { candado_ = estatus; }
            else if (pedido == 4) { operatividad_ = estatus; }
            else if (pedido == 5) { read_ = estatus; }
            TextWriter archivo = new StreamWriter(route + "\\" + id + ".txt");
            archivo.WriteLine(id_);
            archivo.WriteLine(device_);
            archivo.WriteLine(candado_);
            archivo.WriteLine(operatividad_);
            archivo.WriteLine(read_);
            archivo.WriteLine(contenido_);
            archivo.Close();
        }
        public void delete(string id)
        {
            File.Delete(route + "\\" + id + ".txt"); /*Elimino archivo*/
            List<string> auxiliar = new List<string>();
            StreamReader lectura = File.OpenText(route + "\\" + "dispositivos.txt");
            string linea = null;
            int count1 = 0;
            while (!lectura.EndOfStream)
            {
                linea = lectura.ReadLine();
                if (linea != id) { auxiliar.Add(linea); }
            }
            lectura.Close();
            TextWriter archivo = new StreamWriter(route + "\\" + "dispositivos.txt");
            while (count1 < auxiliar.Count())
            {
                archivo.WriteLine(auxiliar[count1]);
                count1++;
            }
            archivo.Close();
        }
        public List<string> extraer_dispositivos()
        {
            List<string> auxiliar = new List<string>();
            StreamReader lectura = File.OpenText(route + "\\" + "dispositivos.txt");
            string linea = null;
            while (!lectura.EndOfStream)
            {
                linea = lectura.ReadLine();
                auxiliar.Add(linea); 
            }
            lectura.Close();
            return auxiliar;
        }

        public string extraer_Contenido(string ID)
        {
            StreamReader reading = File.OpenText(route + "\\" + ID + ".txt");
            string line = "";
            sbyte counter = 1;
            while (!reading.EndOfStream)
            {
                if (counter > 5)
                {
                    line = line + reading.ReadLine();
                }
                reading.ReadLine();
                counter++;
            }
            reading.Close();
            return line;
        }

    }
}
