using AElf.Standards.ACS0;
using AElfTest.Contract;

namespace Portkey.Contracts.CryptoBox
{
    /// <summary>
    /// The state class of the contract, it inherits from the AElf.Sdk.CSharp.State.ContractState type. 
    /// </summary>
    public partial class CryptoBoxContractState
    {
        // state definitions go here.
        internal ACS0Container.ACS0ReferenceState GenesisContract { get; set; }
        internal AElfTestContractContainer.AElfTestContractReferenceState TokenContract { get; set; }
    }
}