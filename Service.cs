using System;

namespace Kassasysteem
{
    internal class Service : Product
    {
        // Extra eigenschap specifiek voor Service
        public double ServiceDuration { get; set; }

        // Constructor die de constructor van Product aanroept met het 'base' sleutelwoord
        public Service(int id, string productName, string productDescription, double productPrice, int productQuantity, double serviceDuration)
            : base(id, productName, productDescription, productPrice, productQuantity)
        {
            ServiceDuration = serviceDuration;
        }

    }
}
