using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaPresupuestoCuentasReporte.BLL;
using SistemaPresupuestoCuentasReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPresupuestoCuentasReporte.BLL.Tests
{
    [TestClass()]
    public class PresupuestoRepositorioTests
    {
        [TestMethod()]
        public void PresupuestoRepositorioTest()
        {
            
        }

        [TestMethod()]
        public void ModificarTest()
        {
            PresupuestoRepositorio repositorio = new PresupuestoRepositorio();
            Presupuesto presupuesto = null;
            presupuesto = repositorio.Buscar(1);
            for (int i = 0; i < presupuesto.Cuentas.Count; i++)
            {
                Cuenta item = presupuesto.Cuentas[i];
                item.Monto += 1000;
            }

            Assert.IsTrue(repositorio.Modificar(presupuesto));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Guardar()
        {
            PresupuestoRepositorio repositorio = new PresupuestoRepositorio();
            List<Cuenta> lista = new List<Cuenta>();
            lista = new RepositorioBase<Cuenta>().GetList(x => true);
            Presupuesto presupuesto = new Presupuesto()
            {

                Cuentas = lista,
                Descripcion = "Cuenta Ahorros",


            };
            bool paso = repositorio.Guardar(presupuesto);
            repositorio.Dispose();
            Assert.IsTrue(paso);
           

            
        }

        [TestMethod]
        public void mostrarPresupuesto()
        {
            PresupuestoRepositorio repositorio = new PresupuestoRepositorio();
            Presupuesto presupuesto = null;
            presupuesto = repositorio.Buscar(1);
            MessageBox.Show("Monto: "+presupuesto.Monto);
            Assert.IsTrue(presupuesto!=null);
        }



        [TestMethod()]
        public void CrearTipos()
        {
            RepositorioBase<TipoCuenta> repositorio = new RepositorioBase<TipoCuenta>();
            TipoCuenta c1 = new TipoCuenta()
            {
            
                Descripcion = "Cuenta Personal"
                
            };
            TipoCuenta c2 = new TipoCuenta()
            {

                Descripcion = "Cuenta De Ahorros"

            };
            List<TipoCuenta> lista = new List<TipoCuenta>();
            lista.Add(c1);
            lista.Add(c2);
            bool paso = true;
            foreach(TipoCuenta item in lista)
            {
                if (!repositorio.Guardar(item))
                {
                    paso = false;
                }
            }

            Assert.IsTrue(paso);


        }

        [TestMethod()]
        public void CrearCuentas()
        {
            RepositorioBase<Cuenta> repositorio = new RepositorioBase<Cuenta>();
            bool paso = true;
            Cuenta c1 = new Cuenta()
            {
                Descripcion = "Cuenta1",
                Monto = 20000.00,
                TipoId = 1
            };

            Cuenta c2 = new Cuenta()
            {
                Descripcion = "Cuenta2",
                Monto = 33000.00,
                TipoId = 2


            };

            Cuenta c3 = new Cuenta()
            {
                Descripcion = "Cuenta3",
                Monto = 44000.00,
                TipoId = 1


            };

            List<Cuenta> lista = new List<Cuenta>();
            lista.Add(c1);
            lista.Add(c2);
            lista.Add(c3);

            foreach(Cuenta item in lista){
                if (!repositorio.Guardar(item))
                {
                    paso = false;
                }
            }

            Assert.IsTrue(paso);

        }
    }
}