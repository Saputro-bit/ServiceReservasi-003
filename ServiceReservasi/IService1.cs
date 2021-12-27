﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IService1
	{
		[OperationContract]
		string Login(string username, string password);
		[OperationContract]
		string Register(string username, string password, string kategori);
		[OperationContract]
		string UpdateRegister(string username, string password, string kategori, int id);
		[OperationContract]
		string DeleteRegister(string username);
		[OperationContract]
		List<DataRegister> DataRegist();
		[OperationContract]
		string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi);
		[OperationContract]
		string editPemesanan(string IDPemesanan, string NamaCustomer, string No_telpon);
		[OperationContract]
		string deletePemesanan(string IDPemesanan);
		[OperationContract]
		List<CekLokasi> ReviewLokasi();
		[OperationContract]
		List<DetailLokasi> DetailLokasi();
		[OperationContract]
		List<Pemesanan> Pemesanan();

		// TODO: Add your service operations here
	}

	// Use a data contract as illustrated in the sample below to add composite types to service operations.
	// You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceReservasi.ContractType".
	[DataContract]
	public class CekLokasi
	{
		[DataMember]
		public string IDLokasi { get; set; }
		[DataMember]
		public string NamaLokasi { get; set; }
		[DataMember]
		public string DeskripsiSingkat { get; set; }
	}
	[DataContract]
	public class DetailLokasi
	{
		[DataMember]
		public string IDLokasi { get; set; }
		[DataMember]
		public string NamaLokasi { get; set; }
		[DataMember]
		public string DeskripsiFull { get; set; }
		[DataMember]
		public int Kuota { get; set; }
	}
	[DataContract]
	public class Pemesanan
	{
		[DataMember]
		public string IDPemesanan { get; set; }
		[DataMember]
		public string NamaCustomer { get; set; }
		[DataMember]
		public string NoTelpon { get; set; }
		[DataMember]
		public int JumlahPemesanan { get; set; }
		[DataMember]
		public string Lokasi { get; set; }
	}
	[DataContract]
	public class DataRegister
	{
		[DataMember(Order = 1)]
		public int id { get; set; }
		[DataMember(Order = 2)]
		public string username { get; set; }
		[DataMember(Order = 3)]
		public string password { get; set; }
		[DataMember(Order = 4)]
		public string kategori { get; set; }
	}
	[DataContract]
	public class CompositeType
	{
		bool boolValue = true;
		string stringValue = "Hello ";

		[DataMember]
		public bool BoolValue
		{
			get { return boolValue; }
			set { boolValue = value; }
		}

		[DataMember]
		public string StringValue
		{
			get { return stringValue; }
			set { stringValue = value; }
		}
	}
}