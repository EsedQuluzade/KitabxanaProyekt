namespace Kitabxanın_idarəetmə_sistemi.Exceptions
{
    internal class KitabTapilmadiException : Exception
    {
        public KitabTapilmadiException() : base("Belə  bir kitab yoxdur")
        {
        }

        public KitabTapilmadiException(string? message) : base(message)
        {
        }

        public KitabTapilmadiException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
