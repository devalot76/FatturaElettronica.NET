using BusinessObjects.Validators;

namespace FatturaElettronica.Validators
{
    /// <summary>
    /// Validates FatturaElettronicaBody.DatiGenerali.DatiBeniServizi.DatiRiepilogo.EsigibilitaIVA.
    /// </summary>
    public class FEsigibilitaIVAValidator : DomainValidator
    {
        private const string BrokenDescription = "Valori ammessi [I] immediata, [D] differita, [S] scissione dei pagamenti.";

        /// <summary>
        /// Validates FatturaElettronicaBody.DatiGenerali.DatiBeniServizi.DatiRiepilogo.EsigibilitaIVA.
        /// </summary>
        public FEsigibilitaIVAValidator() : this(null, BrokenDescription) { }
        public FEsigibilitaIVAValidator(string propertyName) : this(propertyName, BrokenDescription) { }
        public FEsigibilitaIVAValidator(string propertyName, string description) : base(propertyName, description)
        {
            Domain = new[] { "I", "D", "S" };
        }
    }
}
