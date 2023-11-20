using System;
namespace Verlag
{
    public class Buch
    {
        private string autor = "";
        private string titel = "";
        private string isbn = "";
        private string isbn10 = "";
        private string isbn10OhneTrim = "";
        private string isbnOhneTrim = "";
        private int auflage = 1;

        public Buch(string autor, string titel)
        {
            this.autor = autor;
            this.titel = titel;
        }

        public Buch(string autor, string titel, int auflage)
        {
            this.autor = autor;
            this.titel = titel;
            if (auflage <= 0)
            {
                throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner oder gleich Null sein");
            }
            else
            {
                this.auflage = auflage;
            }
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


        public string Titel
        {
            get
            {
                return titel;
            }
            set
            {
                titel = value;
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


        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbnOhneTrim = value;
                string isbnMitTrim = value.Trim(new char[] { ' ', '-' });

                switch (isbnMitTrim.Length)
                {
                    case 13:
                        isbn = isbnMitTrim;
                        break;
                    case 12:
                        isbn = isbnMitTrim + "9";
                        break;
                    case < 12:
                        throw new Exception("Kein gültiger ISBN13");
                }
            }
        }


        public string ISBN10
        {
            get
            {
                isbn10 = isbn.Remove(0, 3);
                return isbn10;
            }
            set
            {
                isbn10OhneTrim = value;
                string isbn10MitTrim = value.Trim(new char[] { ' ', '-' });
                switch (isbn10MitTrim.Length)
                {
                    case 10:
                        isbn10 = isbn10MitTrim;
                        break;
                    case > 10:
                        throw new Exception("Keine Gültige ISBN10");
                    case < 10:
                        throw new Exception("Keine Gültige ISBN10");
                }
            }
        }

    }
}
