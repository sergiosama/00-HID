using System;

namespace Entidades
{
    public class enTObraSocial
    {
        #region Fields

        private int idObraSocial;
        private string mnemonico;
        private string obraSocial;
        private string direccion;
        private int idcodloc;
        private int idTipoIVA;
        private string cUIT;
        private string telefono;
        private string observaciones;
        private int idTipoFactura;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the enTObraSocial class.
        /// </summary>
        public enTObraSocial()
        {
        }

        /// <summary>
        /// Initializes a new instance of the enTObraSocial class.
        /// </summary>
        public enTObraSocial(string mnemonico, string obraSocial, string direccion, int idcodloc, int idTipoIVA, string cUIT, string telefono, string observaciones, int idTipoFactura)
        {
            this.mnemonico = mnemonico;
            this.obraSocial = obraSocial;
            this.direccion = direccion;
            this.idcodloc = idcodloc;
            this.idTipoIVA = idTipoIVA;
            this.cUIT = cUIT;
            this.telefono = telefono;
            this.observaciones = observaciones;
            this.idTipoFactura = idTipoFactura;
        }

        /// <summary>
        /// Initializes a new instance of the enTObraSocial class.
        /// </summary>
        public enTObraSocial(int idObraSocial, string mnemonico, string obraSocial, string direccion, int idcodloc, int idTipoIVA, string cUIT, string telefono, string observaciones, int idTipoFactura)
        {
            this.idObraSocial = idObraSocial;
            this.mnemonico = mnemonico;
            this.obraSocial = obraSocial;
            this.direccion = direccion;
            this.idcodloc = idcodloc;
            this.idTipoIVA = idTipoIVA;
            this.cUIT = cUIT;
            this.telefono = telefono;
            this.observaciones = observaciones;
            this.idTipoFactura = idTipoFactura;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the IdObraSocial value.
        /// </summary>
        public virtual int IdObraSocial
        {
            get { return idObraSocial; }
            set { idObraSocial = value; }
        }

        /// <summary>
        /// Gets or sets the Mnemonico value.
        /// </summary>
        public virtual string Mnemonico
        {
            get { return mnemonico; }
            set { mnemonico = value; }
        }

        /// <summary>
        /// Gets or sets the ObraSocial value.
        /// </summary>
        public virtual string ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }

        /// <summary>
        /// Gets or sets the Direccion value.
        /// </summary>
        public virtual string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        /// <summary>
        /// Gets or sets the Idcodloc value.
        /// </summary>
        public virtual int Idcodloc
        {
            get { return idcodloc; }
            set { idcodloc = value; }
        }

        /// <summary>
        /// Gets or sets the IdTipoIVA value.
        /// </summary>
        public virtual int IdTipoIVA
        {
            get { return idTipoIVA; }
            set { idTipoIVA = value; }
        }

        /// <summary>
        /// Gets or sets the CUIT value.
        /// </summary>
        public virtual string CUIT
        {
            get { return cUIT; }
            set { cUIT = value; }
        }

        /// <summary>
        /// Gets or sets the Telefono value.
        /// </summary>
        public virtual string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        /// <summary>
        /// Gets or sets the Observaciones value.
        /// </summary>
        public virtual string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        /// <summary>
        /// Gets or sets the IdTipoFactura value.
        /// </summary>
        public virtual int IdTipoFactura
        {
            get { return idTipoFactura; }
            set { idTipoFactura = value; }
        }

        #endregion
    }
}
