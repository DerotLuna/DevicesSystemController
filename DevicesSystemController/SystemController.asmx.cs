using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
using System.Threading;

namespace DevicesSystemController
{
    /// <summary>
    /// Descripción breve de SystemController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SystemController : System.Web.Services.WebService
    {
        private List<string> devices = new List<string>();
        private string route;
        private Thread workerThread;
        private string _value;

        public SystemController()
        {
        }

        [WebMethod]
        public string initialize_List(string route, string name, string action)
        {
            /*NAME TRABAJA COMO NOMBRE CUANDO VA A SER CREADO Y COMO ID PARA CUANDO VA A LEERSE, MODIFICARSE, ELIMINARSE*/
            this.route = route;
            Archives archive = new Archives(route);
            this.devices = archive.extraer_dispositivos();
            _value = null;

            if (action == "create")
            {
                try
                {/*
                    ThreadStart _delegate = new ThreadStart(() => create_Archive(route, name));
                    workerThread = new Thread(_delegate);
                    workerThread.Start();
                    workerThread.Join(); */
                    archive.crear(name, "Buenos dias", true, true, false);
                    _value = "CREADO";
                }
                catch { }
                workerThread.Abort();
                return _value;
            }
            else
            {
                try
                {
                    ThreadStart _delegate = new ThreadStart(() => device_Receiver(name, action));
                    workerThread = new Thread(_delegate);
                    workerThread.Start();
                    workerThread.Join();
                }
                catch { _value = "ERROR"; }
                workerThread.Abort();
                return _value;
            }
        }
        


        public void create_Archive(string route, string name)
        {
            try {
                Archives archive = new Archives(route);
                archive.crear(name, "Buenos dias", true, true, false);
            }

            catch (Exception e) { }
        }

        public void device_Receiver(string ID, string action)
        {
            Archives archive = new Archives(route);
            try
            {
                int counter_Exit = 0;
                while (counter_Exit < devices.Count)
                {
                    if (ID == devices[counter_Exit])
                    {
                        chek_Lock(ID, action, route);
                    }

                    counter_Exit++;
                }
            }
            catch (Exception e) { }
        }

        public void chek_Lock(string ID, string action, string route)
        {
            Archives archive = new Archives(route);
            bool status = archive.get_bool(ID, 3);

            if (status == true) /* Si no esta bloqueado, hago la accion que se requiere */
            {
                _value = device_Action(ID, action, route);
            }

            else /* Si no, hago un while infinito hasta que el dispotivo se libere */
            {
                bool exit = false;
                while (exit)
                {
                    Thread.Sleep(1);
                    if (status == true)
                        exit = true;  
                }
                _value = device_Action(ID, action, route);
            }
        }

        public string device_Action(string ID, string action, string route)
        {
            /*ACTION VA A LLEVAR:
             -READ QUE INDICA QUE EL ARCHIVO SERA LEIDO
             ---------------------------------------------
             -TEXTO QUE ES LO QUE SE VA A MODIFICAR
             */
            Archives archive = new Archives(route);
            bool operability = archive.get_bool(ID, 4), read = archive.get_bool(ID, 5);

            if (action == "read")
            {
                bool exit = false;
                while (!exit)
                {
                    Thread.Sleep(1);
                    if ((operability && read) || (operability))
                    {
                        archive.set_bool(ID, 5, true);
                        archive.set_bool(ID, 3, false);
                        exit = true;
                    }
                    else if (!operability)
                        return "DISPOSITIVO DESCONECTADO"; 
                }
                workerThread.Join();
                archive.set_bool(ID, 5, false);
                archive.set_bool(ID, 3, true);
                return archive.extraer_Contenido(ID);

            }
            else
            {
                while (true)
                {
                    if (operability)
                    {
                        return "MODIFICADO";
                    }
                    else if (!operability)
                        return "DISPOSITIVO DESCONECTADO";
                }
            }
        }


    }
}
