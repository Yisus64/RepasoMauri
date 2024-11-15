using NUnit.Framework;
using Sanatorio;
using System;

namespace SanatorioTests
{

    public class Tests
    {
        Paciente pacienteSinSocial;
        ConObraSocial pacienteConSocial;
        Intervencion intervencion1;
        Intervencion intervencion2;
        AltaComplejidad altaComplejidad1;
        AltaComplejidad altaComplejidad2;
        Medico medicoCorazonDisp;
        Medico medicoPancreasDisp;
        Medico medicoCorazonNoDisp;
        Medico medicoPancreasNoDisp;

        [SetUp]
        public void Setup()
        {
            pacienteConSocial = new ConObraSocial("47135449", "Jesus Pedalino", "3416922620", "Swiss Medical", 0.5f);
            pacienteSinSocial = new Paciente("30965311", "Camilo Sodo", "3412299355");
            intervencion1 = new Intervencion(1, "Extraccion de tumor qsy", "Corazon");
            intervencion2 = new Intervencion(2, "Extraccion de pancreas qsy", "Pancreas");
            altaComplejidad1 = new AltaComplejidad(3, "Extraccion de tumor complejo qsy", "Corazon");
            altaComplejidad2 = new AltaComplejidad(4, "Extraccion de pancreas complejo qsy", "Pancreas");
            medicoCorazonDisp = new Medico("Mauri", "lol", "Corazon", true);
            medicoPancreasDisp = new Medico("Mauri", "lol", "Pancreas", true);
            medicoCorazonNoDisp = new Medico("Mauri", "lol", "Corazon", false);
            medicoPancreasNoDisp = new Medico("Mauri", "lol", "Pancreas", false);
        }

        [Test]
        public void Test1()
        {
            float valor = intervencion1.CalcularCosto(medicoCorazonDisp, pacienteSinSocial);
            Assert.That(valor, Is.EqualTo(10000));

        }

        [Test]
        public void Test2()
        {
            float valor = intervencion1.CalcularCosto(medicoCorazonDisp, pacienteConSocial);
            Assert.That(valor, Is.EqualTo(5000));

        }

        [Test]
        public void Test3()
        {
            float valor = altaComplejidad1.CalcularCosto(medicoCorazonDisp, pacienteSinSocial);
            Assert.That(valor, Is.EqualTo(25000));
        }

        [Test]
        public void Test4()
        {
            float valor = altaComplejidad1.CalcularCosto(medicoCorazonDisp, pacienteConSocial);
            Assert.That(valor, Is.EqualTo(12500));
        }

        [Test]
        public void Test5()
        {
            var ex = Assert.Throws<Exception>(() => altaComplejidad1.CalcularCosto(medicoCorazonNoDisp, pacienteConSocial));
            Assert.AreEqual("El medico no esta disponible", ex.Message);
        }
        [Test]
        public void Test6()
        {
            var ex = Assert.Throws<Exception>(() => intervencion1.CalcularCosto(medicoCorazonNoDisp, pacienteConSocial));
            Assert.AreEqual("El medico no esta disponible", ex.Message);
        }

        [Test]
        public void Test7()
        {
            var ex = Assert.Throws<Exception>(() => altaComplejidad1.CalcularCosto(medicoPancreasDisp, pacienteConSocial));
            Assert.AreEqual("El medico no es de la especialidad requerida", ex.Message);
        }

        [Test]
        public void Test8()
        {
            var ex = Assert.Throws<Exception>(() => intervencion1.CalcularCosto(medicoPancreasDisp, pacienteConSocial));
            Assert.AreEqual("El medico no es de la especialidad requerida", ex.Message);
        }
    }
}