using System;
namespace Verlag
{
    public class Buch
    {
        private string autor = "";
        private string titel = "";
        private int auflage = 0;

        public Buch(string autor, string titel)
        {
            this.autor = autor;
            this.titel = titel;
        }
        public Buch(string autor, string titel, int auflage)
        {
            if (auflage <= 0)
            {
                throw new ArgumentOutOfRangeException("Verlag darf nicht kleiner oder gleich Null sein");
            }
            else
            {
                this.auflage = auflage;
            }
            this.autor = autor;
            this.titel = titel;
        }

        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public int Auflage
        {
            get
            {
                return auflage;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Verlag darf nicht kleiner oder gleich Null sein");
                }
                else
                {
                    auflage = value;
                }
            }
        }
        public string Titel
        {
            get
            {
                return titel;
            }
        }

    }
}
