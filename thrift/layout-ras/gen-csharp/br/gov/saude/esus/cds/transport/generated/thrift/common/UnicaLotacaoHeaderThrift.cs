/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esus.cds.transport.generated.thrift.common
{

  /// <summary>
  /// Representa um profissional
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class UnicaLotacaoHeaderThrift : TBase
  {
    private string _profissionalCNS;
    private string _cboCodigo_2002;
    private string _ine;
    private long _dataAtendimento;
    private string _codigoIbgeMunicipio;

    public string ProfissionalCNS
    {
      get
      {
        return _profissionalCNS;
      }
      set
      {
        __isset.profissionalCNS = true;
        this._profissionalCNS = value;
      }
    }

    public string CboCodigo_2002
    {
      get
      {
        return _cboCodigo_2002;
      }
      set
      {
        __isset.cboCodigo_2002 = true;
        this._cboCodigo_2002 = value;
      }
    }

    public string Cnes { get; set; }

    public string Ine
    {
      get
      {
        return _ine;
      }
      set
      {
        __isset.ine = true;
        this._ine = value;
      }
    }

    public long DataAtendimento
    {
      get
      {
        return _dataAtendimento;
      }
      set
      {
        __isset.dataAtendimento = true;
        this._dataAtendimento = value;
      }
    }

    public string CodigoIbgeMunicipio
    {
      get
      {
        return _codigoIbgeMunicipio;
      }
      set
      {
        __isset.codigoIbgeMunicipio = true;
        this._codigoIbgeMunicipio = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool profissionalCNS;
      public bool cboCodigo_2002;
      public bool ine;
      public bool dataAtendimento;
      public bool codigoIbgeMunicipio;
    }

    public UnicaLotacaoHeaderThrift() {
    }

    public UnicaLotacaoHeaderThrift(string cnes) : this() {
      this.Cnes = cnes;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_cnes = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              ProfissionalCNS = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              CboCodigo_2002 = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Cnes = iprot.ReadString();
              isset_cnes = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Ine = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I64) {
              DataAtendimento = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              CodigoIbgeMunicipio = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_cnes)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("UnicaLotacaoHeaderThrift");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ProfissionalCNS != null && __isset.profissionalCNS) {
        field.Name = "profissionalCNS";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ProfissionalCNS);
        oprot.WriteFieldEnd();
      }
      if (CboCodigo_2002 != null && __isset.cboCodigo_2002) {
        field.Name = "cboCodigo_2002";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CboCodigo_2002);
        oprot.WriteFieldEnd();
      }
      field.Name = "cnes";
      field.Type = TType.String;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Cnes);
      oprot.WriteFieldEnd();
      if (Ine != null && __isset.ine) {
        field.Name = "ine";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Ine);
        oprot.WriteFieldEnd();
      }
      if (__isset.dataAtendimento) {
        field.Name = "dataAtendimento";
        field.Type = TType.I64;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(DataAtendimento);
        oprot.WriteFieldEnd();
      }
      if (CodigoIbgeMunicipio != null && __isset.codigoIbgeMunicipio) {
        field.Name = "codigoIbgeMunicipio";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CodigoIbgeMunicipio);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("UnicaLotacaoHeaderThrift(");
      bool __first = true;
      if (ProfissionalCNS != null && __isset.profissionalCNS) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ProfissionalCNS: ");
        __sb.Append(ProfissionalCNS);
      }
      if (CboCodigo_2002 != null && __isset.cboCodigo_2002) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CboCodigo_2002: ");
        __sb.Append(CboCodigo_2002);
      }
      if(!__first) { __sb.Append(", "); }
      __sb.Append("Cnes: ");
      __sb.Append(Cnes);
      if (Ine != null && __isset.ine) {
        __sb.Append(", Ine: ");
        __sb.Append(Ine);
      }
      if (__isset.dataAtendimento) {
        __sb.Append(", DataAtendimento: ");
        __sb.Append(DataAtendimento);
      }
      if (CodigoIbgeMunicipio != null && __isset.codigoIbgeMunicipio) {
        __sb.Append(", CodigoIbgeMunicipio: ");
        __sb.Append(CodigoIbgeMunicipio);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
