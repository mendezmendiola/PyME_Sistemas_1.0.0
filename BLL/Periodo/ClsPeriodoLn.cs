using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Periodo;
using DAL.DataBase;
using System.Globalization;


namespace BLL.Periodo
{
    public class ClsPeriodoLn
    {
        #region Variables Privadas
        private ClsDataBase objDatBase = null;
        #endregion

        #region Metodo Index
        public void Index(ref ClsPeriodo ObjPeriodo)
        {
            objDatBase = new ClsDataBase()
            {
                NombreTabla = "TBPeriodo",
                NombreSP = "[PMS].[SP_Periodo_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjPeriodo);
        }
        #endregion

        #region CRUD Periodo

        public void Create(ref ClsPeriodo ObjPeriodo)
        {
            objDatBase = new ClsDataBase()
            {
                NombreTabla = "TBPeriodo",
                NombreSP = "[PMS].[SP_Periodo_Create]",
                Scalar = true
            };
            objDatBase.DtParametros.Rows.Add(@"@Periodo", 17, ObjPeriodo.Periodo);
            //objDatBase.DtParametros.Rows.Add(@"@FechaInicioPeriodo", 13, ObjPeriodo.FechaInicioPeriodo);
            //objDatBase.DtParametros.Rows.Add(@"@FechaFinalPeriodo", 13, ObjPeriodo.FechaFinalPeriodo);
            //objDatBase.DtParametros.Rows.Add(@"@EstadoPeriodo", 17, ObjPeriodo.EstadoPeriodo);
            //objDatBase.DtParametros.Rows.Add(@"@FechaInicioContabilidad", 13, ObjPeriodo.FechaInicioContabilidad);
            //objDatBase.DtParametros.Rows.Add(@"@FechaInicioVencimiento", 13, ObjPeriodo.FechaInicioVencimiento);
            //objDatBase.DtParametros.Rows.Add(@"@FechaFinalContabilidad", 13, ObjPeriodo.FechaFinalContabilidad);
            //objDatBase.DtParametros.Rows.Add(@"@FechaFinalVencimiento", 13, ObjPeriodo.FechaFinalVencimiento);
            //objDatBase.DtParametros.Rows.Add(@"@FechaCreacion", 13, ObjPeriodo);

            Ejecutar(ref ObjPeriodo);
        }

        public void Read(ref ClsPeriodo ObjPeriodo)
        {
            objDatBase = new ClsDataBase()
            {
                NombreTabla = "TBPeriodo",
                NombreSP = "[PMS].[SP_Periodo_Read]",
                Scalar = false
            };
            objDatBase.DtParametros.Rows.Add(@"@IDPeriodo", 4, ObjPeriodo.IDPeriodo);

            Ejecutar(ref ObjPeriodo);
        }

        public void Update(ref ClsPeriodo ObjPeriodo)
        {
            objDatBase = new ClsDataBase()
            {
                NombreTabla = "TBPeriodo",
                NombreSP = "[PMS].[SP_Periodo_Update]",
                Scalar = true
            };
            objDatBase.DtParametros.Rows.Add(@"@IDPeriodo", 4, ObjPeriodo.IDPeriodo);
            objDatBase.DtParametros.Rows.Add(@"@Periodo", 17, ObjPeriodo.Periodo);
            objDatBase.DtParametros.Rows.Add(@"@FechaInicioPeriodo", 13, ObjPeriodo.FechaInicioPeriodo);
            objDatBase.DtParametros.Rows.Add(@"@FechaFinalPeriodo", 13, ObjPeriodo.FechaFinalPeriodo);
            objDatBase.DtParametros.Rows.Add(@"@EstadoPeriodo", 17, ObjPeriodo.EstadoPeriodo);
            objDatBase.DtParametros.Rows.Add(@"@FechaInicioContabilidad", 13, ObjPeriodo.FechaInicioContabilidad);
            objDatBase.DtParametros.Rows.Add(@"@FechaInicioVencimiento", 13, ObjPeriodo.FechaInicioVencimiento);
            objDatBase.DtParametros.Rows.Add(@"@FechaFinalContabilidad", 13, ObjPeriodo.FechaFinalContabilidad);
            objDatBase.DtParametros.Rows.Add(@"@FechaFinalVencimiento", 13, ObjPeriodo.FechaFinalVencimiento);
            objDatBase.DtParametros.Rows.Add(@"@FechaCreacion", 13, ObjPeriodo.FechaCreacion);

            Ejecutar(ref ObjPeriodo);
        }

        public void Delete(ref ClsPeriodo ObjPeriodo)
        {
            objDatBase = new ClsDataBase()
            {
                NombreTabla = "TBPeriodo",
                NombreSP = "[PMS].[SP_Periodo_Delete]",
                Scalar = true
            };
            objDatBase.DtParametros.Rows.Add(@"@IDPeriodo", 4, ObjPeriodo.IDPeriodo);
            Ejecutar(ref ObjPeriodo);
        }
        
        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsPeriodo ObjPerido)
        {
            objDatBase.CRUD(ref objDatBase);
            if (objDatBase.MensajeErrorDB == null)
            {
                if (objDatBase.Scalar)
                {
                    ObjPerido.ValorScalar = objDatBase.ValorScalar;
                }
                else
                {
                    ObjPerido.DtResultados = objDatBase.DsResultados.Tables[0];
                    if (ObjPerido.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjPerido.DtResultados.Rows)
                        {
                            //ObjPerido.IDPeriodo = Convert.ToInt32(item["IDPeriodo"].ToString());
                            //String dateTime  = item["FechaInicioPeriodo"].ToString();
                            //DateTime X = DateTime.Parse(item["FechaInicioPeriodo"].ToString(), CultureInfo.InvariantCulture);                            //ObjPerido.FechaInicioPeriodo = dateTime;

                            //ObjPerido.FechaInicioPeriodo = Convert.ToDateTime(item["FechaInicioPeriodo"].ToString());
                            //ObjPerido.FechaFinalPeriodo = Convert.ToDateTime(item["FechaFinalPeriodo"].ToString());
                            ObjPerido.Periodo = item["Periodo"].ToString();
                            //ObjPerido.EstadoPeriodo = item["EstadoPeriodo"].ToString();
                            //ObjPerido.FechaInicioContabilidad = Convert.ToDateTime(item["FechaInicioContabilidad"].ToString());
                            //ObjPerido.FechaInicioVencimiento = Convert.ToDateTime(item["FechaInicioVencimiento"].ToString());
                            //ObjPerido.FechaFinalContabilidad = Convert.ToDateTime(item["FechaFinalContabilidad"].ToString());
                            //ObjPerido.FechaFinalVencimiento = Convert.ToDateTime(item["FechaFinalVencimiento"].ToString());
                            //ObjPerido.FechaCreacion = Convert.ToDateTime(item["FechaCreacion"].ToString());

                        }
                    }
                }
            }
            else
            {
                ObjPerido.MensajeError = objDatBase.MensajeErrorDB;
            }
        }
        #endregion
    }
}
