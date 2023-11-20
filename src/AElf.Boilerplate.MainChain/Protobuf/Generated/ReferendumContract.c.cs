// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: referendum_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.Referendum {

  #region Events
  internal partial class ReferendumReceiptCreated : aelf::IEvent<ReferendumReceiptCreated>
  {
    public global::System.Collections.Generic.IEnumerable<ReferendumReceiptCreated> GetIndexed()
    {
      return new List<ReferendumReceiptCreated>
      {
      new ReferendumReceiptCreated
      {
        OrganizationAddress = OrganizationAddress
      },
      };
    }

    public ReferendumReceiptCreated GetNonIndexed()
    {
      return new ReferendumReceiptCreated
      {
        ProposalId = ProposalId,
        Address = Address,
        Symbol = Symbol,
        Amount = Amount,
        ReceiptType = ReceiptType,
        Time = Time,
      };
    }
  }

  #endregion
  internal static partial class ReferendumContractContainer
  {
    static readonly string __ServiceName = "Referendum.ReferendumContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Referendum.CreateOrganizationInput> __Marshaller_Referendum_CreateOrganizationInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Referendum.CreateOrganizationInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Referendum.CreateOrganizationBySystemContractInput> __Marshaller_Referendum_CreateOrganizationBySystemContractInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Referendum.CreateOrganizationBySystemContractInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Referendum.Organization> __Marshaller_Referendum_Organization = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Referendum.Organization.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ReclaimVoteToken = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ReclaimVoteToken",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Referendum.CreateOrganizationInput, global::AElf.Types.Address> __Method_CreateOrganization = new aelf::Method<global::AElf.Contracts.Referendum.CreateOrganizationInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateOrganization",
        __Marshaller_Referendum_CreateOrganizationInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Contracts.Referendum.CreateOrganizationBySystemContractInput, global::AElf.Types.Address> __Method_CreateOrganizationBySystemContract = new aelf::Method<global::AElf.Contracts.Referendum.CreateOrganizationBySystemContractInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateOrganizationBySystemContract",
        __Marshaller_Referendum_CreateOrganizationBySystemContractInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.Referendum.Organization> __Method_GetOrganization = new aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.Referendum.Organization>(
        aelf::MethodType.View,
        __ServiceName,
        "GetOrganization",
        __Marshaller_aelf_Address,
        __Marshaller_Referendum_Organization);

    static readonly aelf::Method<global::AElf.Contracts.Referendum.CreateOrganizationInput, global::AElf.Types.Address> __Method_CalculateOrganizationAddress = new aelf::Method<global::AElf.Contracts.Referendum.CreateOrganizationInput, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "CalculateOrganizationAddress",
        __Marshaller_Referendum_CreateOrganizationInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address> __Method_GetProposalVirtualAddress = new aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "GetProposalVirtualAddress",
        __Marshaller_aelf_Hash,
        __Marshaller_aelf_Address);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.Referendum.ReferendumContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.Referendum.ReferendumContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ReferendumContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> ReclaimVoteToken
      {
        get { return __factory.Create(__Method_ReclaimVoteToken); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Referendum.CreateOrganizationInput, global::AElf.Types.Address> CreateOrganization
      {
        get { return __factory.Create(__Method_CreateOrganization); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Referendum.CreateOrganizationBySystemContractInput, global::AElf.Types.Address> CreateOrganizationBySystemContract
      {
        get { return __factory.Create(__Method_CreateOrganizationBySystemContract); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::AElf.Contracts.Referendum.Organization> GetOrganization
      {
        get { return __factory.Create(__Method_GetOrganization); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Referendum.CreateOrganizationInput, global::AElf.Types.Address> CalculateOrganizationAddress
      {
        get { return __factory.Create(__Method_CalculateOrganizationAddress); }
      }

      public aelf::IMethodStub<global::AElf.Types.Hash, global::AElf.Types.Address> GetProposalVirtualAddress
      {
        get { return __factory.Create(__Method_GetProposalVirtualAddress); }
      }

    }
  }
}
#endregion

