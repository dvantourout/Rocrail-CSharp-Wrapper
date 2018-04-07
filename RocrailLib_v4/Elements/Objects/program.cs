using System.Collections.Generic;
using System.Linq;

namespace RocrailLib_v4.Elements
{
	public class program : CRocrailElements
	{
		public const int ACC_GETPARAM = 38;
		public const int ACC_SETPARAM = 37;
		public const int BOOTMODE = 22;
		public const int DATARSP = 7;
		public const int EVCLRALL = 20;
		public const int EVDELETE = 19;
		public const int EVGET = 13;
		public const int EVGETALL = 16;
		public const int EVGETVAR = 21;
		public const int EVSET = 12;
		public const int FB_SETADDR = 39;
		public const int GET = 0;
		public const int GETLASTERROR = 46;
		public const int GETOPTIONS = 47;
		public const int IDENTIFY = 44;
		public const int LEARN = 17;
		public const int LNCVEND = 2;
		public const int LNCVGET = 9;
		public const int LNCVSET = 10;
		public const int LNCVSTART = 1;
		public const int LNTYPE_BIDIB = 7;
		public const int LNTYPE_CBUS = 6;
		public const int LNTYPE_CS = 3;
		public const int LNTYPE_CV = 1;
		public const int LNTYPE_MP = 4;
		public const int LNTYPE_NONE = 0;
		public const int LNTYPE_OPSW = 5;
		public const int LNTYPE_ROCNET = 8;
		public const int LNTYPE_SV = 2;
		public const int LOAD = 6;
		public const int MACRO_DELETE = 32;
		public const int MACRO_GET = 34;
		public const int MACRO_GETPARAMS = 36;
		public const int MACRO_RESTORE = 30;
		public const int MACRO_SAVE = 31;
		public const int MACRO_SET = 33;
		public const int MACRO_SETPARAMS = 35;
		public const int MODE_DIRECT = 1;
		public const int MODE_PAGE = 0;
		public const int MODE_REGISTER = 2;
		public const int MPRSP = 11;
		public const int NNCONF = 15;
		public const int NNREQ = 14;
		public const int NVGET = 9;
		public const int NVSET = 10;
		public const int PING = 45;
		public const int POMACK = 40;
		public const int PORTTYPE_ANALOG = 5;
		public const int PORTTYPE_LIGHT = 1;
		public const int PORTTYPE_MACRO = 6;
		public const int PORTTYPE_MOTOR = 4;
		public const int PORTTYPE_SERVO = 2;
		public const int PORTTYPE_SOUND = 3;
		public const int PORTTYPE_SWITCH = 0;
		public const int PTOFF = 3;
		public const int PTON = 2;
		public const int PTSTAT = 4;
		public const int QUERY = 25;
		public const int RC_ERROR = 2;
		public const int RC_NOTFWUP = 1;
		public const int RC_OK = 0;
		public const int RESET = 24;
		public const int SAVE = 5;
		public const int SET = 1;
		public const int SETCHANNEL = 51;
		public const int SETOPTIONS = 48;
		public const int SHOW = 49;
		public const int STATUSRSP = 8;
		public const int TYPE = 26;
		public const int UNLEARN = 18;
		public const int UPDATE = 50;
		public const int VENDORCVENABLE = 43;
		public const int VENDORCVGET = 42;
		public const int VENDORCVSET = 41;
		public const int WRITEHEX = 23;
		private bool? m_acc;
		private int? m_addr;
		private int? m_cmd;
		private int? m_cv;
		private int? m_decaddr;
		private bool? m_eeprom;
		private string m_filename;
		private string m_iid;
		private bool? m_lncv;
		private int? m_lncvcmd;
		private int? m_lntype;
		private bool? m_longaddr;
		private int? m_manu;
		private int? m_mode;
		private int? m_modid;
		private bool? m_pom;
		private int? m_porttype;
		private int? m_prod;
		private int? m_rc;
		private int? m_rs;
		private string m_strval1;
		private string m_strval2;
		private string m_strval3;
		private int? m_val1;
		private int? m_val10;
		private int? m_val11;
		private int? m_val12;
		private int? m_val13;
		private int? m_val14;
		private int? m_val15;
		private int? m_val16;
		private int? m_val17;
		private int? m_val18;
		private int? m_val19;
		private int? m_val2;
		private int? m_val20;
		private int? m_val21;
		private int? m_val22;
		private int? m_val23;
		private int? m_val24;
		private int? m_val25;
		private int? m_val26;
		private int? m_val27;
		private int? m_val28;
		private int? m_val29;
		private int? m_val3;
		private int? m_val30;
		private int? m_val31;
		private int? m_val32;
		private int? m_val33;
		private int? m_val34;
		private int? m_val35;
		private int? m_val36;
		private int? m_val37;
		private int? m_val38;
		private int? m_val39;
		private int? m_val4;
		private int? m_val40;
		private int? m_val41;
		private int? m_val42;
		private int? m_val43;
		private int? m_val44;
		private int? m_val45;
		private int? m_val46;
		private int? m_val47;
		private int? m_val48;
		private int? m_val49;
		private int? m_val5;
		private int? m_val50;
		private int? m_val6;
		private int? m_val7;
		private int? m_val8;
		private int? m_val9;
		private int? m_value;
		private int? m_version;
		/// <summary>
		/// POM Program On the Main for accessory decoders
		/// </summary>
		public bool acc 
		{
			get { return this.m_acc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_acc, value, "acc"); }
		}
		/// <summary>
		/// loco address for POM
		/// </summary>
		public int addr 
		{
			get { return this.m_addr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_addr, value, "addr"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int cmd 
		{
			get { return this.m_cmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cmd, value, "cmd"); }
		}
		/// <summary>
		/// CV number
		/// </summary>
		public int cv 
		{
			get { return this.m_cv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_cv, value, "cv"); }
		}
		/// <summary>
		/// decoder address in case of POM
		/// </summary>
		public int decaddr 
		{
			get { return this.m_decaddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_decaddr, value, "decaddr"); }
		}
		/// <summary>
		/// Write EEprom.
		/// </summary>
		public bool eeprom 
		{
			get { return this.m_eeprom.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_eeprom, value, "eeprom"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string filename 
		{
			get { return this.m_filename; }
			private set { this.SetField(ref this.m_filename, value, "filename"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string iid 
		{
			get { return this.m_iid; }
			private set { this.SetField(ref this.m_iid, value, "iid"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public bool lncv 
		{
			get { return this.m_lncv.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_lncv, value, "lncv"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int lncvcmd 
		{
			get { return this.m_lncvcmd.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_lncvcmd, value, "lncvcmd"); }
		}
		/// <summary>
		/// LNCV programming type
		/// </summary>
		public int lntype 
		{
			get { return this.m_lntype.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_lntype, value, "lntype"); }
		}
		/// <summary>
		/// loco address for POM
		/// </summary>
		public bool longaddr 
		{
			get { return this.m_longaddr.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_longaddr, value, "longaddr"); }
		}
		/// <summary>
		/// manufacturer ID
		/// </summary>
		public int manu 
		{
			get { return this.m_manu.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_manu, value, "manu"); }
		}
		/// <summary>
		/// Programming mode.
		/// </summary>
		public int mode 
		{
			get { return this.m_mode.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_mode, value, "mode"); }
		}
		/// <summary>
		/// module id for use with lncv
		/// </summary>
		public int modid 
		{
			get { return this.m_modid.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_modid, value, "modid"); }
		}
		/// <summary>
		/// POM Program On the Main
		/// </summary>
		public bool pom 
		{
			get { return this.m_pom.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_pom, value, "pom"); }
		}
		/// <summary>
		/// Port type
		/// </summary>
		public int porttype 
		{
			get { return this.m_porttype.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_porttype, value, "porttype"); }
		}
		/// <summary>
		/// product ID
		/// </summary>
		public int prod 
		{
			get { return this.m_prod.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_prod, value, "prod"); }
		}
		/// <summary>
		/// return code
		/// </summary>
		public int rc 
		{
			get { return this.m_rc.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_rc, value, "rc"); }
		}
		/// <summary>
		/// reason code
		/// </summary>
		public int rs 
		{
			get { return this.m_rs.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_rs, value, "rs"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string strval1 
		{
			get { return this.m_strval1; }
			private set { this.SetField(ref this.m_strval1, value, "strval1"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string strval2 
		{
			get { return this.m_strval2; }
			private set { this.SetField(ref this.m_strval2, value, "strval2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public string strval3 
		{
			get { return this.m_strval3; }
			private set { this.SetField(ref this.m_strval3, value, "strval3"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val1 
		{
			get { return this.m_val1.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val1, value, "val1"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val10 
		{
			get { return this.m_val10.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val10, value, "val10"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val11 
		{
			get { return this.m_val11.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val11, value, "val11"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val12 
		{
			get { return this.m_val12.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val12, value, "val12"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val13 
		{
			get { return this.m_val13.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val13, value, "val13"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val14 
		{
			get { return this.m_val14.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val14, value, "val14"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val15 
		{
			get { return this.m_val15.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val15, value, "val15"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val16 
		{
			get { return this.m_val16.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val16, value, "val16"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val17 
		{
			get { return this.m_val17.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val17, value, "val17"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val18 
		{
			get { return this.m_val18.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val18, value, "val18"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val19 
		{
			get { return this.m_val19.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val19, value, "val19"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val2 
		{
			get { return this.m_val2.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val2, value, "val2"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val20 
		{
			get { return this.m_val20.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val20, value, "val20"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val21 
		{
			get { return this.m_val21.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val21, value, "val21"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val22 
		{
			get { return this.m_val22.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val22, value, "val22"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val23 
		{
			get { return this.m_val23.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val23, value, "val23"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val24 
		{
			get { return this.m_val24.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val24, value, "val24"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val25 
		{
			get { return this.m_val25.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val25, value, "val25"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val26 
		{
			get { return this.m_val26.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val26, value, "val26"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val27 
		{
			get { return this.m_val27.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val27, value, "val27"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val28 
		{
			get { return this.m_val28.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val28, value, "val28"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val29 
		{
			get { return this.m_val29.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val29, value, "val29"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val3 
		{
			get { return this.m_val3.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val3, value, "val3"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val30 
		{
			get { return this.m_val30.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val30, value, "val30"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val31 
		{
			get { return this.m_val31.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val31, value, "val31"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val32 
		{
			get { return this.m_val32.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val32, value, "val32"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val33 
		{
			get { return this.m_val33.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val33, value, "val33"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val34 
		{
			get { return this.m_val34.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val34, value, "val34"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val35 
		{
			get { return this.m_val35.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val35, value, "val35"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val36 
		{
			get { return this.m_val36.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val36, value, "val36"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val37 
		{
			get { return this.m_val37.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val37, value, "val37"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val38 
		{
			get { return this.m_val38.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val38, value, "val38"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val39 
		{
			get { return this.m_val39.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val39, value, "val39"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val4 
		{
			get { return this.m_val4.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val4, value, "val4"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val40 
		{
			get { return this.m_val40.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val40, value, "val40"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val41 
		{
			get { return this.m_val41.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val41, value, "val41"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val42 
		{
			get { return this.m_val42.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val42, value, "val42"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val43 
		{
			get { return this.m_val43.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val43, value, "val43"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val44 
		{
			get { return this.m_val44.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val44, value, "val44"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val45 
		{
			get { return this.m_val45.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val45, value, "val45"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val46 
		{
			get { return this.m_val46.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val46, value, "val46"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val47 
		{
			get { return this.m_val47.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val47, value, "val47"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val48 
		{
			get { return this.m_val48.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val48, value, "val48"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val49 
		{
			get { return this.m_val49.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val49, value, "val49"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val5 
		{
			get { return this.m_val5.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val5, value, "val5"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val50 
		{
			get { return this.m_val50.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val50, value, "val50"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val6 
		{
			get { return this.m_val6.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val6, value, "val6"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val7 
		{
			get { return this.m_val7.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val7, value, "val7"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val8 
		{
			get { return this.m_val8.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val8, value, "val8"); }
		}
		/// <summary>
		/// 
		/// </summary>
		public int val9 
		{
			get { return this.m_val9.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_val9, value, "val9"); }
		}
		/// <summary>
		/// CV value
		/// </summary>
		public int @value 
		{
			get { return this.m_value.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_value, value, "@value"); }
		}
		/// <summary>
		/// firmware version
		/// </summary>
		public int version 
		{
			get { return this.m_version.GetValueOrDefault(); }
			private set { this.SetField(ref this.m_version, value, "version"); }
		}
		public program()
		{
		}
		public static program Parse(System.Xml.Linq.XElement xml, CRocrailClient rocrailClient)
		{
			program _program = new program();
			_program.m_rocrailClient = rocrailClient;
			_program.m_acc = (bool?)xml.Attribute("acc");
			_program.m_addr = (int?)xml.Attribute("addr");
			_program.m_cmd = (int?)xml.Attribute("cmd");
			_program.m_cv = (int?)xml.Attribute("cv");
			_program.m_decaddr = (int?)xml.Attribute("decaddr");
			_program.m_eeprom = (bool?)xml.Attribute("eeprom");
			_program.m_filename = (string)xml.Attribute("filename");
			_program.m_iid = (string)xml.Attribute("iid");
			_program.m_lncv = (bool?)xml.Attribute("lncv");
			_program.m_lncvcmd = (int?)xml.Attribute("lncvcmd");
			_program.m_lntype = (int?)xml.Attribute("lntype");
			_program.m_longaddr = (bool?)xml.Attribute("longaddr");
			_program.m_manu = (int?)xml.Attribute("manu");
			_program.m_mode = (int?)xml.Attribute("mode");
			_program.m_modid = (int?)xml.Attribute("modid");
			_program.m_pom = (bool?)xml.Attribute("pom");
			_program.m_porttype = (int?)xml.Attribute("porttype");
			_program.m_prod = (int?)xml.Attribute("prod");
			_program.m_rc = (int?)xml.Attribute("rc");
			_program.m_rs = (int?)xml.Attribute("rs");
			_program.m_strval1 = (string)xml.Attribute("strval1");
			_program.m_strval2 = (string)xml.Attribute("strval2");
			_program.m_strval3 = (string)xml.Attribute("strval3");
			_program.m_val1 = (int?)xml.Attribute("val1");
			_program.m_val10 = (int?)xml.Attribute("val10");
			_program.m_val11 = (int?)xml.Attribute("val11");
			_program.m_val12 = (int?)xml.Attribute("val12");
			_program.m_val13 = (int?)xml.Attribute("val13");
			_program.m_val14 = (int?)xml.Attribute("val14");
			_program.m_val15 = (int?)xml.Attribute("val15");
			_program.m_val16 = (int?)xml.Attribute("val16");
			_program.m_val17 = (int?)xml.Attribute("val17");
			_program.m_val18 = (int?)xml.Attribute("val18");
			_program.m_val19 = (int?)xml.Attribute("val19");
			_program.m_val2 = (int?)xml.Attribute("val2");
			_program.m_val20 = (int?)xml.Attribute("val20");
			_program.m_val21 = (int?)xml.Attribute("val21");
			_program.m_val22 = (int?)xml.Attribute("val22");
			_program.m_val23 = (int?)xml.Attribute("val23");
			_program.m_val24 = (int?)xml.Attribute("val24");
			_program.m_val25 = (int?)xml.Attribute("val25");
			_program.m_val26 = (int?)xml.Attribute("val26");
			_program.m_val27 = (int?)xml.Attribute("val27");
			_program.m_val28 = (int?)xml.Attribute("val28");
			_program.m_val29 = (int?)xml.Attribute("val29");
			_program.m_val3 = (int?)xml.Attribute("val3");
			_program.m_val30 = (int?)xml.Attribute("val30");
			_program.m_val31 = (int?)xml.Attribute("val31");
			_program.m_val32 = (int?)xml.Attribute("val32");
			_program.m_val33 = (int?)xml.Attribute("val33");
			_program.m_val34 = (int?)xml.Attribute("val34");
			_program.m_val35 = (int?)xml.Attribute("val35");
			_program.m_val36 = (int?)xml.Attribute("val36");
			_program.m_val37 = (int?)xml.Attribute("val37");
			_program.m_val38 = (int?)xml.Attribute("val38");
			_program.m_val39 = (int?)xml.Attribute("val39");
			_program.m_val4 = (int?)xml.Attribute("val4");
			_program.m_val40 = (int?)xml.Attribute("val40");
			_program.m_val41 = (int?)xml.Attribute("val41");
			_program.m_val42 = (int?)xml.Attribute("val42");
			_program.m_val43 = (int?)xml.Attribute("val43");
			_program.m_val44 = (int?)xml.Attribute("val44");
			_program.m_val45 = (int?)xml.Attribute("val45");
			_program.m_val46 = (int?)xml.Attribute("val46");
			_program.m_val47 = (int?)xml.Attribute("val47");
			_program.m_val48 = (int?)xml.Attribute("val48");
			_program.m_val49 = (int?)xml.Attribute("val49");
			_program.m_val5 = (int?)xml.Attribute("val5");
			_program.m_val50 = (int?)xml.Attribute("val50");
			_program.m_val6 = (int?)xml.Attribute("val6");
			_program.m_val7 = (int?)xml.Attribute("val7");
			_program.m_val8 = (int?)xml.Attribute("val8");
			_program.m_val9 = (int?)xml.Attribute("val9");
			_program.m_value = (int?)xml.Attribute("value");
			_program.m_version = (int?)xml.Attribute("version");
			return _program;
		}
		public void Update(program element)
		{
			if(element.m_acc.HasValue == true) this.acc = element.acc;
			if(element.m_addr.HasValue == true) this.addr = element.addr;
			if(element.m_cmd.HasValue == true) this.cmd = element.cmd;
			if(element.m_cv.HasValue == true) this.cv = element.cv;
			if(element.m_decaddr.HasValue == true) this.decaddr = element.decaddr;
			if(element.m_eeprom.HasValue == true) this.eeprom = element.eeprom;
			if(element.m_filename != null) this.filename = element.filename;
			if(element.m_iid != null) this.iid = element.iid;
			if(element.m_lncv.HasValue == true) this.lncv = element.lncv;
			if(element.m_lncvcmd.HasValue == true) this.lncvcmd = element.lncvcmd;
			if(element.m_lntype.HasValue == true) this.lntype = element.lntype;
			if(element.m_longaddr.HasValue == true) this.longaddr = element.longaddr;
			if(element.m_manu.HasValue == true) this.manu = element.manu;
			if(element.m_mode.HasValue == true) this.mode = element.mode;
			if(element.m_modid.HasValue == true) this.modid = element.modid;
			if(element.m_pom.HasValue == true) this.pom = element.pom;
			if(element.m_porttype.HasValue == true) this.porttype = element.porttype;
			if(element.m_prod.HasValue == true) this.prod = element.prod;
			if(element.m_rc.HasValue == true) this.rc = element.rc;
			if(element.m_rs.HasValue == true) this.rs = element.rs;
			if(element.m_strval1 != null) this.strval1 = element.strval1;
			if(element.m_strval2 != null) this.strval2 = element.strval2;
			if(element.m_strval3 != null) this.strval3 = element.strval3;
			if(element.m_val1.HasValue == true) this.val1 = element.val1;
			if(element.m_val10.HasValue == true) this.val10 = element.val10;
			if(element.m_val11.HasValue == true) this.val11 = element.val11;
			if(element.m_val12.HasValue == true) this.val12 = element.val12;
			if(element.m_val13.HasValue == true) this.val13 = element.val13;
			if(element.m_val14.HasValue == true) this.val14 = element.val14;
			if(element.m_val15.HasValue == true) this.val15 = element.val15;
			if(element.m_val16.HasValue == true) this.val16 = element.val16;
			if(element.m_val17.HasValue == true) this.val17 = element.val17;
			if(element.m_val18.HasValue == true) this.val18 = element.val18;
			if(element.m_val19.HasValue == true) this.val19 = element.val19;
			if(element.m_val2.HasValue == true) this.val2 = element.val2;
			if(element.m_val20.HasValue == true) this.val20 = element.val20;
			if(element.m_val21.HasValue == true) this.val21 = element.val21;
			if(element.m_val22.HasValue == true) this.val22 = element.val22;
			if(element.m_val23.HasValue == true) this.val23 = element.val23;
			if(element.m_val24.HasValue == true) this.val24 = element.val24;
			if(element.m_val25.HasValue == true) this.val25 = element.val25;
			if(element.m_val26.HasValue == true) this.val26 = element.val26;
			if(element.m_val27.HasValue == true) this.val27 = element.val27;
			if(element.m_val28.HasValue == true) this.val28 = element.val28;
			if(element.m_val29.HasValue == true) this.val29 = element.val29;
			if(element.m_val3.HasValue == true) this.val3 = element.val3;
			if(element.m_val30.HasValue == true) this.val30 = element.val30;
			if(element.m_val31.HasValue == true) this.val31 = element.val31;
			if(element.m_val32.HasValue == true) this.val32 = element.val32;
			if(element.m_val33.HasValue == true) this.val33 = element.val33;
			if(element.m_val34.HasValue == true) this.val34 = element.val34;
			if(element.m_val35.HasValue == true) this.val35 = element.val35;
			if(element.m_val36.HasValue == true) this.val36 = element.val36;
			if(element.m_val37.HasValue == true) this.val37 = element.val37;
			if(element.m_val38.HasValue == true) this.val38 = element.val38;
			if(element.m_val39.HasValue == true) this.val39 = element.val39;
			if(element.m_val4.HasValue == true) this.val4 = element.val4;
			if(element.m_val40.HasValue == true) this.val40 = element.val40;
			if(element.m_val41.HasValue == true) this.val41 = element.val41;
			if(element.m_val42.HasValue == true) this.val42 = element.val42;
			if(element.m_val43.HasValue == true) this.val43 = element.val43;
			if(element.m_val44.HasValue == true) this.val44 = element.val44;
			if(element.m_val45.HasValue == true) this.val45 = element.val45;
			if(element.m_val46.HasValue == true) this.val46 = element.val46;
			if(element.m_val47.HasValue == true) this.val47 = element.val47;
			if(element.m_val48.HasValue == true) this.val48 = element.val48;
			if(element.m_val49.HasValue == true) this.val49 = element.val49;
			if(element.m_val5.HasValue == true) this.val5 = element.val5;
			if(element.m_val50.HasValue == true) this.val50 = element.val50;
			if(element.m_val6.HasValue == true) this.val6 = element.val6;
			if(element.m_val7.HasValue == true) this.val7 = element.val7;
			if(element.m_val8.HasValue == true) this.val8 = element.val8;
			if(element.m_val9.HasValue == true) this.val9 = element.val9;
			if(element.m_value.HasValue == true) this.@value = element.@value;
			if(element.m_version.HasValue == true) this.version = element.version;
		}
	}
}
