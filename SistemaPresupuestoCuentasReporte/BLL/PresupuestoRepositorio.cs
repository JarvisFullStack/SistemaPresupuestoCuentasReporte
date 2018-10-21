using SistemaPresupuestoCuentasReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPresupuestoCuentasReporte.BLL
{
    public class PresupuestoRepositorio : RepositorioBase<Presupuesto>
    {
        public PresupuestoRepositorio() : base()
        {

        }

        public override bool Guardar(Presupuesto entity)
        {
            bool paso = false;
            try
            {
                entity.Monto = 0.0;
                foreach(var item in entity.Cuentas)
                {
                    entity.Monto += item.Monto;
                }

                if(_contexto.Set<Presupuesto>().Add(entity) != null)
                {
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }

            return paso;
        }

        public override bool Modificar(Presupuesto entity)
        {
            _contexto = new DAL.Contexto();
            bool paso = false;
            entity.Monto = 0.0;
            try
            {
                
                entity.Cuentas.Count();
                

                //ciclo para eliminar los que no existian en el anterior
                var cuentasAnterior = _contexto.Cuenta.Where(c => c.Id == entity.Id).AsNoTracking().ToList();
                cuentasAnterior.Count();
                if(entity.Cuentas.Count() < cuentasAnterior.Count())
                {
                    foreach(var item in cuentasAnterior)
                    {
                        if (!entity.Cuentas.Exists(c => c.Id.Equals(item.Id)))
                        {
                            _contexto.Entry(item).State = EntityState.Deleted;
                        }
                    }
                }

                
                //ciclo para añadir o modificar presupuestos
                foreach (var item in entity.Cuentas)
                {
                    var estado = (item.Id == 0) ? EntityState.Added : EntityState.Modified;
                    entity.Monto += item.Monto;
                    _contexto.Entry(item).State = estado;

                }
                

                _contexto.Entry(entity).State = EntityState.Modified;

                paso = _contexto.SaveChanges() > 0;
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return paso;


        }

        public override Presupuesto Buscar(int id)
        {
            Presupuesto presupuesto = null;
            try
            {
                presupuesto = _contexto.Set<Presupuesto>().Find(id);
                presupuesto.Cuentas.Count();
                
                    
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }

            return presupuesto;
        }
    }
}
