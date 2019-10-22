using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_en_clases1.NewFolder
{
    class Nota
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private float actividadesp1;

        public float ActividadesP1
        {
            get { return actividadesp1; }
            set { actividadesp1 = value; }
        }
        private float practicasp1;

        public float PracticasP1
        {
            get { return practicasp1; }
            set { practicasp1 = value; }
        }

        private float trabajosautonomosp1;

        public float TrabajosautonomosP1
        {
            get { return trabajosautonomosp1; }
            set { trabajosautonomosp1 = value; }
        }
        private float evaluacionfinalp1;

        public float EVALUACIONFINALP1
        {
            get { return evaluacionfinalp1; }
            set { evaluacionfinalp1 = value; }
        }

        public float PRIMERPARCIALp1
        {
            get { return ActividadesP1 * 0.25f + PracticasP1 * 0.25f + TrabajosautonomosP1 * 0.20f + EVALUACIONFINALP1 * 0.30f; }
        }
        private float actividadesp2;

        public float ACTIVIDADESP2
        {
            get { return actividadesp2; }
            set { actividadesp2 = value; }
        }
        private float practicasp2;

        public float PRACTICASP2
        {
            get { return practicasp2; }
            set { practicasp2 = value; }
        }

        private float trabajosautonomosp2;

        public float TRABAJOSAUTONOMOP2
        {
            get { return trabajosautonomosp2; }
            set { trabajosautonomosp2 = value; }
        }
        private float evaluacionfinalp2;

        public float EVALUACIONFINALP2
        {
            get { return evaluacionfinalp2; }
            set { evaluacionfinalp2 = value; }
        }
        public float SEGUNDOPARCIALP2
        {
            get { return ACTIVIDADESP2 * 0.25f + PRACTICASP2 * 0.25f + TRABAJOSAUTONOMOP2 * 0.20f + EVALUACIONFINALP2 * 0.30f; }
        }


        public float Suma
        {
            get { return PRIMERPARCIALp1 + SEGUNDOPARCIALP2; }

        }
        private float recuperacion;


        public float Recuperacion
        {
            get
            {
                if (Suma >= 14)
                {
                    return 0;
                }
                return recuperacion;
            }
            set
            {

                recuperacion = value;
            }
        }


        public float SUMA2
        {
            get { return (Suma + Recuperacion); }
        }


        public float FINAL
        {
            get { return SUMA2 / 2; }

        }


        public String ESTADO
        {
            get
            {
                if (SUMA2 >= 14)
                {
                    return "Aprobado";
                }
                else
                {
                    return "Reprobado";
                }

            }

        }

    }

}